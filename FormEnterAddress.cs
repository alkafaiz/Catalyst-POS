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
    public partial class FormEnterAddress : Form
    {
        Employee emp = new Employee();
        Customer cus;
        public Address selectedaddress { get; set; }
        List<Address> add;
        public FormEnterAddress()
        {
            InitializeComponent();
        }
        public FormEnterAddress(Customer c)
        {
            InitializeComponent();
            cus = c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEnterAddress_Load(object sender, EventArgs e)
        {
            label3.Text = cus.FirstName + " " + cus.LastName;
            add=emp.loadAddress(cus);
            foreach (Address ad in add)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = ad.Label;
                dataGridView1.Rows[n].Cells[1].Value = ad.Addres;
                dataGridView1.Rows[n].Cells[2].Value = ad.Subdistrict;
                dataGridView1.Rows[n].Cells[3].Value = ad.District;
                dataGridView1.Rows[n].Cells[4].Value = ad.City;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                foreach (Address ad in add)
                {
                    if(ad.Addres== dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                    {
                        selectedaddress = ad;
                        break;
                    }
                }                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { MessageBox.Show("No Address is selected."); }
        }
    }
}
