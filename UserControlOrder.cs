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
    public partial class UserControlOrder : UserControl
    {
        Employee emp = new Employee();
        List<Product> items;
        public UserControlOrder()
        {
            InitializeComponent();
        }
        public UserControlOrder(List<Product> item)
        {
            InitializeComponent();
            items = item;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            FormGoToPOS go = new FormGoToPOS();
            go.ShowDialog();

            if(go.DialogResult== DialogResult.OK)
            {
                FormPOSinterface pos = new FormPOSinterface(items);
                pos.Show();
                //this.Hide();
            }
        }

        private void UserControlOrder_Load(object sender, EventArgs e)
        {
            emp.loadOrder(dataGridView1);
            checkStatus(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
        }

        private void checkStatus(String curstat)
        {
            comboStatus.Items.Clear();
            comboStatus.Enabled = true;
            btnUpdate.Enabled = true;
            if(curstat == "Sent to kitchen") {
                comboStatus.Items.Add("Sent to kitchen");
                comboStatus.Items.Add("Cooking");                
            }
            if (curstat == "Cooking")
            {
                comboStatus.Items.Add("Cooking");
                comboStatus.Items.Add("On the way");
            }
            if (curstat == "On the way")
            {
                comboStatus.Items.Add("On the way");
                comboStatus.Items.Add("Completed");
            }
            if (curstat == "Completed")
            {
                comboStatus.Items.Add("Completed");
                comboStatus.Enabled = false;
                btnUpdate.Enabled = false;
            }       
            if (curstat == "Canceled")
            {                
                comboStatus.Items.Add("Canceled");
                comboStatus.Enabled = false;
                btnUpdate.Enabled = false;
            }
            comboStatus.Items.Add("Canceled");
            comboStatus.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                        
            String status = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            checkStatus(status);                                    
        }       
    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status = comboStatus.Text;          
            emp.updateOrderStatus(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), status);
            MessageBox.Show("status updated!");
            dataGridView1.SelectedRows[0].Cells[6].Value = status;
            checkStatus(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
