Imports System.Data.SqlClient
Imports System.Data
Public Class PrintForm
    Public Property Reg As String
    Public Property y As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim yr As String
        yr = ""
        connect()
        Dim sqlrd As SqlDataReader
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = con
        If y = "I" Then
            yr = "yearone"
            Label5.Text = "Engish"
            Label6.Text = "Tamil"
            Label7.Text = "Operating System"
            Label8.Text = "C Programming"
            Label9.Text = "Python Programming"
        ElseIf y = "II" Then
            yr = "yeartwo"
            Label5.Text = "Engish"
            Label6.Text = "Tamil"
            Label7.Text = "DS and Algo"
            Label8.Text = "Web development"
            Label9.Text = "Micro Processors"
        ElseIf y = "III" Then
            yr = "yearthree"
            Label5.Text = "Java"
            Label6.Text = "C#"
            Label7.Text = "Soft Skills and Networking"
            Label8.Text = "Software development"
            Label9.Text = "Visual Basic"
        End If
        sqlcmd.CommandText = "select * from " + yr + " where register_no = " + Reg + ";"
        Label38.Text = y
        sqlrd = sqlcmd.ExecuteReader
        If sqlrd.HasRows Then
            While sqlrd.Read
                Label39.Text = sqlrd(0)
                Label36.Text = sqlrd(1)
                Label37.Text = sqlrd(2)
                Label40.Text = sqlrd(4)
                Label18.Text = sqlrd(5)
                Label19.Text = sqlrd(6)
                Label20.Text = sqlrd(7)
                Label21.Text = sqlrd(8)
                Label22.Text = sqlrd(9)
                Label35.Text = sqlrd(10)
                Try

                    Label34.Text = sqlrd(11).ToString


                Catch ex As Exception

                End Try

                '
                If Label18.Text >= 35 Then
                    Label23.Text = "P"
                Else
                    Label23.Text = "F"
                End If
                '
                If Label18.Text >= 35 And Label18.Text < 60 Then
                    Label28.Text = "B"
                ElseIf Label18.Text >= 60 And Label18.Text < 80 Then
                    Label28.Text = "A"
                ElseIf Label18.Text >= 80 And Label18.Text < 90 Then
                    Label28.Text = "A+"
                ElseIf Label18.Text >= 90 And Label18.Text <= 100 Then
                    Label28.Text = "O"
                Else
                    Label28.Text = "C"
                End If
                'two
                Dim num2 As Integer
                num2 = Label19.Text
                If num2 >= 35 Then
                    Label24.Text = "P"
                Else
                    Label24.Text = "F"
                End If
                '
                If num2 >= 35 And num2 < 60 Then
                    Label29.Text = "B"
                ElseIf num2 >= 60 And num2 < 80 Then
                    Label29.Text = "A"
                ElseIf num2 >= 80 And num2 < 90 Then
                    Label29.Text = "A+"
                ElseIf num2 >= 90 And num2 <= 100 Then
                    Label29.Text = "O"
                Else
                    Label29.Text = "C"
                End If
                Dim num3 As Integer
                'three
                num3 = Label20.Text
                If num3 >= 35 Then
                    Label25.Text = "P"
                Else
                    Label25.Text = "F"
                End If
                '
                If num3 >= 35 And num3 < 60 Then
                    Label30.Text = "B"
                ElseIf num3 >= 60 And num3 < 80 Then
                    Label30.Text = "A"
                ElseIf num3 >= 80 And num3 < 90 Then
                    Label30.Text = "A+"
                ElseIf num3 >= 90 And num3 <= 100 Then
                    Label30.Text = "O"
                Else
                    Label30.Text = "C"
                End If
                'four
                Dim num4 As Integer
                num4 = Label21.Text
                If num4 >= 35 Then
                    Label26.Text = "P"
                Else
                    Label26.Text = "F"
                End If
                '
                If num4 >= 35 And num4 < 60 Then
                    Label31.Text = "B"
                ElseIf num4 >= 60 And num4 < 80 Then
                    Label31.Text = "A"
                ElseIf num4 >= 80 And num4 < 90 Then
                    Label31.Text = "A+"
                ElseIf num4 >= 90 And num4 <= 100 Then
                    Label31.Text = "O"
                Else
                    Label31.Text = "C"
                End If
                'five
                Dim num5 As Integer
                num5 = Label22.Text
                If num5 >= 35 Then
                    Label27.Text = "P"
                Else
                    Label27.Text = "F"
                End If
                '
                If num5 >= 35 And num5 < 60 Then
                    Label32.Text = "B"
                ElseIf num5 >= 60 And num5 < 80 Then
                    Label32.Text = "A"
                ElseIf num5 >= 80 And num5 < 90 Then
                    Label32.Text = "A+"
                ElseIf num5 >= 90 And num5 <= 100 Then
                    Label32.Text = "O"
                Else
                    Label32.Text = "C"
                End If
            End While
        Else
            MsgBox("No Record Found")
        End If




    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub
End Class