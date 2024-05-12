using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_11
{
    public partial class Form1 : Form
    {
        public static int ID;
        public static String f_name, l_name, emailAdd;
        public static DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
           
            // Initialize the dataset
            ds.Tables.Add("Employee");

            // Add columns to the table
            ds.Tables["Employee"].Columns.Add("ID");
            ds.Tables["Employee"].Columns.Add("First Name");
            ds.Tables["Employee"].Columns.Add("Last Name");
            ds.Tables["Employee"].Columns.Add("Email");

            // constraints
            ds.Tables["Employee"].Constraints.Add("ID_PK", ds.Tables["Employee"].Columns["ID"], true);

            data_container.DataSource = ds.Tables["Employee"];
        }

    
        private void signupBtn_Click(object sender, EventArgs e)
        {
            var record = ds.Tables["Employee"].Rows.Find(ID);

            if (record == null)
            {
                ds.Tables["Employee"].Rows.Add(ID, f_name, l_name, emailAdd);
            }
            else
            {
                MessageBox.Show("Record with Id :"+ID.ToString()+" already exists");
            }   
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int id))
            {
                ID = id;
            }
            else
            {
                ID = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            ds.Tables["Employee"].Rows.Find(ID)["First Name"] = f_name;
            ds.Tables["Employee"].Rows.Find(ID)["Last Name"] = l_name;
            ds.Tables["Employee"].Rows.Find(ID)["Email"] = emailAdd;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ds.Tables["Employee"].Rows.Find(ID).Delete();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
    }
}
