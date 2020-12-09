Public Class Searchform

    Private Sub Searchform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentyear.Items.Add("I")
        studentyear.Items.Add("II")
        studentyear.Items.Add("III")
    End Sub

    Private Sub Marksheet_Click(sender As Object, e As EventArgs) Handles Marksheet.Click
        Dim obj As New MarkSheet
        obj.Reg_ = TextBox1.Text
        obj.y_ = studentyear.Text
        obj.Show()
    End Sub
End Class