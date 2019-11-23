using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HPPAV14\HPPAV14;Initial Catalog=CatalystDB;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow500, Primary.Yellow200, Accent.LightBlue200, TextShade.WHITE);
        }       

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Employee emp = new Employee();
            //emp.testingcopyimage();
        }

        private void login()
        {
            if (conn.State != ConnectionState.Open) { conn.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select EmpID,FirstName, LastName,Role from Employee Where Username = '"+txtUname.Text+"' and Password ='"+txtPw.Text+"' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Employee em = new Employee();
                em.EmpID = dt.Rows[0][0].ToString();
                em.FirstName = dt.Rows[0][1].ToString();
                em.LastName = dt.Rows[0][2].ToString();
                em.Role = dt.Rows[0][3].ToString();
                FormDashboard form = new FormDashboard(em);
                form.Show();
            }
            else
                MessageBox.Show("Please ensure your username and password are correct!");
            conn.Close();
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
            
        }
    }
}
