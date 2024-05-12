using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_LAB_2
{
    public partial class Form1 : Form
    {
        public static Boolean sms, rep, tran_rep;
        public static String f_name, l_name, emailAdd;

        public Form1()
        {
            InitializeComponent();
        }

        private void reports_CheckedChanged(object sender, EventArgs e)
        {
            if(reports.Checked)
                   rep = true;
            else
                rep = false;
        }

        private void transactionReports_CheckedChanged(object sender, EventArgs e)
        {
            if(transactionReports.Checked)
                tran_rep = true;
            else
                tran_rep = false;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Confirmation c = new Confirmation();
            this.Hide();

            c.Show();
        }

        private void fNameInput_TextChanged(object sender, EventArgs e)
        {
            f_name = fNameInput.Text;
        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            emailAdd = emailInput.Text;
        }

        private void lNameInput_TextChanged(object sender, EventArgs e)
        {
            l_name = lNameInput.Text;
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void LName_Click(object sender, EventArgs e)
        {

        }

        private void fName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void smsNoti_CheckedChanged(object sender, EventArgs e)
        {
            if (smsNoti.Checked)
            {
                sms = true;
                smsNoti.Text = "SMS Notifications (SMS charges may apply)";
            }
            else
            {
                sms = false;
                smsNoti.Text = "SMS Notifications";
            }
        }
    }
}
