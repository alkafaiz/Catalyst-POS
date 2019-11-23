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
    public partial class FormProductToCart : Form
    {
        Employee emp = new Employee();
        List<Product> prs;
        
        public FormProductToCart()
        {
            InitializeComponent();
        }

        public FormProductToCart(List<Product> prod)
        {
            InitializeComponent();
            
            prs = prod;
        }

        private void FormProductToCart_Load(object sender, EventArgs e)
        {
            emp.loadProducts(prs, flowLayoutPanelItems);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string IDpr
        {
            get
            {
                return lblID.Text.ToString().Trim(); ;
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (lblName.Text != "Please select product")
            {

                Console.WriteLine("1-- "+lblID.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            else { MessageBox.Show("Please select product."); }
        }
    }
}
