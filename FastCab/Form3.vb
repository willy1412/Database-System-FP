Imports MySql.Data.MySqlClient
Public Class Form3
    Dim Conn As MySqlConnection
    Dim str As String
    Dim query As String
    Dim comm As MySqlCommand
    Dim READER As MySqlDataReader

    Private Sub load_table()
        str = "server = localhost; user id=root; password =; database =FastCab"
        Conn = New MySqlConnection(str)
        query = "select * from Staff"
        Dim SDA As New MySqlDataAdapter
        Dim DBdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            Conn.Open()
            comm = New MySqlCommand(query, Conn)



            SDA.SelectCommand = comm
            SDA.Fill(DBdataset)
            bsource.DataSource = DBdataset
            Form2.DataGridView1.DataSource = bsource
            SDA.Update(DBdataset)



            Conn.Close()

        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        Finally
            Conn.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = "server = localhost; user id=root; password =; database =Fastcab"
        Conn = New MySqlConnection(str)

        If ComboBox1.SelectedIndex = 0 Then
            query = "insert into staff(OfficeID, ID, Name, Age, Sex) VALUES (1, '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox1.Text + "', '" + TextBox4.Text + "')"
            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)
                READER = comm.ExecuteReader
                MessageBox.Show("Data Saved")
                load_table()

                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()



            End Try

        ElseIf ComboBox1.SelectedIndex = 1 Then
            query = "insert into staff(OfficeID, ID, Name, Age, Sex) VALUES (2, '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox1.Text + "', '" + TextBox4.Text + "')"
            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)
                READER = comm.ExecuteReader
                MessageBox.Show("Data Saved")
                load_table()

                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()



            End Try

        ElseIf ComboBox1.SelectedIndex = 2 Then
            query = "insert into staff(OfficeID, ID, Name, Age, Sex) VALUES (3, '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox1.Text + "', '" + TextBox4.Text + "')"
            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)
                READER = comm.ExecuteReader
                MessageBox.Show("Data Saved")
                load_table()

                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()



            End Try

        ElseIf ComboBox1.SelectedIndex = 3 Then
            query = "insert into staff(OfficeID, ID, Name, Age, Sex) VALUES (4, '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox1.Text + "', '" + TextBox4.Text + "')"
            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)
                READER = comm.ExecuteReader
                MessageBox.Show("Data Saved")
                load_table()

                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()



            End Try


        ElseIf ComboBox1.SelectedIndex = 4 Then
            query = "insert into staff(OfficeID, ID, Name, Age, Sex) VALUES (5, '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox1.Text + "', '" + TextBox4.Text + "')"
            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)
                READER = comm.ExecuteReader
                MessageBox.Show("Data Saved")
                load_table()

                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()



            End Try

        End If
    End Sub
End Class