Imports System.Data.SqlClient

Public Class AddRecord
    Dim gender As String
    Dim year As String
    Dim graduage As String
    Dim Dob As String

    Private Sub AddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Department
        Department.Items.Add("BCA")
        Department.Items.Add("BBA")
        Department.Items.Add("BSW")
        'Gender
        ComboBox2.Items.Add("Male")
        ComboBox2.Items.Add("Female")
        ComboBox2.Items.Add("Others")
        'Joining year
        ComboBox3.Items.Add("2017")
        ComboBox3.Items.Add("2018")
        ComboBox3.Items.Add("2019")
        ComboBox3.Items.Add("2020")
        ComboBox3.Items.Add("2021")
        ComboBox3.Items.Add("2022")
        ComboBox3.Items.Add("2023")
        ComboBox3.Items.Add("2024")
        ComboBox3.Items.Add("2025")
        ComboBox3.Items.Add("2026")
        ComboBox3.Items.Add("2027")
        ComboBox3.Items.Add("2028")
        'End Year
        ComboBox4.Items.Add("2018")
        ComboBox4.Items.Add("2019")
        ComboBox4.Items.Add("2020")
        ComboBox4.Items.Add("2021")
        ComboBox4.Items.Add("2022")
        ComboBox4.Items.Add("2023")
        ComboBox4.Items.Add("2024")
        ComboBox4.Items.Add("2025")
        ComboBox4.Items.Add("2026")
        ComboBox4.Items.Add("2027")
        ComboBox4.Items.Add("2028")
        ComboBox4.Items.Add("2029")
        ComboBox4.Items.Add("2030")
        ComboBox4.Items.Add("2031")
        'Blood Group
        bloodgroup.Items.Add("AB+")
        bloodgroup.Items.Add("B+")
        bloodgroup.Items.Add("AB-")
        bloodgroup.Items.Add("B-")
        bloodgroup.Items.Add("A+")
        bloodgroup.Items.Add("A-")
        bloodgroup.Items.Add("O+")
        bloodgroup.Items.Add("O-")
        'Section
        Section.Items.Add("A")
        Section.Items.Add("B")
        'Date of Birth
        'Days
        Days.Items.Add("1")
        Days.Items.Add("2")
        Days.Items.Add("3")
        Days.Items.Add("4")
        Days.Items.Add("5")
        Days.Items.Add("6")
        Days.Items.Add("7")
        Days.Items.Add("8")
        Days.Items.Add("9")
        Days.Items.Add("10")
        Days.Items.Add("11")
        Days.Items.Add("12")
        Days.Items.Add("13")
        Days.Items.Add("14")
        Days.Items.Add("15")
        Days.Items.Add("16")
        Days.Items.Add("17")
        Days.Items.Add("18")
        Days.Items.Add("19")
        Days.Items.Add("20")
        Days.Items.Add("21")
        Days.Items.Add("22")
        Days.Items.Add("23")
        Days.Items.Add("24")
        Days.Items.Add("25")
        Days.Items.Add("26")
        Days.Items.Add("27")
        Days.Items.Add("28")
        Days.Items.Add("29")
        Days.Items.Add("30")
        Days.Items.Add("31")
        'Month
        Month.Items.Add("1")
        Month.Items.Add("2")
        Month.Items.Add("3")
        Month.Items.Add("4")
        Month.Items.Add("5")
        Month.Items.Add("6")
        Month.Items.Add("7")
        Month.Items.Add("8")
        Month.Items.Add("9")
        Month.Items.Add("10")
        Month.Items.Add("11")
        Month.Items.Add("12")
        'year
        DobYear.Items.Add("1995")
        DobYear.Items.Add("1996")
        DobYear.Items.Add("1997")
        DobYear.Items.Add("1998")
        DobYear.Items.Add("1999")
        DobYear.Items.Add("2000")
        DobYear.Items.Add("2001")
        DobYear.Items.Add("2002")
        DobYear.Items.Add("2003")
        DobYear.Items.Add("2004")
        DobYear.Items.Add("2005")
        DobYear.Items.Add("2006")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Added String to Concantate year and Dob
        year = ComboBox3.Text + " - " + ComboBox4.Text
        Dob = DobYear.Text + "-" + Month.Text + "-" + Days.Text
        If RadioButton1.Checked Then
            graduage = "UG"
        ElseIf RadioButton2.Checked Then
            graduage = "PG"
        Else
            MsgBox("Fill Correctly")
        End If

        'Program to add Records
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_info;Integrated Security=True")
        Dim cmd As New SqlCommand
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into student_details values(" + register_no.Text + ",'" + student_name.Text + "','" + Department.Text + "','" + Section.Text + "','" + Dob + "'," + age.Text + ",'" + graduage + "','" + ComboBox2.Text + "','" + year + "','" + bloodgroup.Text + "','" + father_name.Text + "','" + mother_name.Text + "','" + guardian_name.Text + "','" + address_home.Text + "','" + personal_email.Text + "','" + college_email.Text + "'," + pincode.Text + ");"
        If cmd.ExecuteNonQuery() Then
            MsgBox("Record added Succesfully")
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub register_no_TextChanged(sender As Object, e As EventArgs) Handles register_no.TextChanged
        college_email.Text = register_no.Text + "@mcc.edu.in"
    End Sub
End Class
