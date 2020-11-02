Imports System.Data.SqlClient
Module Module1
    Public con As SqlConnection
    Public sqlcmd As SqlCommand()
    Public Sub Connect()
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;Integrated Security=True")
        con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        Else
            MsgBox("Connection Open")
        End If
    End Sub

End Module
