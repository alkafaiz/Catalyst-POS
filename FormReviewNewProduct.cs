using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS
{
    public partial class FormReviewNewProduct : Form
    {
        List<Product> product = new List<Product>();
        Product pr;
        public FormReviewNewProduct()
        {
            InitializeComponent();
        }

        public FormReviewNewProduct(Product preproduct)
        {
            InitializeComponent();
            pr = preproduct;
            lblID.Text = pr.ProductID;
            lblName.Text = pr.Name;
            lblType.Text = pr.Type;
            lblVarian.Text = pr.Varian;
            lblDesc.Text = pr.Description;
            lblMinPurchase.Text = pr.MinPurchase.ToString();
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblSize.Text = pr.Size;
            lblExtra.Text = pr.Extra;
            lblManPrice.Text = pr.ManPrice.ToString();
            lblSellPrice.Text = pr.SellPrice.ToString();
            pictureBoxProduct.Image = pr.Picture;
        }

        //public FormReviewNewProduct(List<Product> products)
        //{
        //    InitializeComponent();
        //    lblType.Text = products[0].Type;
        //    lblVarian.Text = products[0].Varian;
        //    lblDesc.Text = products[0].Description;
        //    lblMinPurchase.Text = products[0].MinPurchase.ToString();
        //    lblDate.Text = "16/3/19";
        //    product = products;
        //    int n = products.Count;
        //    if (n == 1)
        //    {
        //        lblsize1.Text = products[0].Size;
        //        lblExtra1.Text = products[0].Extra;
        //        lblPrice1.Text = products[0].SellPrice.ToString();
        //        groupBox1.Width = 438;
        //    }
        //    if (n == 2)
        //    {
        //        lblsize1.Text = products[0].Size;
        //        lblExtra1.Text = products[0].Extra;
        //        lblPrice1.Text = products[0].SellPrice.ToString();
        //        groupBox2.Visible = true;
        //        lblsize2.Text = products[1].Size;
        //        lblExtra2.Text = products[1].Extra;
        //        lblPrice2.Text = products[1].SellPrice.ToString();
        //    }
        //    if (n == 4)
        //    {
        //        lblsize1.Text = products[0].Size;
        //        lblExtra1.Text = products[0].Extra;
        //        lblPrice1.Text = products[0].SellPrice.ToString();
        //        groupBox2.Visible = true;
        //        lblsize2.Text = products[1].Size;
        //        lblExtra2.Text = products[1].Extra;
        //        lblPrice2.Text = products[1].SellPrice.ToString();
        //        groupBox3.Visible = true;
        //        lblsize3.Text = products[2].Size;
        //        lblExtra3.Text = products[2].Extra;
        //        lblPrice3.Text = products[2].SellPrice.ToString();
        //        groupBox4.Visible = true;
        //        lblsize4.Text = products[3].Size;
        //        lblExtra4.Text = products[3].Extra;
        //        lblPrice4.Text = products[3].SellPrice.ToString();
        //    }
        //    pictureBoxProduct.Image = products[0].Picture;
        //}

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.addProduct(pr);
            MessageBox.Show("Products created successfully! Please activate in-stock in product menu");
            this.DialogResult = DialogResult.OK;
            this.Close(); //fix inserting product to database (from list to class)
        }

        private void FormReviewNewProduct_Load(object sender, EventArgs e)
        {
            if (pr.Type == "PIZZA" && pr.SubVarian == "")
            {
                lblSubvarian.Visible = true;
                lblsepSubvarian.Visible = true;
                lblfieldSubvarian.Visible = true;
                lblSubvarian.Text = pr.SubVarian;
            }
            //if (pr.Type == "PIZZA" && lblSubVarian.Visible == true)
            //{
            //    pr.SubVarian = comboSubVarian.Text;
            //    name += pr.Varian + " " + pr.SubVarian + " " + pr.Extra;
            //}
            //if (pr.Type == "OTHER")
            //{
            //    name += txtName.Text;
            //}
        }
    }
}
