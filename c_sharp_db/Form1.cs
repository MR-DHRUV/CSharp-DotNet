using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Reflection;

namespace c_sharp_db
{
    public partial class Form1 : Form
    {
        DataSet ds;
        MySqlDataAdapter adapter;
        MySqlConnection con;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("SERVER=localhost;UID=root;DATABASE=mydb;PASSWORD=msdhruv145");
            Console.WriteLine("Connection Established");
               
            ds = new DataSet();
            adapter = new MySqlDataAdapter("SELECT * from emp", con);

            adapter.Fill(ds);
            data_container.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand insert = new MySqlCommand("insert into emp value (@id, @fname, @lname, @email)", con);
            insert.Parameters.AddWithValue("@id", Convert.ToInt32(idInput.Text));
            insert.Parameters.AddWithValue("@fname", fNameInput.Text);
            insert.Parameters.AddWithValue("@lname", lNameInput.Text);
            insert.Parameters.AddWithValue("@email", emailInput.Text);
            insert.ExecuteNonQuery();

            con.Close();
            BindData();
        }

        // To refresh the data
        void BindData()
        {
            ds.Clear();
            adapter = new MySqlDataAdapter("SELECT * from emp", con);
            adapter.Fill(ds);
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand update = new MySqlCommand("update emp set FirstName = @fname, LastName = @lname, email = @email where id = @id", con);
            update.Parameters.AddWithValue("@id", Convert.ToInt32(idInput.Text));
            update.Parameters.AddWithValue("@fname", fNameInput.Text);
            update.Parameters.AddWithValue("@lname", lNameInput.Text);
            update.Parameters.AddWithValue("@email", emailInput.Text);

            update.ExecuteNonQuery();
            con.Close();

            BindData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand delete = new MySqlCommand("delete from emp where id=@id", con);
            delete.Parameters.AddWithValue("@id", Convert.ToInt32(idInput.Text));

            delete.ExecuteNonQuery();
            con.Close();

            BindData();
        }
    }
}
