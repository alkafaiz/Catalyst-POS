using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS
{
    public partial class UserControlNewProduct : UserControl
    {
        Image File;
        List<Product> preProducts = new List<Product>();
        public UserControlNewProduct()
        {
            InitializeComponent();
            comboType.SelectedIndex = 0;
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddType())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    comboType.Items.Add(form.newType);
                    comboType.SelectedItem = form.newType;
                }
            }
        }

        private void btnSetPrice_Click(object sender, EventArgs e)
        {
            //if (txtVarian.Text != "" && txtDesc.Text != "" && numericUpDownMinPurchase.Value!=0 )
            //{                
                using (var form = new FormSetPrice(preProduct()))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                    FormDashboard.Instance.showProductRefresh();
                        //if (!FormDashboard.Instance.PanelContent.Controls.ContainsKey("userControlProducts"))
                        //{
                        //    UserControlProducts prod = new UserControlProducts();
                        //    prod.Dock = DockStyle.Fill;
                        //    FormDashboard.Instance.PanelContent.Controls.Add(prod);
                        //}
                        //FormDashboard.Instance.PanelContent.Controls["userControlProducts"].BringToFront();
                    }
                }
            //}
            
            //else
            //{
            //    if (numericUpDownMinPurchase.Value == 0)
            //    {
            //        MessageBox.Show("Minimal purchase cannot be 0.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please fill all the field.");
            //    }
            //}
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //using (FormDashboard f = new FormDashboard())
            //{
            //    f.showForm("userControlProducts");
            //    Console.WriteLine("Yessss");
            //    this.Hide(); 
            //}
            FormDashboard.Instance.showForm("UserControlProducts");
            //if (!FormDashboard.Instance.PanelContent.Controls.ContainsKey("userControlProducts"))
            //{
            //    UserControlProducts prod = new UserControlProducts();
            //    prod.Dock = DockStyle.Fill;
            //    FormDashboard.Instance.PanelContent.Controls.Add(prod);
            //}
            //FormDashboard.Instance.PanelContent.Controls["userControlProducts"].BringToFront();
        }

        private Product preProduct()
        {
            Product pr = new Product();
            Guid ID = Guid.NewGuid();
            pr.ProductID = ID.ToString();
            pr.Type = comboType.Text;                                  
            pr.Varian = comboVarian.Text;            
            pr.Description = txtDesc.Text;
            pr.Size = comboSize.Text;
            pr.Extra = comboExtra.Text;
            pr.MinPurchase = Convert.ToInt32(numericUpDownMinPurchase.Value);
            pr.Picture = File;
            String name = "";
            if (pr.Type == "PIZZA" && lblSubVarian.Visible == false)
            {
                name += pr.Varian + " " + pr.Size + " " + pr.Type + " WITH " + pr.Extra;
            }
            if (pr.Type == "PIZZA" && lblSubVarian.Visible == true)
            {
                pr.SubVarian = comboSubVarian.Text;
                name += pr.Varian + " " + pr.SubVarian + " " + pr.Extra;                
            }
            if (pr.Type == "BURGER")
            {
                name += txtName.Text;
                pr.Varian = "BURGER";
            }
            if (pr.Type == "HOTDOG")
            {
                name += txtName.Text;
                pr.Varian = "HOTDOG";
            }
            if (pr.Type == "OTHER")
            {                
                name += txtName.Text;
                pr.Varian = "OTHER";
            }
            pr.Name = name;
            pr.InStock = false;
            return pr;
        }
        

        private void btnSelectPict_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBoxProduct.Image = File;
                lblFileName.Visible = false;
                txtFile.Visible = true;
                txtFile.Text = f.FileName;
                
            }
        }

        private void btnNewVarian_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddVarian())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    comboVarian.Items.Add(form.newVarian);
                    comboVarian.SelectedItem = form.newVarian;
                }
            }
        }
        

        private void UserControlNewProduct_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<String> varians = emp.loadVarian();           
            for (int i = 0; i < varians.Count; i++)
            {
                comboVarian.Items.Add(varians[i].ToString());
                if(varians[i].ToString() != "SPECIAL MOZARELLA BITES" || varians[i].ToString() != "SPECIAL SOSIS BITES")
                {
                    comboSubVarian.Items.Add(varians[i].ToString());
                }
            }            
            comboVarian.SelectedIndex = 1;
            checkSubVarian();
        }

        private void checkSubVarian()
        {
            if (comboVarian.Text == "SPECIAL SOSIS BITES" || comboVarian.Text == "SPECIAL MOZARELLA BITES")
            {
                lblSubVarian.Visible = true; comboSubVarian.Visible = true;
                lblDesc.Top = 144; txtDesc.Top = 141; txtDesc.Height = 95;
            }
            else
            {
                lblDesc.Top = lblSubVarian.Top;txtDesc.Top = comboSubVarian.Top; txtDesc.Height = 131;
                lblSubVarian.Visible = false; comboSubVarian.Visible = false;
                
            }
        }

        private void checktype()
        {
            if(comboType.Text=="HOTDOG" || comboType.Text == "BURGER" || comboType.Text == "OTHER")
            {
                lblVarian.Visible = false;comboVarian.Visible = false;
                lblSubVarian.Visible = false; comboSubVarian.Visible = false;
                lblName.Visible = true; txtName.Visible = true;
                btnNewVarian.Visible = false;
                lblName.Top = lblVarian.Top; txtName.Top = comboVarian.Top;
                lblDesc.Top = lblSubVarian.Top; txtDesc.Top = comboSubVarian.Top; txtDesc.Height = 131;
                comboSize.Items.Clear(); comboSize.Items.Add("ONE SIZE");
                comboExtra.Items.Clear(); comboExtra.Items.Add("N/A");
            }
            else
            {
                lblVarian.Visible = true; comboVarian.Visible = true;
                lblSubVarian.Visible = true; comboSubVarian.Visible = true;
                lblName.Visible = false; txtName.Visible = false;
                btnNewVarian.Visible = true;
                comboVarian.SelectedIndex = 0;
                checkSubVarian();
            }
        }

        private void comboVarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubVarian();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            checktype();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblVarian_Click(object sender, EventArgs e)
        {

        }
    }
}
