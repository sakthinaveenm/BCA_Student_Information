Imports System.Data.SqlClient
Module Module1
    Public con As SqlConnection
    Public Sub signin_Connect()
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_database_Project;Integrated Security=True")
        con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Public Sub connect()
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_database_Project;Integrated Security=True")
        con.Open()
    End Sub
End Module
