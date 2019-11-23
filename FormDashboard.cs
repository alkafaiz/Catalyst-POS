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
    public partial class FormDashboard : Form
    {
        static FormDashboard _obj;
        Employee emp;
        List<Product> Allproducts;
        public static FormDashboard Instance
        {
            get{
                if (_obj == null){
                    _obj = new FormDashboard();
                }
                return _obj;
            }
        }

        public Panel PanelContent
        {
            get { return panelContent; }
            set { panelContent = value; }
        }


        public FormDashboard()
        {
            InitializeComponent();
            sidePanel.Height = btnDashbrd.Height;
            sidePanel.Top = btnDashbrd.Top;
            showForm("UserControlDashboard");
        }

        public FormDashboard(Employee em)
        {
            InitializeComponent();
            sidePanel.Height = btnDashbrd.Height;
            sidePanel.Top = btnDashbrd.Top;
            showForm("UserControlDashboard");
            emp = em;
            txtName.Text = emp.FirstName + " " + emp.LastName;
            txtRole.Text = emp.Role;
            Allproducts = emp.loadProducts();
        }

        public void btnactivate(Button button)
        {
            //string[] btn = new string[5] { "btnDashbrd", "btnOrders", "btnReports", "btnCustomers", "btnProducts" };
            Button[] btn = new Button[5] { btnDashbrd, btnOrders, btnReports, btnCustomers, btnProducts };
            for (int i = 0; i < btn.Count(); i++)
            {
                if (button.Name == btn[i].Name)
                {
                    button.ForeColor = Color.FromArgb(255, 230, 109);
                }
                else { btn[i].ForeColor = Color.White; }
            }
        }

        private void btnDashbrd_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnDashbrd.Height;
            sidePanel.Top = btnDashbrd.Top;
            lblTitle.Text = "DASHBOARD";
            btnactivate(btnDashbrd);
            showForm("UserControlDashboard");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOrders.Height;
            sidePanel.Top = btnOrders.Top;
            lblTitle.Text = "ORDERS";
            btnactivate(btnOrders);
            showForm("UserControlOrder");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnReports.Height;
            sidePanel.Top = btnReports.Top;
            lblTitle.Text = "REPORTS";
            btnactivate(btnReports);
            showForm("UserControlReport");
            //userControlNewProduct1.BringToFront();
            //userControlNewProduct1.Visible = true;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnCustomers.Height;
            sidePanel.Top = btnCustomers.Top;
            lblTitle.Text = "CUSTOMERS";
            btnactivate(btnCustomers);
            showForm("UserControlCustomer");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnProducts.Height;
            sidePanel.Top = btnProducts.Top;
            lblTitle.Text = "PRODUCTS";
            btnactivate(btnProducts);
            //userControlProducts1.BringToFront();
            //userControlProducts1.Visible = true;
            //btnProducts.ForeColor = Color.FromArgb(255, 230, 109);
            if (!PanelContent.Controls.ContainsKey("userControlProducts"))
            {
                UserControlProducts prod = new UserControlProducts(Allproducts);
                prod.Dock = DockStyle.Fill;
                PanelContent.Controls.Add(prod);
            }
            PanelContent.Controls["userControlProducts"].BringToFront();
        }

        //function for show usercontrol
        public void showForm(String name){
            if (name == "UserControlProducts"){
                if (!PanelContent.Controls.ContainsKey(name)){
                    UserControlProducts prod = new UserControlProducts(Allproducts);
                    prod.Dock = DockStyle.Fill;
                    PanelContent.Controls.Add(prod);
                }
                PanelContent.Controls[name].BringToFront();
            }
            if(name == "UserControlCustomer"){
                foreach (Control item in FormDashboard.Instance.panelContent.Controls.OfType<UserControlCustomer>()){
                    FormDashboard.Instance.panelContent.Controls.Remove(item);
                }
                if (!PanelContent.Controls.ContainsKey(name)){
                    UserControlCustomer prod = new UserControlCustomer();
                    prod.Dock = DockStyle.Fill;
                    PanelContent.Controls.Add(prod);
                }
                PanelContent.Controls[name].BringToFront();}
            if (name == "UserControlCreateCustomer"){
                if (!PanelContent.Controls.ContainsKey(name)){
                    UserControlCreateCustomer prod = new UserControlCreateCustomer();
                    prod.Dock = DockStyle.Fill;
                    PanelContent.Controls.Add(prod);
                }
                PanelContent.Controls[name].BringToFront();
            }
            if (name == "UserControlOrder"){
                if (!PanelContent.Controls.ContainsKey(name)){
                    UserControlOrder prod = new UserControlOrder(Allproducts);
                    prod.Dock = DockStyle.Fill;
                    PanelContent.Controls.Add(prod);
                }
                PanelContent.Controls[name].BringToFront();
            }
            if (name == "UserControlDashboard"){
                if (!PanelContent.Controls.ContainsKey(name)){
                    UserControlDashboard prod = new UserControlDashboard();
                    prod.Dock = DockStyle.Fill;
                    PanelContent.Controls.Add(prod);
                }
                PanelContent.Controls[name].BringToFront();
            }
            if (name == "UserControlReport"){
                if (!PanelContent.Controls.ContainsKey(name)){
                    UserControlReport prod = new UserControlReport();
                    prod.Dock = DockStyle.Fill;
                    PanelContent.Controls.Add(prod);
                }
                PanelContent.Controls[name].BringToFront();
            }
        }

        public void showForm(String formname, Product pr)
        {   
            if(formname == "UserControlProductReview")
            {
                foreach (Control item in FormDashboard.Instance.panelContent.Controls.OfType<UserControlProductReview>())
                {
                    FormDashboard.Instance.panelContent.Controls.Remove(item);
                }
                UserControlProductReview proda = new UserControlProductReview(pr);
                proda.Dock = DockStyle.Fill;
                FormDashboard.Instance.PanelContent.Controls.Add(proda);
                FormDashboard.Instance.PanelContent.Controls["UserControlProductReview"].BringToFront();
            }
            if (formname == "UserControlEditProduct")
            {
                foreach (Control item in FormDashboard.Instance.panelContent.Controls.OfType<UserControlEditProduct>())
                {
                    FormDashboard.Instance.panelContent.Controls.Remove(item);
                }
                UserControlEditProduct proda = new UserControlEditProduct(pr);
                proda.Dock = DockStyle.Fill;
                FormDashboard.Instance.PanelContent.Controls.Add(proda);
                FormDashboard.Instance.PanelContent.Controls["UserControlEditProduct"].BringToFront();
                
            }

        }

        public void showProductRefresh()
        {
            foreach (Control item in FormDashboard.Instance.panelContent.Controls.OfType<UserControlProducts>())
            {
                FormDashboard.Instance.panelContent.Controls.Remove(item);
            }
            UserControlProducts proda = new UserControlProducts(Allproducts);
            proda.Dock = DockStyle.Fill;
            FormDashboard.Instance.PanelContent.Controls.Add(proda);
            FormDashboard.Instance.PanelContent.Controls["UserControlProducts"].BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {           
            using (var form = new FormExitConfirmation())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    FormLogin form1 = new FormLogin();
                    form1.Show();
                    this.Close();
                }
            }
     
        }

        private void checkRole()
        {
            if (emp.Role == "CASHIER")
            {
                sidePanel.Height = btnOrders.Height;
                sidePanel.Top = btnOrders.Top;
                lblTitle.Text = "ORDERS";
                btnactivate(btnOrders);
                showForm("UserControlOrder");
                btnDashbrd.Enabled = false;
                btnCustomers.Enabled = false;
                btnReports.Enabled = false;
                btnProducts.Enabled = false;
                linkManageUser.Visible = false;
            }
            if (emp.Role == "MANAGER")
            {
                linkManageUser.Visible = false;
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            _obj = this;
            checkRole();
            //UserControlProducts prod = new UserControlProducts();
            //prod.Dock = DockStyle.Fill;
            //FormDashboard.Instance.PanelContent.Controls.Add(prod);
        }

        private void linkManageUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
        }
    }
}
