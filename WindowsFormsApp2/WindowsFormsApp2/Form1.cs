using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        String s;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            Console.WriteLine(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s,"Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }
    }
}
