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
    public partial class ItemCart : UserControl
    {
        private Product product;
        

        public Product Productgetset
        {
            get { return product; }
            set { product = value; }
        }

        public ItemCart()
        {
            InitializeComponent();
        }
        
        public ItemCart(Product pr)
        {
            InitializeComponent();
            product = pr;
            
        }

        public ItemCart(Product pr, String cmd)
        {
            InitializeComponent();
            product = pr;
            if (cmd == "review")
            {
                btnAdd.Visible = false;
                btnMinus.Visible = false;
                btnDelete.Visible = false;
            }

        }

        #region Properties

        private String _nameproduct;
        private int _qty;
        private int? _price;

        [Category("Custom Props")]
        public String NameProduct
        {
            get { return _nameproduct; }
            set { _nameproduct = value; txtName.Text = value; }
        }
        [Category("Custom Props")]
        public int Qty
        {
            get { return _qty; }
            set { _qty = value; lblQty.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int? Price
        {
            get { return _price; }
            set { _price = value; txtPrice.Text = value.ToString(); }
        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ItemCart_Load(object sender, EventArgs e)
        {
            if (product.Type != "PIZZA")
            {
                txtName.Multiline = false;
                txtName.Location = new Point(34, 11);
            }
            _qty = Convert.ToInt32(lblQty.Text.ToString());
        }
        public Delegate userFunctionPointer;
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lblQty.Text.ToString());
            n += 1;
            _qty = n;
            lblQty.Text = n.ToString();
            int a = n * Convert.ToInt32(product.SellPrice);
            Price = a;
            txtPrice.Text = a.ToString();
            recalculateSubttl();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lblQty.Text.ToString());
            
            if (n != 0)
            {
                n -= 1;
                _qty = n;
                lblQty.Text = n.ToString();
                int a = n * Convert.ToInt32(product.SellPrice);
                txtPrice.Text = a.ToString();
                Price = a;
                recalculateSubttl();
            }

        }

        private void recalculateSubttl()
        {

            Console.WriteLine(this.ParentForm);
            Form form = this.FindForm();
            //userFunctionPointer.DynamicInvoke();
            Employee emp = new Employee();
            var parent1 = this.Parent;
            var parent2 = parent1.Parent;
            FlowLayoutPanel panel = (parent2.Controls["flowLayoutPanelCheckoutItems"] as FlowLayoutPanel);
            var child1 = parent2.Controls["panelCounting"];
            TextBox subt = (child1.Controls["txtSubTotal"] as TextBox);
            TextBox disc = (child1.Controls["txtDisc"] as TextBox);
            TextBox fee = (child1.Controls["txtDelivfee"] as TextBox);
            TextBox tot = (parent2.Controls["txtTotal"] as TextBox);

            emp.calculateSubTotal(panel, subt, tot,disc,fee);

        }

        public SalesTransaction SalesTransaction
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
