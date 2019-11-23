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
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
        }

        #region Properties

        private String _nameproduct;
        private String _price;
        private String _productID;
        private Image _product;
        private bool _InStock;

        [Category("Custom Props")]
        public String NameProduct
        {
            get { return _nameproduct; }
            set { _nameproduct = value; lblName.Text = value; }
        }

        [Category("Custom Props")]
        public String Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }

        [Category("Custom Props")]
        public String ID
        {
            get { return _productID; }
            set { _productID = value; txtID.Text = value; }
        }

        [Category("Custom Props")]
        public Image Product
        {
            get { return _product; }
            set { if (value != null) { _product = value; picboxProduct.Image = value; } }
        }

        [Category("Custom Props")]
        public bool InStock
        {
            get { return _InStock; }
            set {
                _InStock = value;
                if (value == true) { toglStock.Checked = true; lblStock.ForeColor = Color.FromName("HotTrack"); }
                else { toglStock.Checked = false; lblStock.ForeColor = Color.Black; }
            }
        }
        #endregion

        private void toglStock_CheckedChanged(object sender, EventArgs e)
        {            
            Employee emp = new Employee();
            Product pr = emp.loadProduct(txtID.Text);
            if (toglStock.Checked == true)
            {
                lblStock.ForeColor = Color.FromName("HotTrack");
                pr.InStock = true;
                
            }
            else
            {
                lblStock.ForeColor = Color.Black;
                pr.InStock = false;
                
            }
            emp.activateProduct(pr);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {            
            using (FormDashboard form = new FormDashboard())
            {
                Employee emp = new Employee();
                Product pr = emp.loadProduct(txtID.Text);                
                form.showForm("UserControlProductReview", pr);                
            }
        }

        private void toglStock_Click(object sender, EventArgs e)
        {
            if (toglStock.Checked == true) { MessageBox.Show("This product has been activated!"); }
            else { MessageBox.Show("This product has been deactivated!"); }
        }
    }
}
