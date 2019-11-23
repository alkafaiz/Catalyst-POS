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
    public partial class UserControlEditProduct : UserControl
    {
        String filename;
        String imgLoc;
        Product pr;
        Employee emp = new Employee();
        public UserControlEditProduct()
        {
            InitializeComponent();
        }
        public UserControlEditProduct(Product prod)
        {
            InitializeComponent();
            pr = prod;
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
                lblDesc.Top = lblSubVarian.Top; txtDesc.Top = comboSubVarian.Top; txtDesc.Height = 131;
                lblSubVarian.Visible = false; comboSubVarian.Visible = false;

            }
        }

        private void checktype()
        {
            if (pr.Type == "HOTDOG" || pr.Type == "BURGER" || pr.Type == "OTHER")
            {
                lblVarian.Visible = false; comboVarian.Visible = false;
                lblSubVarian.Visible = false; comboSubVarian.Visible = false;
                lblName.Visible = true; txtName.Visible = true;                
                lblName.Top = lblVarian.Top; txtName.Top = comboVarian.Top;
                lblDesc.Top = lblSubVarian.Top; txtDesc.Top = comboSubVarian.Top; txtDesc.Height = 131;
                comboSize.Items.Clear(); comboSize.Items.Add("ONE SIZE");
                comboExtra.Items.Clear(); comboExtra.Items.Add("N/A");
                
            }
            else
            {
                //lblVarian.Visible = true; comboVarian.Visible = true;
                //lblSubVarian.Visible = true; comboSubVarian.Visible = true;
                //lblName.Visible = false; txtName.Visible = false;                                
                //checkSubVarian();
            }
        }

        private void loading()
        {
            checktype();
            //lblName.Text = pr.Name;
            comboType.Text = pr.Type;
            comboType.Enabled = false;
            
            List<String> vars = emp.loadVarian();
            if (pr.Type == "PIZZA")
            {
                foreach (String item in vars)
                {
                    comboVarian.Items.Add(item);
                    if (item == pr.Varian)
                    {
                        comboVarian.SelectedItem = item;
                    }
                }
                Console.WriteLine(string.IsNullOrEmpty(pr.SubVarian));
                if (string.IsNullOrEmpty(pr.SubVarian) != true)
                {
                    Console.WriteLine(pr.SubVarian);
                    foreach (String item in vars)
                    {
                        comboSubVarian.Items.Add(item);
                        if (item == pr.SubVarian)
                        {
                            comboSubVarian.SelectedItem = item;
                            Console.WriteLine(pr.SubVarian);
                        }
                    }
                }
                else { comboSubVarian.Enabled = false; }
            }
            else { txtName.Text = pr.Name; }

            txtDesc.Text = pr.Description;
            numericUpDownMinPurchase.Text = pr.MinPurchase.ToString();
            txtManPrice.Text = pr.ManPrice.ToString();
            txtSellPrice.Text = pr.SellPrice.ToString();
            comboSize.Text = pr.Size;
            comboExtra.Text = pr.Extra;
            pictureBoxProduct.Image = emp.loadImage(pr);         
        }

        private void UserControlEditProduct_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormDashboard.Instance.showForm("UserControlProductReview", pr);
        }

        private void comboVarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboVarian.SelectedItem == "SPECIAL SOSIS BITES" || comboVarian.SelectedItem == "SPECIAL MOZARELLA BITES")
            {
                comboSubVarian.Enabled = true;
            }
            else
            {
                comboSubVarian.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pr.Description = txtDesc.Text;
            pr.Size = comboSize.Text;
            pr.Extra = comboExtra.Text;
            pr.MinPurchase = Convert.ToInt32(numericUpDownMinPurchase.Value);
            pr.ManPrice = Convert.ToInt32(txtManPrice.Text);
            pr.SellPrice = Convert.ToInt32(txtSellPrice.Text);

            if (pr.Type == "PIZZA")
            {
                pr.Varian = comboVarian.Text;
                pr.Name = pr.Varian + " " + pr.Size + " " + pr.Type + " WITH " + pr.Extra;
                if (comboSubVarian.Enabled == true)
                {
                    pr.SubVarian = comboSubVarian.Text;
                    pr.Name= pr.Varian + " " + pr.SubVarian + " " + pr.Extra;                    
                }                
            }
            else { pr.Name = txtName.Text; }
            emp.updateProduct(pr);


            //attempt for update pic
            emp.UpdateImage(pr, imgLoc);
            //Byte[] data = emp.ConvertImageToBinary(pictureBoxProduct.Image);
            //emp.updateProduct(pr, data);
            MessageBox.Show("update has been done");
            FormDashboard.Instance.showForm("UserControlProductReview", pr);
        }

        private void btnSelectPict_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    lblFileName.Text = filename;
                    //pictureBoxProduct.Image = Image.FromFile(filename);
                    //2nd attempt
                    imgLoc = ofd.FileName.ToString();
                    pictureBoxProduct.ImageLocation = imgLoc;


                }
            }
            //Byte[] data = emp.ConvertImageToBinary(pictureBoxProduct.Image); Console.WriteLine(Encoding.UTF8.GetString(data));
        }

        private void label7_Click(object sender, EventArgs e)
        {
            emp.testingcopyimage(comboVarian.Text);
        }
    }
}
