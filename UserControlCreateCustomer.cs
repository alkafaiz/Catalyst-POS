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
    public partial class UserControlCreateCustomer : UserControl
    {
        public UserControlCreateCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormDashboard.Instance.showForm("UserControlCustomer");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            Guid ID = Guid.NewGuid();
            cus.CustID = ID.ToString();
            cus.FirstName = txtFirstName.Text;
            cus.LastName = txtLastName.Text;
            cus.DoB = dateTimeDoB.Value;
            cus.Phone = txtPhone.Text;
            cus.Email = txtEmail.Text;
            cus.Occupation = txtOccupation.Text;
            cus.Point = 0;

            Address add = new Address();
            Guid AID = Guid.NewGuid();
            add.AddID = AID.ToString();
            add.CustID = cus.CustID;
            add.Label = txtLabel.Text;
            add.Addres = txtAddress.Text;
            add.Subdistrict = txtSubdistrict.Text;
            add.District = txtDistrict.Text;
            add.City = txtCity.Text;
            add.Province = txtProvince.Text;
            add.Postcode = Convert.ToInt32(txtPostcode.Text);

            Employee emp = new Employee();
            emp.addCustomer(cus);
            emp.addAddress(add);
            MessageBox.Show("New Customer has been created successfully!");
            FormDashboard.Instance.showForm("UserControlCustomer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < 26; i++)
            {
                Employee emp = new Employee();
                List<String> adds = emp.randomAddress();
                List<String> cust = emp.randomCust();
                if (emp.isExist("FirstName", cust[0]) == false && emp.isExist("LastName", cust[1]) == false)
                {
                    Customer cus = new Customer();
                    Guid ID = Guid.NewGuid();
                    cus.CustID = ID.ToString();
                    cus.FirstName = cust[0];
                    cus.LastName = cust[1];
                    Console.WriteLine(cust[2]);
                    cus.DoB = Convert.ToDateTime(cust[2]);
                    cus.Phone = cust[3];
                    cus.Email = cust[4];
                    cus.Occupation = cust[5];
                    cus.Point = 0;
                    Address add = new Address();
                    Guid AID = Guid.NewGuid();
                    add.AddID = AID.ToString();
                    add.CustID = cus.CustID;
                    add.Label = adds[0];
                    add.Addres = adds[1];
                    add.Subdistrict = adds[2];
                    add.District = adds[3];
                    add.City = adds[4];
                    add.Province = adds[5];
                    add.Postcode = Convert.ToInt32(adds[6]);
                    emp.addCustomer(cus);
                    emp.addAddress(add);
                    n += 1;
                }
                
            }
            
            MessageBox.Show(n+" New Customer has been created successfully!");
        }
    }
}
