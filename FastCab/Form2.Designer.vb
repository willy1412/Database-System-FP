<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 243)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(598, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(403, 243)
        Me.DataGridView2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"(a)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names and phone numbers of the Managers at each office.", "(b)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names of all female drivers based in the Glasgow office. ", "(c)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of staff at each office.", "(d)" & Global.Microsoft.VisualBasic.ChrW(9) & "The details of all taxis at the Glasgow office.", "(e)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of W registered taxis.", "(f)" & Global.Microsoft.VisualBasic.ChrW(9) & "The number of drivers allocated to each taxi.", "(g)" & Global.Microsoft.VisualBasic.ChrW(9) & "The name and number of owners with more than one taxi.", "(h)" & Global.Microsoft.VisualBasic.ChrW(9) & "The full address of all business clients in Glasgow.", "(i)" & Global.Microsoft.VisualBasic.ChrW(9) & "The details of the current contracts with business clients in Glasgow.", "(j)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of private clients in each city.", "(k)" & Global.Microsoft.VisualBasic.ChrW(9) & "The details of jobs undertaken by a driver on a given day.", "(l)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names of drivers who are over 55 years old.", "(m)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names and numbers of private clients who hired a taxi in November 2016.", "(n)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names and addresses of private clients who have hired a taxi more than th" &
                "ree times.", "(o)" & Global.Microsoft.VisualBasic.ChrW(9) & "The average number of miles driven during a job.", "(p)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of jobs allocated to each car.", "(q)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of jobs allocated to each driver.", "(r)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total amount charged for each car in November 2016.", "(s)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of jobs and miles driven for a given contract"})
        Me.ComboBox1.Location = New System.Drawing.Point(598, 258)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.MaxDropDownItems = 19
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(393, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Location = New System.Drawing.Point(329, 283)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(88, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Add Staff"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(341, 259)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(750, 296)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 21)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Show all Tables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
