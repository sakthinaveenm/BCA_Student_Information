Imports System.Data.SqlClient
Imports System.Data

Public Class DeleteRecordDialog




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        Dim yr As String
        Try
        If studentyear.Text = "I" Then
            yr = "yearone"
            cmd.CommandText = "delete from " + yr + " where register_no =" + TextBox1.Text + ";"
            If cmd.ExecuteNonQuery Then
                MsgBox("Record Deleted Success Fully")
            Else
                MsgBox("Record Not Deleted Success Fully")
            End If
        ElseIf studentyear.Text = "II" Then
            yr = "yeartwo"
            cmd.CommandText = "delete from " + yr + " where register_no =" + TextBox1.Text + ";"
            If cmd.ExecuteNonQuery Then
                MsgBox("Record Deleted Success Fully")
            Else
                MsgBox("Record Not Deleted Success Fully")
            End If
        ElseIf studentyear.Text = "III" Then
            yr = "yearthree"
            cmd.CommandText = "delete from " + yr + " where register_no =" + TextBox1.Text + ";"
            If cmd.ExecuteNonQuery Then
                MsgBox("Record Deleted Success Fully")
            Else
                MsgBox("Record Not Deleted Success Fully")
            End If
        End If
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentyear.Items.Add("I")
        studentyear.Items.Add("II")
        studentyear.Items.Add("III")
    End Sub
End Class