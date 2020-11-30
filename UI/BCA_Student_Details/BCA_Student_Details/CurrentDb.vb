Imports System.Data
Imports System.Data.SqlClient

Module CurrentDb
    Public Sub DBConnect()
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=student_info;Integrated Security=True")
    End Sub
End Module
