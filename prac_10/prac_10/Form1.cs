using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                int numarator = int.Parse(num.Text);
                int denominator = int.Parse(den.Text);

                if (denominator == 0)
                {
                    throw new Exception("Denominator cannot be 0");
                }

                res.Text = (numarator / denominator).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
