Imports System.Data.SqlClient

Public Class SignupForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Sign_in_Form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        connect()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO login VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "');"
        If cmd.ExecuteNonQuery() Then
            MsgBox("Record added Succesfully")
        End If
        con.Close()
    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    
End Class