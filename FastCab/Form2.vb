Imports MySql.Data.MySqlClient
Public Class Form2
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
            DataGridView1.DataSource = bsource
            SDA.Update(DBdataset)



            Conn.Close()

        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        Finally
            Conn.Dispose()

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        str = "server = localhost; user id=root; password =; database =fastcab"
        Conn = New MySqlConnection(str)
        query = " Delete From Staff Where ID ='" & TextBox1.Text & "' "
        Try
            Conn.Open()
            comm = New MySqlCommand(query, Conn)
            READER = comm.ExecuteReader
            MessageBox.Show("Data Deleted")
            load_table()

            Conn.Close()

        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        Finally
            Conn.Dispose()

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select Name,PhoneNumber,Location from Staff,Manager, Office Where Staff.ID = Manager.StaffID and Office.ID = Staff.officeID "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 1 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select staff.Name, staff.Sex from Staff,Driver WHERE Staff.ID = Driver.StaffID AND staff.OfficeID = 1 AND Staff.Sex = 'F'"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 2 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select office.Location, COUNT(Staff.ID) from office,staff where staff.OfficeID = Office.ID Group By Office.Location"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 3 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "Select car.officeID,Car.ID,Car.carType,Car.TaxiOwnerID from Car Where Car.OfficeID = 1 "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 4 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select COUNT(ID) AS MyCar FROM Car "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try


        ElseIf ComboBox1.SelectedIndex = 5 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select car.cartype,driver.carID, count(carID) from driver, car where car.ID = driver.carID group by carID "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 6 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select staff.name, count(car.TaxiOwnerID) from staff, car, taxiowner where taxiowner.staffid = staff.id and taxiowner.id = car.taxiownerid group by car.taxiownerid having count(car.taxiownerid)>1 "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try
        ElseIf ComboBox1.SelectedIndex = 7 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select address from clients Where Location = 'Glassgow' and Type ='B' "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 8 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from clients where Location = 'Glassgow' and Type = 'b' "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try
        ElseIf ComboBox1.SelectedIndex = 9 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select clients.Location,  count(clients.id) from clients Where clients.type = 'P' group by Location "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 10 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select * from jobs where Date = current_date "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 11 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select name from driver,staff where staff.ID = driver.staffID and Age >55 "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 12 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select clients.name, count(clients.name) as total from clients, jobs where clients.type = 'p' and clients.ID = jobs.clientID and month(jobs.date) = 11 and year(jobs.date) = 2016 "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try
        ElseIf ComboBox1.SelectedIndex = 13 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select name, address from clients Where Type = 'p' and timesordered > 3"
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try
        ElseIf ComboBox1.SelectedIndex = 14 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select AVG(MileAge) as avgmileage from jobs "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 15 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select car.id, car.cartype, count(jobs.carID) from car, jobs where car.id = jobs.carID group by car.ID "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 16 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select driver.ID, driver.carID, count(jobs.driverID) from driver, jobs where driver.id = jobs.driverID group by driver.ID "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 17 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "selecT sum(charge) from jobs where month(jobs.date) = 11 and year(jobs.date) = 2016 "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try

        ElseIf ComboBox1.SelectedIndex = 18 Then
            str = "server = localhost; user id=root; password =; database =FastCab"
            Conn = New MySqlConnection(str)
            query = "select count(jobs.id), sum(jobs.mileage)  from jobs, clients where clients.type = 'B' and clients.id = jobs.clientid "
            Dim SDA As New MySqlDataAdapter
            Dim DBdataset As New DataTable
            Dim bsource As New BindingSource

            Try
                Conn.Open()
                comm = New MySqlCommand(query, Conn)



                SDA.SelectCommand = comm
                SDA.Fill(DBdataset)
                bsource.DataSource = DBdataset
                DataGridView2.DataSource = bsource
                SDA.Update(DBdataset)



                Conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Cannot connect to database: " & ex.Message)
            Finally
                Conn.Dispose()
            End Try





        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub
End Class