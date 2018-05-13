Imports MySql.Data.MySqlClient

Public Class Form4
    Dim Conn As MySqlConnection
    Dim str As String
    Dim query As String
    Dim comm As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Radiobutton1.Checked = True Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Car"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton2.Checked = True Then

            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Manager"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton3.Checked = True Then

            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Clients"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton4.Checked = True Then

            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Driver"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton5.Checked = True Then

            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Jobs"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton6.Checked = True Then

            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Office"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton7.Checked = True Then

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
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        ElseIf RadioButton8.Checked = True Then

            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from Taxiowner"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView1.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()

            End Try

        End If
    End Sub
End Class