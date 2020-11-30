Imports System.Data
Imports System.Data.SqlClient
Public Class Sign_in_Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        Label6.Visible = True
        Label6.Text = "Success"
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        SignupForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_info;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from login where username = '" + TextBox1.Text + "' and Password ='" + TextBox2.Text + "';", con)

        Dim sqladapter As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As DataTable = New DataTable()

        sqladapter.Fill(dt)

        If dt.Rows.Count() > 0 Then
            Label3.Visible = False
            MsgBox("Success")
            Me.Hide()
            Main_Option.Show()
        Else

            Label3.Visible = True
            Label3.ForeColor = Color.Red
        End If

    End Sub

End Class
