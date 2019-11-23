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
    public partial class FormPOSinterface : Form
    {
        Employee emp = new Employee();
        Customer currentCust;
        Address selectedAdd;
        List<Product> items;
        //static FormDashboard _obj;

        //public static FormDashboard Instance
        //{
        //    get
        //    {
        //        if (_obj == null)
        //        {
        //            _obj = new FormDashboard();
        //        }
        //        return _obj;
        //    }
        //}



        public FormPOSinterface()
        {
            InitializeComponent();
            formFunctionPointer += new functioncall(calculateSubTotal);
            ItemCart n = new ItemCart();
            n.userFunctionPointer = formFunctionPointer;
            //items = emp.loadProducts();
        }
        public FormPOSinterface(List<Product> item)
        {
            InitializeComponent();
            formFunctionPointer += new functioncall(calculateSubTotal);
            ItemCart n = new ItemCart();
            n.userFunctionPointer = formFunctionPointer;
            items = item;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateProducts(String Sorting)
        {
            //clear the controls
            List<Control> listControls = new List<Control>();
            foreach (Control control in flowLayoutPanelItems.Controls.OfType<ItemCard>()){listControls.Add(control);}
            foreach (Control control in listControls)
            {flowLayoutPanelItems.Controls.Remove(control);control.Dispose();}            
            List<String> varians = emp.loadVarian("PIZZA");            
            //create sorted type list
            List<Product> prods = new List<Product>();            
            if (Sorting == "Pizza"){
                for (int a = 0; a < items.Count; a++){
                    if (items[a].Type == "PIZZA"){
                        prods.Add(items[a]);
                    }
                }
            }
            if (Sorting == "Burger"){
                for (int a = 0; a < items.Count; a++){
                    if (items[a].Type == "BURGER"){
                        prods.Add(items[a]);
                    }
                }
                btnFav.Visible = false;
                btnManageAdd.Visible = false;
                txtSearch.Text = "";              
            }
            if (Sorting == "Other"){
                for (int a = 0; a < items.Count; a++){
                    if (items[a].Type == "OTHER"){
                        prods.Add(items[a]);
                    }
                    if (items[a].Type == "HOTDOG"){
                        prods.Add(items[a]);                        
                    }
                }
            }            
            //populate products
            if (prods.Count == 0) { Console.WriteLine("No product"); }
            else{                
                for (int i = 0; i < prods.Count; i++){                    
                    if (prods[i].InStock == true){
                        if(prods[i].Type == "PIZZA"){
                            txtPanelProductTitle.Text = "PIZZA";
                            for (int x = 0; x < varians.Count; x++){                               
                                Product pr = new Product();pr.Varian = varians[x].ToString();pr.Type = "PIZZA";
                                ItemCard item = new ItemCard(pr);
                                item.NameProduct = varians[x].ToString() + " PIZZA";
                                item.Parent = this;
                                for (int a = 0; a < prods.Count; a++){
                                    if (prods[a].Varian == varians[x]){
                                        item.Pic = emp.loadImage(prods[a]);break;
                                    }
                                }
                                item.IsPizza = true;
                                flowLayoutPanelItems.Controls.Add(item);
                            }                            
                            break;
                        }    
                        else{
                            txtPanelProductTitle.Text = prods[0].Type;
                            ItemCard item = new ItemCard(prods[i]);
                            item.NameProduct = prods[i].Name;
                            item.Price = "Rp." + prods[i].SellPrice.ToString();
                            item.Pic = prods[i].Picture;
                            flowLayoutPanelItems.Controls.Add(item);                            
                        }
                    }                                                            
                }
            }
        }


        //backup
        //private void populateProducts(String Sorting)
        //{
        //    //clear the controls
        //    List<Control> listControls = new List<Control>();
        //    foreach (Control control in flowLayoutPanelItems.Controls.OfType<ItemCard>())
        //    {
        //        listControls.Add(control);
        //    }

        //    foreach (Control control in listControls)
        //    {
        //        flowLayoutPanelItems.Controls.Remove(control);
        //        control.Dispose();
        //    }
        //    List<String> varians = emp.loadVarian("PIZZA");
        //    //create sorted type list
        //    List<Product> prods = new List<Product>();
        //    if (Sorting == "Pizza")
        //    {
        //        for (int a = 0; a < items.Count; a++)
        //        {
        //            if (items[a].Type == "PIZZA")
        //            {
        //                prods.Add(items[a]);
        //            }
        //        }
        //    }
        //    if (Sorting == "Burger")
        //    {
        //        for (int a = 0; a < items.Count; a++)
        //        {
        //            if (items[a].Type == "BURGER")
        //            {
        //                prods.Add(items[a]);
        //            }
        //        }
        //        btnFav.Visible = false;
        //        btnManageAdd.Visible = false;
        //        txtSearch.Text = "";
        //    }
        //    if (Sorting == "Other")
        //    {
        //        for (int a = 0; a < items.Count; a++)
        //        {
        //            if (items[a].Type == "OTHER")
        //            {
        //                prods.Add(items[a]);
        //            }
        //            if (items[a].Type == "HOTDOG")
        //            {
        //                prods.Add(items[a]);
        //            }
        //        }
        //    }
        //    //populate products
        //    if (prods.Count == 0) { Console.WriteLine("No product"); }
        //    else
        //    {
        //        for (int i = 0; i < prods.Count; i++)
        //        {
        //            if (prods[i].InStock == true)
        //            {

        //                if (prods[i].Type == "PIZZA")
        //                {
        //                    txtPanelProductTitle.Text = "PIZZA";
        //                    for (int x = 0; x < varians.Count; x++)
        //                    {
        //                        //Console.WriteLine(varians.Count);
        //                        Product pr = new Product(); pr.Varian = varians[x].ToString(); pr.Type = "PIZZA";
        //                        ItemCard item = new ItemCard(pr);
        //                        item.NameProduct = varians[x].ToString() + " PIZZA";
        //                        item.Parent = this;
        //                        for (int a = 0; a < prods.Count; a++)
        //                        {
        //                            if (prods[a].Varian == varians[x])
        //                            {
        //                                item.Pic = emp.loadImage(prods[a]); break;
        //                            }
        //                        }
        //                        item.IsPizza = true;
        //                        flowLayoutPanelItems.Controls.Add(item);
        //                    }
        //                    break;
        //                }
        //                else
        //                {
        //                    txtPanelProductTitle.Text = prods[0].Type;
        //                    ItemCard item = new ItemCard(prods[i]);
        //                    item.NameProduct = prods[i].Name;
        //                    item.Price = "Rp." + prods[i].SellPrice.ToString();
        //                    item.Pic = prods[i].Picture;
        //                    flowLayoutPanelItems.Controls.Add(item);

        //                }
        //            }
        //        }
        //    }

        //}

        private void buttonActive(Button btn)
        {
            if(btn.Name == "btnPizza")
            {
                btnPizza.BackColor = Color.FromArgb(255, 230, 109);
                btnBurger.BackColor = Color.White;
                btnOther.BackColor = Color.White;
                btnFav.BackColor = Color.White;
            }
            if (btn.Name == "btnBurger")
            {
                btnPizza.BackColor = Color.White;
                btnBurger.BackColor = Color.FromArgb(255, 230, 109);
                btnOther.BackColor = Color.White;
                btnFav.BackColor = Color.White;
            }
            if (btn.Name == "btnOther")
            {
                btnPizza.BackColor = Color.White;
                btnBurger.BackColor = Color.White;
                btnOther.BackColor = Color.FromArgb(255, 230, 109);
                btnFav.BackColor = Color.White;
            }
            if (btn.Name == "btnFav")
            {
                btnPizza.BackColor = Color.White;
                btnBurger.BackColor = Color.White;
                btnOther.BackColor = Color.White;
                btnFav.BackColor = Color.FromArgb(255, 230, 109);
            }
        }

        private void FormPOSinterface_Load(object sender, EventArgs e)
        {
            buttonActive(btnPizza);
            populateProducts("Pizza");
            comboType.SelectedIndex = 2;
            comboCustomer.SelectedIndex = 0;
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            buttonActive(btnPizza);
            populateProducts("Pizza");
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            buttonActive(btnBurger);
            populateProducts("Burger");
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            buttonActive(btnOther);
            populateProducts("Other");
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            buttonActive(btnFav);
            //populateProducts("Fav");
            FormOrderConfirmation m = new FormOrderConfirmation();
            m.ShowDialog();
        }

        private event functioncall formFunctionPointer;
        public delegate void functioncall();
        public void calculateSubTotal()
        {
            int n = 0;
            //List<Control> listControls = new List<Control>();
            foreach (ItemCart control in flowLayoutPanelCheckoutItems.Controls.OfType<ItemCart>())
            {
                //listControls.Add(control);
                n += Convert.ToInt32(control.Price);
            }
            txtSubTotal.Text = n.ToString();
            int dis = Convert.ToInt32(txtDisc.Text);
            int fee = Convert.ToInt32(txtDelivfee.Text);
            n += fee;
            n -= dis;
            
            txtTotal.Text = n.ToString();
            //return n;   
                      

        }
        
        private void flowLayoutPanelCheckoutItems_ControlAdded(object sender, ControlEventArgs e)
        {
            calculateSubTotal();            

        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedIndex == 2)
            {
                panel6.Height = 105;
                lblAddress.Visible = true;
                comboAddress.Visible = true;
                btnManageAdd.Visible = true;
                lblDelivFee.Visible = true;
                txtDelivfee.Visible = true;
                panelCounting.Height = 96;
                //panel3.Location = new Point(733, 188);
                panel3.Top = 188;
                //panel3.Anchor = AnchorStyles.Top;
                //panel3.Anchor = AnchorStyles.Right;
                panel3.Height = 482;
                //label6.Location = new Point(13, 450);
                label6.Top = 450;
                //txtTotal.Location = new Point(212, 449);
                txtTotal.Top = 449;
                //btnConfirm.Location = new Point(733, 677);
                btnConfirm.Top = 677;
            }
            else
            {
                panel6.Height = 79;
                lblAddress.Visible = false;
                comboAddress.Visible = false;
                btnManageAdd.Visible = false;
                lblDelivFee.Visible = false;
                txtDelivfee.Visible = false;
                panelCounting.Height = 71;
                panel3.Top = 163;
                panel3.Height = 463;
                label6.Top = 428;
                txtTotal.Top = 427;
                btnConfirm.Top = 632;
            }
        }

        private void flowLayoutPanelCheckoutItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            calculateSubTotal();
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedIndex == 1)
            {
                FormEnterCustomer form = new FormEnterCustomer();
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    //continue here after retriefing customer
                    currentCust = form.cust;
                    lblCustName.Text = currentCust.FirstName + " " + currentCust.LastName;
                    lblCustName.Visible = true;
                    comboCustomer.Visible = false;
                    List<Address> addresses = emp.loadAddress(currentCust);                    
                    for (int i = 0; i < addresses.Count; i++)
                    {
                        comboAddress.Items.Add(addresses[i].Label);
                        if (i == 0) { selectedAdd = addresses[i]; }
                    }
                    comboAddress.SelectedIndex = 0;                    
                }
            }
        }

        private void lblAddFee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddDelivFee form = new FormAddDelivFee();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                txtDelivfee.Text = form.fee.ToString();
            }
            calculateSubTotal();
        }

        private Delivery createDelivery()
        {
            Delivery del = new Delivery();
            Guid ID = Guid.NewGuid();
            del.DelivID = ID.ToString();
            del.Fee = Convert.ToInt32(txtDelivfee.Text);            
            del.AddID = selectedAdd.AddID;
            return del;            
        }

        private void salesPrecreation()
        {
            if (comboCustomer.SelectedItem.ToString() == "Not Registered"){
                MessageBox.Show("Enter Customer");
            }
            else{
                SalesTransaction Sales = new SalesTransaction();
                Guid ID = Guid.NewGuid();
                Sales.SalesTrID = ID.ToString();
                if (comboType.SelectedItem.ToString() == "Delivery"){
                    Sales.Delivery = createDelivery();}
                Sales.Type = comboType.SelectedItem.ToString();
                Sales.DiscCode = "NON";
                Sales.Products = emp.loadCartProduct(flowLayoutPanelCheckoutItems);
                Sales.TotalPrice = Convert.ToInt32(txtTotal.Text);
                Sales.ManPrice = emp.calculateManTotal(Sales.Products);
                Sales.Customer = currentCust;
                foreach (Product i in Sales.Products){
                    Console.WriteLine(i.Name + " " + i.Qty);}
                FormOrderConfirmation form = new FormOrderConfirmation(Sales, dateTimePicker1.Value);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK){
                    clear();}
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            salesPrecreation();
            //if (comboCustomer.SelectedItem.ToString()=="Not Registered")
            //{
            //    MessageBox.Show("Enter Customer");
            //}
            //else
            //{
            //    SalesTransaction Sales = new SalesTransaction();
            //    Guid ID = Guid.NewGuid();
            //    Sales.SalesTrID = ID.ToString();
            //    if (comboType.SelectedItem.ToString() == "Delivery")
            //    {
            //        Sales.Delivery = createDelivery();
            //    }
            //    Sales.Type = comboType.SelectedItem.ToString();
            //    Sales.DiscCode = "NON";
            //    Sales.Products = emp.loadCartProduct(flowLayoutPanelCheckoutItems);
            //    Sales.TotalPrice = Convert.ToInt32(txtTotal.Text);
            //    Sales.ManPrice = emp.calculateManTotal(Sales.Products);
            //    Sales.Customer = currentCust;                
            //    foreach (Product i in Sales.Products)
            //    {
            //        Console.WriteLine(i.Name + " " + i.Qty);
            //    }
            //    FormOrderConfirmation form = new FormOrderConfirmation(Sales, dateTimePicker1.Value);
            //    form.ShowDialog();
            //    if (form.DialogResult == DialogResult.OK)
            //    {
            //        clear();
            //    }
            //}
            
        }

        private void btnManageAdd_Click(object sender, EventArgs e)
        {
            FormEnterAddress form = new FormEnterAddress(currentCust);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                selectedAdd = form.selectedaddress;
                comboAddress.SelectedItem = form.selectedaddress.Label;
            }
        }

        private void comboAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            //later change this to be able to change selectedadd class
            //MessageBox.Show("you can change later.");
        }

        private void clear()
        {
            lblCustName.Visible = false;
            comboCustomer.Visible = true;
            comboCustomer.SelectedIndex = 0;
            comboAddress.Items.Clear();
            flowLayoutPanelCheckoutItems.Controls.Clear();
            txtDisc.Text = "0";
            txtSubTotal.Text = "0";
            txtDelivfee.Text = "0";
            txtTotal.Text = "0";
            
        }
    }
}
