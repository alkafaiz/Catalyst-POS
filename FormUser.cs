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
    public partial class FormUser : Form
    {
        Employee em = new Employee();
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            showUser();
            comboRole.SelectedIndex = 0;
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void showUser()
        {
            //dataGridView1.Rows.Clear();
            // TODO: This line of code loads data into the 'catalystDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.catalystDBDataSet.Employee);
        }

        private void clearall()
        {
            txtFirstName.Text="";
            txtLastName.Text = "";
            comboRole.SelectedIndex =0;
            txtUsername.Text = "";
            txtPw.Text = "";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text!=""|| txtLastName.Text != "" || txtUsername.Text != "" || txtPw.Text != "")
            {
                Employee emp = new Employee();
                Guid ID = Guid.NewGuid();
                emp.EmpID = ID.ToString();
                emp.FirstName = txtFirstName.Text;
                emp.LastName = txtLastName.Text;
                emp.Role = comboRole.SelectedItem.ToString();
                emp.Username = txtUsername.Text;
                emp.Password = txtPw.Text;
                emp.DoB = dateTimePicker1.Value;
                em.createUser(emp);
                MessageBox.Show("New user with id: " + ID.ToString() + " has been created");
                clearall();
            }
            else { MessageBox.Show("Please fill all the field."); }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            em.SaveUser(dataGridView1);
            MessageBox.Show("Users have been saved.");
            showUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            em.DeleteUser(ID);
            MessageBox.Show("1 user has been deleted.");
            showUser();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) { showUser(); }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
