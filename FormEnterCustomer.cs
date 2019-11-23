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
    public partial class FormEnterCustomer : Form
    {
        Employee emp = new Employee();
        List<Customer> customers;
        

        public Customer cust { get; set; }

        public FormEnterCustomer()
        {
            InitializeComponent();
        }

        private void FormEnterCustomer_Load(object sender, EventArgs e)
        {
            customers = emp.loadCustomer(dataGridView1);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                cust = emp.loadCustomer(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { MessageBox.Show("No Customer is selected."); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            emp.searchCustomer(dataGridView1, txtSearch);
        }
    }
}
