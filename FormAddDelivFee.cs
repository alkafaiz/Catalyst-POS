﻿using System;
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
    public partial class FormAddDelivFee : Form
    {
        public FormAddDelivFee()
        {
            InitializeComponent();
        }
        public int fee { get; set; }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fee = Convert.ToInt32(txtFee.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
