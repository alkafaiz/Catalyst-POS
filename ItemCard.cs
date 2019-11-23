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
    public partial class ItemCard : UserControl
    {
        Product pr;
       // List<Product> prod;




        public ItemCard()
        {
            InitializeComponent();
            
        }
        public ItemCard(Product prod)
        {
            InitializeComponent();
            pr = prod;            
        }
        public ItemCard(Product prodsel, String fx)
        {
            InitializeComponent();
            //prod = products;
            pr = prodsel;
            if (fx == "Pizza-selection")
            {
                txtName.Multiline = true;
                txtName.Height = 42;
                txtName.Location = new Point(0, 94);
                btnSelect.Location = new Point(29, 157);
                txtPrice.Location = new Point(0, 135);

                btnSelect.Visible = false;
                btnSelect2.Visible = true;
                btnSelect2.Location = new Point(29, 149);
            }
        }

        #region Properties

        private String _nameproduct;
        private String _price;
        private Image _pic;
        private bool _isPizza;

        [Category("Custom Props")]
        public String NameProduct
        {
            get { return _nameproduct; }
            set { _nameproduct = value; txtName.Text = value; }
        }

        [Category("Custom Props")]
        public String Price
        {
            get { return _price; }
            set { _price = value; txtPrice.Text = value; }
        }
        [Category("Custom Props")]
        public Image Pic
        {
            get { return _pic; }
            set { if (value != null) { _pic = value; pictureBox1.Image = value; } }
        }
        [Category("Custom Props")]
        public bool IsPizza
        {
            get { return _isPizza; }
            set {
                if (value == true)
                {
                    txtPrice.Visible = false;
                    btnSelect.Top = 136;
                }
            }
        }

        #endregion

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (pr.Type == "PIZZA")
            {
                List<Product> prod = emp.loadProducts();
                List<Product> selectedprod = new List<Product>();
                foreach (Product item in prod)
                {
                    if (item.Type == "PIZZA" && item.Varian == pr.Varian)
                    {
                        selectedprod.Add(item);
                    }
                }
                FormProductToCart form = new FormProductToCart(selectedprod);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    addtocart(form.IDpr);
                    //backup
                    //Console.WriteLine("need to go to cart");
                    //var parent1 = this.ParentForm;
                    //var child1 = parent1.Controls["Panel3"];
                    //FlowLayoutPanel panel = (child1.Controls["flowLayoutPanelCheckoutItems"] as FlowLayoutPanel);
                    //String ID = form.IDpr;
                    //Console.WriteLine("2-- " + form.IDpr);
                    //Console.WriteLine("3-- " + ID);

                    //Product prd = emp.loadProduct(ID);
                    //Console.WriteLine("4-- " + prd.ProductID);

                    //Console.WriteLine("heheheh    "+prd.Name);
                    //emp.addToCart(emp.loadProduct(form.IDpr), panel);
                    //Console.WriteLine(emp.loadProduct(form.IDpr).Name);
                }
             
            }
            else
            {
                addtocart(pr.ProductID);
            }
        }

        private void addtocart(String ID)
        {
            Employee emp = new Employee();
            var parent1 = this.ParentForm;
            var child1 = parent1.Controls["Panel3"];
            FlowLayoutPanel panel = (child1.Controls["flowLayoutPanelCheckoutItems"] as FlowLayoutPanel);                                             
            emp.addToCart(emp.loadProduct(ID), panel);            
        }

        public String productName()
        {
            return pr.Name;
        }

        private void deactivate()
        {
            this.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;
        }
        private void activate()
        {
            var parent1 = this.Parent;
            List<Control> listControls = new List<Control>();
            foreach (Control control in parent1.Controls.OfType<ItemCard>())
            {
                TextBox txb = (control.Controls["txtName"] as TextBox);
                
                //Console.WriteLine(+" is the same with "+);
                if (txb.Text != this.txtName.Text)
                {
                    TextBox tb = (control.Controls["txtName"] as TextBox);
                    tb.BackColor = Color.White;
                    control.Controls["txtPrice"].BackColor = Color.White;
                    control.BackColor = Color.White;
                }
                else
                {
                    TextBox tb = (control.Controls["txtName"] as TextBox);
                    tb.BackColor = Color.LemonChiffon;
                    control.Controls["txtPrice"].BackColor = Color.LemonChiffon;
                    control.BackColor = Color.LemonChiffon;
                }

            }
            


        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent;
            Console.WriteLine(parent1.Parent.Name);
            Label Name = (parent1.Parent.Controls["lblName"] as Label);
            Name.Text = pr.Name;
            parent1.Parent.Controls["lblvarian"].Text = pr.Varian;
            parent1.Parent.Controls["lblsubvarian"].Text = pr.SubVarian;
            parent1.Parent.Controls["lblsize"].Text = pr.Size;
            parent1.Parent.Controls["lblextra"].Text = pr.Extra;
            parent1.Parent.Controls["lblPrice"].Text = pr.SellPrice.ToString();
            parent1.Parent.Controls["lblID"].Text = pr.ProductID.ToString();
            Console.WriteLine("here is  "+ parent1.Parent.Controls["lblID"].Text);
            activate();
        }
    }
}
