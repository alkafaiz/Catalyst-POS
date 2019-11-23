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
    public partial class UserControlProducts : UserControl
    {
        //Employee emplo = new Employee();
        List<Product> items;
        public UserControlProducts()
        {
            InitializeComponent();
            //items = emplo.loadProducts(); 
            //populateProducts();
        }
        public UserControlProducts(List<Product> item)
        {
            InitializeComponent();
            //items = emplo.loadProducts();
            items = item;
            //populateProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //using(FormDashboard f = new FormDashboard())
            //{
            //    f.showForm("UserControlNewProduct");
            //    this.Hide();
            //}
            if (!FormDashboard.Instance.PanelContent.Controls.ContainsKey("UserControlNewProduct"))
            {
                UserControlNewProduct prod = new UserControlNewProduct();
                prod.Dock = DockStyle.Fill;
                FormDashboard.Instance.PanelContent.Controls.Add(prod);
            }
            FormDashboard.Instance.PanelContent.Controls["UserControlNewProduct"].BringToFront();
        }

        private void populateProducts() //edit for sorting 
        {
            Employee emp = new Employee();
            int n = emp.countrowProduct();
            //Console.WriteLine(n.ToString());
            if (n == 0)
            {
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Visible = false;
                //List<Product> items = emp.loadProducts();
                for (int i = 0; i < n; i++)
                {
                    ProductItem item = new ProductItem();
                    item.NameProduct = items[i].Name;
                    //Console.WriteLine(item.NameProduct);
                    item.Price = items[i].SellPrice.ToString();
                    item.ID = items[i].ProductID.ToString();
                    //command for trial
                    if (items[i].Picture != null) { item.Product = items[i].Picture; }
                    
                    if (items[i].InStock == true)
                    {
                        item.InStock = true;
                    }
                    else { item.InStock = false; }
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        private void populateProducts(String Sorting) 
        {
            //clear the controls
            List<Control> listControls = new List<Control>();
            foreach (Control control in flowLayoutPanel1.Controls.OfType<ProductItem>())
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            Employee emp = new Employee();            
                                 
            //create sorted type list
            List<Product> prods = new List<Product>();
            if (Sorting == "All")
            {
                for (int a = 0; a < items.Count; a++)
                {
                    prods.Add(items[a]);                    
                }
            }
            if (Sorting == "Pizza")
            {                
                for (int a = 0; a < items.Count; a++)
                {
                    if (items[a].Type == "PIZZA")
                    {
                        prods.Add(items[a]);
                    }
                }
            }
            if (Sorting == "Burger")
            {
                for (int a = 0; a < items.Count; a++)
                {
                    if (items[a].Type == "BURGER")
                    {
                        prods.Add(items[a]);
                    }
                }
                //Console.WriteLine("tessst: "+prods.Count);
            }
            if (Sorting == "Others")
            {
                for (int a = 0; a < items.Count; a++)
                {
                    if (items[a].Type == "OTHER" || items[a].Type == "HOTDOG")
                    {
                        prods.Add(items[a]);
                    }
                }                
            }

            
            //Console.WriteLine("List number other: " + prods.Count);
            //populate products
            if (prods.Count == 0) { lblMessage.Visible = true; }
            else
            {
                lblMessage.Visible = false;
                for (int i = 0; i < prods.Count; i++)
                {
                    ProductItem item = new ProductItem();
                    item.NameProduct = prods[i].Name;
                    //Console.WriteLine(item.NameProduct);
                    item.Price = prods[i].SellPrice.ToString();
                    item.ID = prods[i].ProductID.ToString();
                    //command for trial
                    //item.Product = emp.loadImage(prods[i]);                  
                    item.Product = prods[i].Picture;

                    if (prods[i].InStock == true)
                    {                        
                        item.InStock = true;
                    }
                    else { item.InStock = false; }
                    flowLayoutPanel1.Controls.Add(item);
                }
            }

        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {
            populateProducts("All");
            //Employee emp = new Employee();
            //pictureBox1.Image = emp.getimage();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.WhiteSmoke;
            btnAll.BackColor = Color.LightGray;
            btnBurger.BackColor = Color.WhiteSmoke;
            btnOther.BackColor = Color.WhiteSmoke;
            populateProducts("All");
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnAll.BackColor = Color.WhiteSmoke;
            btnBurger.BackColor = Color.WhiteSmoke;
            btnOther.BackColor = Color.WhiteSmoke;
            populateProducts("Pizza");
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.WhiteSmoke;
            btnAll.BackColor = Color.WhiteSmoke;
            btnBurger.BackColor = Color.LightGray; ;
            btnOther.BackColor = Color.WhiteSmoke;
            populateProducts("Burger");
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.WhiteSmoke;
            btnAll.BackColor = Color.WhiteSmoke;
            btnBurger.BackColor = Color.WhiteSmoke; ;
            btnOther.BackColor = Color.LightGray;
            populateProducts("Others");
        }
    }
}
