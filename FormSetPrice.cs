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
    public partial class FormSetPrice : Form
    {
        List<Product> products = new List<Product>();

        Product product;
        //String Prices = "";
        public FormSetPrice()
        {
            InitializeComponent();
        }

        public FormSetPrice(String Type, String Varian, List<Product> preproduct)
        {            
            InitializeComponent();
            lblType.Text = Type;
            lblVarian.Text = Varian;
            products = preproduct;                       
            //arrangeTab(preproduct);
        }

        public FormSetPrice(Product preproduct)
        {
            InitializeComponent();
            lblType.Text = preproduct.Type;
            lblVarian.Text = preproduct.Varian;
            lblName.Text = preproduct.Name;
            lblIDProduct.Text = preproduct.ProductID;
            product = preproduct;
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //command to 2nd phase, this is 1st attempt
            //int number = products.Count;
            //if (number == 1)
            //{
            //    products[0].ManPrice = Convert.ToInt32(txtManPrice1.Text);
            //    products[0].SellPrice = Convert.ToInt32(txtSellPrice1.Text);                
            //}
            //if (number == 2)
            //{
            //    products[0].ManPrice = Convert.ToInt32(txtManPrice1.Text);
            //    products[0].SellPrice = Convert.ToInt32(txtSellPrice1.Text);
            //    products[1].ManPrice = Convert.ToInt32(txtManPrice2.Text);
            //    products[1].SellPrice = Convert.ToInt32(txtSellPrice2.Text);      
            //}
            //if (number == 4)
            //{
            //    products[0].ManPrice = Convert.ToInt32(txtManPrice1.Text);
            //    products[0].SellPrice = Convert.ToInt32(txtSellPrice1.Text);
            //    products[1].ManPrice = Convert.ToInt32(txtManPrice2.Text);
            //    products[1].SellPrice = Convert.ToInt32(txtSellPrice2.Text);
            //    products[2].ManPrice = Convert.ToInt32(txtManPrice3.Text);
            //    products[2].SellPrice = Convert.ToInt32(txtSellPrice3.Text);
            //    products[3].ManPrice = Convert.ToInt32(txtManPrice4.Text);
            //    products[3].SellPrice = Convert.ToInt32(txtSellPrice4.Text);                
            //}
            product.ManPrice = Convert.ToInt32(txtManPrice.Text);
            product.SellPrice = Convert.ToInt32(txtSellPrice.Text);

            using(var fr = new FormReviewNewProduct(product))
            {
                var result = fr.ShowDialog();
                if (result == DialogResult.OK)
                {                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        //public string GetPrice
        //{
        //    get
        //    {
        //        return Prices;
        //    }
        //}
        public List<Product> GetPoducts
        {
            get
            {
                return products;
            }
        }
    }
}
