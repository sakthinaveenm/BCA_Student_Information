Imports System.Data
Imports System.Data.SqlClient

Public Class AddRecord
    Dim gender As String
    Dim year As String
    Dim graduage As String
    Dim Dob As String

    Private Sub AddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        'Department
        Department.Items.Add("BCA")
        'Department.Items.Add("BBA")
        'Department.Items.Add("BSW")
        Department.Text = "BCA"
        'Gender
        ComboBox2.Items.Add("Male")
        ComboBox2.Items.Add("Female")
        ComboBox2.Items.Add("Others")
        'Joining year
        For i = 2016 To 2028
            ComboBox3.Items.Add(i.ToString)
        Next
        'End Year
        For i = 2017 To 2029
            ComboBox4.Items.Add(i.ToString)
        Next
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
        For i = 1 To 31
            Days.Items.Add(i.ToString)
        Next

        ''Month
        For i = 1 To 12
            Month.Items.Add(i.ToString)
        Next
        'year
        For i = 1990 To 2010
            DobYear.Items.Add(i.ToString)
        Next
        Dim k As Integer
        i = Today.Year
        k = i + 3
        ComboBox3.Text = i.ToString
        ComboBox4.Text = k.ToString
    End Sub

    'Add Records
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Added String to Concantate year and Dob
        year = ComboBox3.Text + " - " + ComboBox4.Text
        Dob = DobYear.Text + "-" + Month.Text + "-" + Days.Text
        Try
            If RadioButton1.Checked Then
                graduage = "UG"
            ElseIf RadioButton2.Checked Then
                graduage = "PG"
            End If
            connect()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into student_details values(" + register_no.Text + ",'" + student_name.Text + "','" + Department.Text + "','" + Section.Text + "','" + Dob + "'," + age.Text + ",'" + graduage + "','" + ComboBox2.Text + "','" + year + "','" + bloodgroup.Text + "','" + father_name.Text + "','" + mother_name.Text + "','" + guardian_name.Text + "','" + address_home.Text + "','" + personal_email.Text + "','" + college_email.Text + "'," + pincode.Text + ");"

            If cmd.ExecuteNonQuery() Then
                MsgBox("Record added Succesfully")
            Else
                MsgBox("Record Already Registered")
            End If

        Catch ex As Exception
            MsgBox("Kindly fill the Details")
        End Try

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main_Option.Show()
    End Sub

    Private Sub register_no_TextChanged(sender As Object, e As EventArgs) Handles register_no.TextChanged
        college_email.Text = register_no.Text + "@mcc.edu.in"
    End Sub

    'Delete Record Coding
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        Dim reg_no As String
        reg_no = InputBox("Enter the Register Number For Student ")
        cmd.CommandText = "delete from student_details where register_no = " + reg_no + ";"
        If cmd.ExecuteNonQuery() Then
            MsgBox("Record Deleted Succesfully")
        Else
            MsgBox("No Records Available")
        End If
    End Sub

    'Update Record
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        year = ComboBox3.Text + " - " + ComboBox4.Text
        Dob = DobYear.Text + "-" + Month.Text + "-" + Days.Text
        If RadioButton1.Checked Then
            graduage = "UG"
        ElseIf RadioButton2.Checked Then
            graduage = "PG"
        Else
            MsgBox("Fill Correctly")
        End If
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "update student_details set student_name = '" + student_name.Text + "', Department = '" + Department.Text + "',Section = '" + Section.Text + "',Dob ='" + Dob + "',age =" + age.Text + ",graduate = '" + graduage + "',gender = '" + ComboBox2.Text + "',year_ = '" + year + "',bloodgroup ='" + bloodgroup.Text + "',father_name ='" + father_name.Text + "',mother_name = '" + mother_name.Text + "',guardian_name = '" + guardian_name.Text + "',address_home = '" + address_home.Text + "',personal_email = '" + personal_email.Text + "',college_email ='" + college_email.Text + "',pincode =" + pincode.Text + " where register_no =" + register_no.Text + ";"
        If cmd.ExecuteNonQuery() Then
            MsgBox("Record Updated Succesfully")
        Else
            MsgBox("No Records Available")
        End If
    End Sub

    'Search Records
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        Dim reg_no As String
        Dim tem As String
        Dim temdob As String
        Dim splitstr(3) As String
        Dim tempyr As String
        Dim splityr(3) As String
        reg_no = InputBox("Enter the Register Number For Student ")
        Dim sqlrd As SqlDataReader
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = con
        sqlcmd.CommandText = "select * from student_details where register_no = " + reg_no + ";"
        Try
            sqlrd = sqlcmd.ExecuteReader
        If sqlrd.HasRows Then
            While sqlrd.Read
                register_no.Text = sqlrd(0)
                student_name.Text = sqlrd(1)
                Department.Text = sqlrd(2)
                Section.Text = sqlrd(3)
                temdob = sqlrd(4)
                splitstr = Split(temdob, "-")
                Days.Text = splitstr(0)
                Month.Text = splitstr(1)
                DobYear.Text = splitstr(2)
                age.Text = sqlrd(5)
                tem = sqlrd(6)
                If tem = "UG" Then
                    RadioButton1.Checked = True
                ElseIf tem = "PG" Then
                    RadioButton2.Checked = True
                End If
                ComboBox2.Text = sqlrd(7)
                tempyr = sqlrd(8)
                splityr = Split(tempyr, "-")
                ComboBox3.Text = splityr(0)
                ComboBox4.Text = splityr(1)
                bloodgroup.Text = sqlrd(9)
                father_name.Text = sqlrd(10)
                mother_name.Text = sqlrd(11)
                guardian_name.Text = sqlrd(12)
                address_home.Text = sqlrd(13)
                personal_email.Text = sqlrd(14)
                college_email.Text = sqlrd(15)
                pincode.Text = sqlrd(16)
                End While
        Else
        MsgBox("No Record Found")
            End If
        Catch ex As Exception
            MsgBox("No Record Found")
        End Try

    End Sub
End Class
