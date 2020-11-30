Public Class DeleteRecordvb

    Private Sub DeleteRecordvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_infoDeleteinfomation.student_details' table. You can move, or remove it, as needed.
        Me.Student_detailsTableAdapter.Fill(Me.Student_infoDeleteinfomation.student_details)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Register no searching area
        '"select register_no,student_name,Department,section,graduate from student_details where register_no = '"+TextBox1.Text"';" 
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' name searching area
        '"select register_no,student_name,Department,section,graduate from student_details where register_no = '"+TextBox1.Text"';" 
    End Sub
End Class