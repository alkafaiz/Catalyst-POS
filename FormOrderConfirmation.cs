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
    public partial class FormOrderConfirmation : Form
    {
        Employee emp = new Employee();
        SalesTransaction st;
        List<Address> addresses;
        public FormOrderConfirmation()
        {
            InitializeComponent();            
        }

        public FormOrderConfirmation(SalesTransaction sales, DateTime tgl)
        {
            InitializeComponent();
            st = sales;
            dateTimePicker1.Value = tgl;
        }

        private void FormOrderConfirmation_Load(object sender, EventArgs e)
        {
            if (st.Type == "Delivery")
            {
                panelDeliv.Visible = true;
                panelreview.Visible = false;
                this.Height = 473;
                emp.loadPaymentMethod(comboPayment);
                //dateTimePicker1.Value = Convert.ToDateTime("8/1/2017");
                //dateTimePicker1.MinDate = DateTime.Now; 
                var item = DateTime.Today.AddHours(7); // 14:00:00
                while (item <= DateTime.Today.AddHours(20)) // 16:00:00
                {
                    comboTime.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                    item = item.AddMinutes(15);
                }
                comboTime.SelectedIndex = 0;
                addresses = emp.loadAddress(st.Customer);
                for (int i = 0; i < addresses.Count; i++)
                {
                    comboAddress.Items.Add(addresses[i].Label);
                    if (i == 0) { st.Address = addresses[i]; showaddress(addresses[i]); }
                }
                comboAddress.SelectedIndex = 0;
                comboPayment.SelectedIndex = 1;             
            }
            else
            {
                panelreview.Top = panelDeliv.Top;
                panelDeliv.Visible = false;
                panelreview.Visible = true;
                this.Height = 500;
                
                lblCust.Text = st.Customer.FirstName + " " + st.Customer.LastName;
                lblType.Text = st.Type;
                lblPayment.Text = "Cash";
                emp.loadCartProduct(st.Products, flowLayoutPanelCheckoutItems);
                emp.calculateSubTotal(flowLayoutPanelCheckoutItems, txtSubTotal, txtTotal, txtDisc, txtDisc);
            }
            
        }

        private void showaddress(Address add)
        {
            txtAddress.Text = add.Addres + ", " + add.Subdistrict + ", " + add.Subdistrict + ", " + add.District + ", "
                + add.City + ", " + add.Province + ", " + add.Postcode;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //DateTime original = Convert.ToDateTime(comboTime.Text);
            //int hour = random.Next(1, 5);
            //int minu = random.Next(15, 61);
            //DateTime updated = original.Add(new TimeSpan(-hour, -minu, 0));
            //Console.WriteLine(updated);
            this.Close();
            //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyy"));
        }

        private void comboAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Address item in addresses)
            {
                if (item.Label == comboAddress.SelectedItem.ToString())
                {
                    showaddress(item);
                    st.Delivery.AddID = item.AddID;
                    break;
                }
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Guid pID = Guid.NewGuid();
            String codepymnt = "";
            if (st.Type == "Delivery") {codepymnt= emp.loadPaymentMethod(comboPayment.SelectedItem.ToString()); }
            else { codepymnt += "CSH"; } //getting payment code
            st.Payment = emp.createPayment(pID.ToString(),codepymnt , st.SalesTrID, st.TotalPrice, "none");
            if (st.Type == "Delivery"){
                st.Delivery.Date = dateTimePicker1.Value;
                st.Delivery.Time = Convert.ToDateTime(comboTime.Text);
                st.Delivery.SalesTrID = st.SalesTrID;
                //this section is for make mockup data - ETL
                st.DateCreated = dateTimePicker1.Value;
                //create makeup timecreated
                Random random = new Random();
                DateTime original = Convert.ToDateTime(comboTime.Text);
                int hour = random.Next(1, 4);
                int minu = random.Next(15, 61);
                DateTime updated = original.Add(new TimeSpan(-hour, -minu, 0));
                st.TimeCreated = updated;}
            //disabled for inserting makeup data           
            //st.DateCreated = DateTime.Today.Date;
            else {
                st.DateCreated = dateTimePicker1.Value;
                var item = DateTime.Today.AddHours(15);
                st.TimeCreated = item; }
            st.EmpID = "JKAHSGDI1289";
            st.Status = "Sent to kitchen";
            String time = DateTime.Now.ToString("HH:mm");
            String date = DateTime.Today.ToString("t");            
            emp.createOrder(st); //call emp fx for insert data into database
            MessageBox.Show("Order has been created.");
            this.DialogResult = DialogResult.OK; this.Close();            
        }
    }
}
