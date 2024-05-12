using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inititalizelistbox();
        }

        private void inititalizelistbox()
        {
            Country.Items.Add("India");
            Country.Items.Add("USA");
            Country.Items.Add("UK");
            Country.Items.Add("Canada");
            State.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            State.Items.Clear();

            switch(Country.SelectedIndex)
            {
                case 0:
                    State.Items.Add("Delhi");
                    State.Items.Add("Mumbai");
                    State.Items.Add("Kolkata");
                    State.Items.Add("Chennai");
                    break;
                case 1:
                    State.Items.Add("New York");
                    State.Items.Add("California");
                    State.Items.Add("Florida");
                    State.Items.Add("Texas");
                    break;
                case 2:
                    State.Items.Add("London");
                    State.Items.Add("Manchester");
                    State.Items.Add("Birmingham");
                    State.Items.Add("Liverpool");
                    break;
                case 3:
                    State.Items.Add("Toronto");
                    State.Items.Add("Vancouver");
                    State.Items.Add("Montreal");
                    State.Items.Add("Ottawa");
                    break;
            }

            State.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Country.SelectedItem);
            MessageBox.Show(Country.SelectedItem+", " +State.SelectedItem);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        
    }
}
