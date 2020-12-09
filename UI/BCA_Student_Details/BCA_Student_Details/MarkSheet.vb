Imports System.Data
Imports System.Data.SqlClient

Public Class MarkSheet
    Public Property Reg_ As String
    Public Property y_ As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentyear.SelectedIndexChanged
        If studentyear.Text = "I" Then
            Label3.Text = "Engish"
            Label4.Text = "Tamil"
            Label5.Text = "Operating System"
            Label6.Text = "C Programming"
            Label7.Text = "Python Programming"
        ElseIf studentyear.Text = "II" Then
            Label3.Text = "Engish"
            Label4.Text = "Tamil"
            Label5.Text = "DS and Algo"
            Label6.Text = "Web development"
            Label7.Text = "Micro Processors"
        ElseIf studentyear.Text = "III" Then
            Label3.Text = "Java"
            Label4.Text = "C#"
            Label5.Text = "SNA"
            Label6.Text = "Software development"
            Label7.Text = "Visual Basic"
        End If
    End Sub

    Private Sub MarkSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentyear.Items.Add("I")
        studentyear.Items.Add("II")
        studentyear.Items.Add("III")
        connect()
        Dim cmd As New SqlCommand("select * from student_details", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        da.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "register_no"
        ComboBox1.ValueMember = "register_no"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, num3, num4, num5, Gpa As Integer
        Try

        num1 = TextBox2.Text
        If num1 >= 35 Then
            Label15.Text = "P"
        Else
            Label15.Text = "F"
        End If
        '
        If num1 >= 90 And num1 <= 100 Then
            Label20.Text = "O"
        ElseIf num1 >= 80 And num1 < 90 Then
            Label20.Text = "A+"
        ElseIf num1 >= 60 And num1 < 80 Then
            Label20.Text = "A"
        ElseIf num1 >= 35 And num1 < 60 Then
            Label20.Text = "B"
        Else
            Label20.Text = "C"
        End If
        'two
        num2 = TextBox6.Text
        If num2 >= 35 Then
            Label16.Text = "P"
        Else
            Label16.Text = "F"
        End If
        '
        If num2 >= 90 And num2 <= 100 Then
            Label21.Text = "O"
        ElseIf num2 >= 80 And num2 < 90 Then
            Label21.Text = "A+"
        ElseIf num2 >= 60 And num2 < 80 Then
            Label21.Text = "A"
        ElseIf num2 >= 35 And num2 < 60 Then
            Label21.Text = "B"
        Else
            Label21.Text = "C"
        End If
        'three
        num3 = TextBox5.Text
        If num3 >= 35 Then
            Label17.Text = "P"
        Else
            Label17.Text = "F"
        End If
        '
        If num3 >= 90 And num3 <= 100 Then
            Label22.Text = "O"
        ElseIf num3 >= 80 And num3 < 90 Then
            Label22.Text = "A+"
        ElseIf num3 >= 60 And num3 < 80 Then
            Label22.Text = "A"
        ElseIf num3 >= 35 And num3 < 60 Then
            Label22.Text = "B"
        Else
            Label22.Text = "C"
        End If
        'four
        num4 = TextBox4.Text
        If num4 >= 35 Then
            Label18.Text = "P"
        Else
            Label18.Text = "F"
        End If
        '
        If num4 >= 90 And num4 <= 100 Then
            Label23.Text = "O"
        ElseIf num4 >= 80 And num4 < 90 Then
            Label23.Text = "A+"
        ElseIf num4 >= 60 And num4 < 80 Then
            Label23.Text = "A"
        ElseIf num4 >= 35 And num4 < 60 Then
            Label23.Text = "B"
        Else
            Label23.Text = "C"
        End If
        'five
        num5 = TextBox3.Text
        If num5 >= 35 Then
            Label19.Text = "P"
        Else
            Label19.Text = "F"
        End If
        '
        If num5 >= 90 And num5 <= 100 Then
            Label24.Text = "O"
        ElseIf num5 >= 80 And num5 < 90 Then
            Label24.Text = "A+"
        ElseIf num5 >= 60 And num5 < 80 Then
            Label24.Text = "A"
        ElseIf num5 >= 35 And num5 < 60 Then
            Label24.Text = "B"
        Else
            Label24.Text = "C"
        End If
            '
            Dim total As Integer
            total = num1 + num2 + num3 + num4 + num5
            Label29.Text = total.ToString
            Gpa = total / 5
        'Label29.Text = Gpa
        If Gpa >= 90 And Gpa <= 100 Then
            Label25.Text = "O"
        ElseIf Gpa >= 80 And Gpa < 90 Then
            Label25.Text = "A+"
        ElseIf Gpa >= 60 And Gpa < 80 Then
            Label25.Text = "A"
        ElseIf Gpa >= 35 And Gpa < 60 Then
            Label25.Text = "B"
        Else
            Label25.Text = "C"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim con As New SqlConnection
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_database_Project;Integrated Security=True")
        con.Open()
        Dim sqlrd As SqlDataReader
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = con
        sqlcmd.CommandText = "select student_name,Department,Section,year_ from student_details where register_no = " + ComboBox1.Text + ";"
        Try
            sqlrd = sqlcmd.ExecuteReader
            If sqlrd.HasRows Then
                While sqlrd.Read
                    TextBox7.Text = sqlrd(0)
                    TextBox8.Text = sqlrd(1)
                    TextBox9.Text = sqlrd(2)
                    TextBox1.Text = sqlrd(3)
                End While
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        Dim yr As String
        If studentyear.Text = "I" Then
            yr = "yearone"
            cmd.CommandText = "insert into " + yr + " values(" + ComboBox1.Text + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox6.Text + "," + TextBox5.Text + "," + TextBox4.Text + "," + TextBox3.Text + ",'" + Label25.Text + "'," + Label29.Text + ");"
            Try

            If cmd.ExecuteNonQuery Then
                MsgBox("Record Added Success Fully")
            Else
                MsgBox("Record Not Added Success Fully")
                End If
            Catch ex As Exception
                MsgBox("Record Already Exist")
            End Try

        ElseIf studentyear.Text = "II" Then
            yr = "yeartwo"
            cmd.CommandText = "insert into " + yr + " values(" + ComboBox1.Text + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox6.Text + "," + TextBox5.Text + "," + TextBox4.Text + "," + TextBox3.Text + ",'" + Label25.Text + "'," + Label29.Text + ");"
            Try
                If cmd.ExecuteNonQuery Then
                    MsgBox("Record Added Success Fully")
                Else
                    MsgBox("Record Not Added Success Fully")
                End If
            Catch ex As Exception
                MsgBox("Already Exist ")
            End Try

        ElseIf studentyear.Text = "III" Then
            yr = "yearthree"
            cmd.CommandText = "insert into " + yr + " values(" + ComboBox1.Text + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox6.Text + "," + TextBox5.Text + "," + TextBox4.Text + "," + TextBox3.Text + ",'" + Label25.Text + "'," + Label29.Text + ");"
            Try

            If cmd.ExecuteNonQuery Then
                MsgBox("Record Added Success Fully")
            Else
                MsgBox("Record Not Added Success Fully")
                End If
            Catch ex As Exception
                MsgBox("Already Exist")
            End Try

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Report_Card.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DeleteRecordDialog.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Main_Option.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Main_Option.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        Dim cmd As New SqlCommand("select * from student_details", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        table.Clear()
        da.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "register_no"
        ComboBox1.ValueMember = "register_no"
    End Sub
End Class
