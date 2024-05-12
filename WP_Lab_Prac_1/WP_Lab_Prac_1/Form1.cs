using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Lab_Prac_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "All Set !";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Cancelled !";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 login_form = new Form2();
            login_form.Show();
            this.Hide();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
