Imports System.Data
Imports System.Data.SqlClient

Public Class View_Record
    Private Sub View_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Record View Code
        Me.Student_detailsTableAdapter2.Fill(Me.Student_database_ProjectDataSet.student_details)
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
        'added Department Values
        Department.Items.Add("BCA")
        Department.Text = "BCA"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main_Option.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Student_detailsTableAdapter2.Fill(Me.Student_database_ProjectDataSet.student_details)
        '
        connect()
        Dim query As String = "select * from student_details where  Department = 'BCA'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    'Only Checks for Department
    Private Sub Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Department.SelectedIndexChanged
        connect()
        Dim query As String = "select * from student_details where  Department = '" + Department.Text + "'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    'Only Checks for Section
    Private Sub Section_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Section.SelectedIndexChanged
        connect()
        Dim query As String = "select * from student_details where  section = '" + Section.Text +"'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    'Only Checks for Year
    Private Sub Year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Year.SelectedIndexChanged
        connect()
        Dim query As String = "select * from student_details where  year_ = '" + Year.Text + "'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    ' Checks for both department,section and year 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        Dim query As String = "select * from student_details where  year_ = '" + Year.Text + "' and section = '" + Section.Text + "' and Department = '" + Department.Text + "'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class



