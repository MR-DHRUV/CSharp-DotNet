Imports MySql.Data.MySqlClient

Public Class Form1

    Dim ds As DataSet
    Dim adapter As MySqlDataAdapter
    Dim con As MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a connection to the MySQL database
        con = New MySqlConnection("SERVER=localhost;UID=root;DATABASE=mydb;PASSWORD=msdhruv145")

        ds = New DataSet()
        BindData()

        data_container.DataSource = ds.Tables(0)
    End Sub

    Private Sub BindData()
        adapter = New MySqlDataAdapter("Select * from emp", con)
        ds.Clear()
        adapter.Fill(ds)
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        con.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("insert into emp value (@id,@fname,@lname,@email)", con)

        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idInput.Text))
        cmd.Parameters.AddWithValue("@fname", fNameInput.Text)
        cmd.Parameters.AddWithValue("@lname", lNameInput.Text)
        cmd.Parameters.AddWithValue("@email", emailInput.Text)

        cmd.ExecuteNonQuery()
        con.Close()
        BindData()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

        con.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("update emp set fname=@fname,lname=@lname,email=@email where id=@id", con)

        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idInput.Text))
        cmd.Parameters.AddWithValue("@fname", fNameInput.Text)
        cmd.Parameters.AddWithValue("@lname", lNameInput.Text)
        cmd.Parameters.AddWithValue("@email", emailInput.Text)

        cmd.ExecuteNonQuery()
        con.Close()
        BindData()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        con.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("delete from emp where id=@id", con)

        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idInput.Text))

        cmd.ExecuteNonQuery()
        con.Close()
        BindData()
    End Sub
End Class
