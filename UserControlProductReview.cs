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
    public partial class UserControlProductReview : UserControl
    {
        Product pr;
        public UserControlProductReview()
        {
            InitializeComponent();
        }
        public UserControlProductReview(Product product)
        {
            pr = product;
            InitializeComponent();
        }

        private void UserControlProductReview_Load(object sender, EventArgs e)
        {
            lblID.Text = pr.ProductID;
            lblName.Text = pr.Name;
            lblType.Text = pr.Type;
            lblvarian.Text = pr.Varian;
            lblsubvarian.Text = pr.SubVarian;
            txtDesc.Text = pr.Description;
            lblminPurchase.Text = pr.MinPurchase.ToString();
            lblPrice.Text = "Man. Price: "+pr.ManPrice.ToString() + ", Sell Price: " + pr.SellPrice.ToString();
            lblsize.Text = pr.Size;
            lblextra.Text = pr.Extra;
            lblDataCreated.Text = pr.DateCreated;
            lblTotalsold.Text = "0";
            Employee emp = new Employee();

            pictureBoxProduct.Image = emp.loadImage(pr);
            //pictureBoxProduct.Image = pr.Picture;
            if (pr.InStock.ToString() == "True")
            {                
                toglStock.Checked = true;
            }
            else { toglStock.Checked = false; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormDashboard.Instance.showForm("UserControlProducts");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormDashboard.Instance.showForm("UserControlEditProduct", pr);
        }

        private void toglStock_CheckedChanged(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (toglStock.Checked == true)
            {
                pr.InStock = true;                
            }
            else {
                pr.InStock = false;                
            }
            emp.activateProduct(pr);
        }

        private void toglStock_Click(object sender, EventArgs e)
        {
            if (toglStock.Checked == true) { MessageBox.Show("This product has been activated!"); }
            else { MessageBox.Show("This product has been deactivated!"); }
        }
    }
}
