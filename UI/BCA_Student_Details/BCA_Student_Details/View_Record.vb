Public Class View_Record

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub View_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_infoDataSet2.student_info' table. You can move, or remove it, as needed.
        Me.Student_infoTableAdapter3.Fill(Me.Student_infoDataSet2.student_info)
        'TODO: This line of code loads data into the 'Student_infoDataSet1.student_info' table. You can move, or remove it, as needed.
        Me.Student_infoTableAdapter2.Fill(Me.Student_infoDataSet1.student_info)
        'TODO: This line of code loads data into the 'Student_infoDataSet.student_info' table. You can move, or remove it, as needed.
        Me.Student_infoTableAdapter1.Fill(Me.Student_infoDataSet.student_info)
        'TODO: This line of code loads data into the 'Student_info._student_info' table. You can move, or remove it, as needed.
        Me.Student_infoTableAdapter.Fill(Me.Student_info._student_info)

    End Sub

   
End Class