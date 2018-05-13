Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Conn As MySqlConnection
    Dim str As String
    Dim query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = "server = localhost; user id=root; password =; database =Fastcab"
        Conn = New MySqlConnection(str)
        query = "select staff.name, manager.ID from Staff, manager  where staff.ID = manager.staffID and staff.name = '" & TextBox1.Text + "' and manager.ID = '" + TextBox2.Text + "'"
        Try
            Conn.Open()
            comm = New MySqlCommand(query, Conn)
            reader = comm.ExecuteReader
            If (reader.Read) Then
                MessageBox.Show("Welcome")
                Form2.Show()
            Else
                MessageBox.Show("wrong Username or Password", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Conn.Close()

        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        Finally
            Conn.Dispose()



        End Try
    End Sub
End Class
