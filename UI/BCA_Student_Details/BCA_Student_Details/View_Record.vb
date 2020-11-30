Imports System.Data
Imports System.Data.SqlClient

Public Class View_Record
    Private Sub View_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDetailsALL.student_details' table. You can move, or remove it, as needed.
        Me.Student_detailsTableAdapter1.Fill(Me.StudentDetailsALL.student_details)
       
        'Add Year Values
        Year.Items.Add("2015 - 2018")
        Year.Items.Add("2016 - 2019")
        Year.Items.Add("2017 - 2020")
        Year.Items.Add("2018 - 2021")
        Year.Items.Add("2019 - 2022")
        Year.Items.Add("2020 - 2023")
        Year.Items.Add("2021 - 2024")
        Year.Items.Add("2022 - 2025")
        Year.Items.Add("2023 - 2026")
        'added section values
        Section.Items.Add("A")
        Section.Items.Add("B")
        'DEpartments Adding Area
        Department.Items.Add("BCA")
        Department.Items.Add("BSW")
        Department.Items.Add("BBA")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

End Class



'Mistake happened  code
'Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_info;Integrated Security=True")
''Dim reader As SqlDataReader
''Try
'con.Open()
'Dim cmd As SqlCommand = New SqlCommand("select * from student_details", con)
'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
'Dim table As New DataTable()
'adapter.Fill(table)
'ComboBox1.DataSource = table
'ComboBox1.DisplayMember = "year_"
'ComboBox1.ValueMember = "register_no"
''reader = cmd.ExecuteReader
''While reader.Read
''    Dim syear As String
''    syear = reader.GetString("year_")
''    ComboBox1.Items.Add(syear)
''End While
''con.Close()
' ''Catch ex As Exception
''MsgBox("Error")

''End Try


'Data Grid view errored Code
'TODO: This line of code loads data into the 'Student_infoDataSet3.student_details' table. You can move, or remove it, as needed.
'Me.Student_detailsTableAdapter.Fill(Me.Student_infoDataSet3.student_details)
''TODO: This line of code loads data into the 'Student_Database_Final.student_info' table. You can move, or remove it, as needed.
'Me.Student_infoTableAdapter4.Fill(Me.Student_Database_Final.student_info)
''TODO: This line of code loads data into the 'Student_infoDataSet2.student_info' table. You can move, or remove it, as needed.
'Me.Student_infoTableAdapter3.Fill(Me.Student_infoDataSet2.student_info)
''TODO: This line of code loads data into the 'Student_infoDataSet1.student_info' table. You can move, or remove it, as needed.
'Me.Student_infoTableAdapter2.Fill(Me.Student_infoDataSet1.student_info)
''TODO: This line of code loads data into the 'Student_infoDataSet.student_info' table. You can move, or remove it, as needed.
'Me.Student_infoTableAdapter1.Fill(Me.Student_infoDataSet.student_info)
''TODO: This line of code loads data into the 'Student_info._student_info' table. You can move, or remove it, as needed.
'Me.Student_infoTableAdapter.Fill(Me.Student_info._student_info)