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
    public partial class UserControlCustomer : UserControl
    {
        Employee emp = new Employee();
        public UserControlCustomer()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            FormDashboard.Instance.showForm("UserControlCreateCustomer");
        }

        private void display()
        {
            Employee emp = new Employee();
            List<Customer> cuss = emp.loadCustomer();
            foreach (Customer item in cuss)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item.CustID;
                dataGridView1.Rows[n].Cells[1].Value = item.FirstName + " " + item.LastName;
                dataGridView1.Rows[n].Cells[2].Value = item.RegistrationDate.ToString();
                dataGridView1.Rows[n].Cells[3].Value = emp.loadLatestPurchase(item.CustID);
                dataGridView1.Rows[n].Cells[4].Value = emp.loadSumSpent(item.CustID);                
            }

        }

        private void UserControlCustomer_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
