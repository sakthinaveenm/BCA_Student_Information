Public Class Report_Card

    Private Sub Report_Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentyear.Items.Add("I")
        studentyear.Items.Add("II")
        studentyear.Items.Add("III")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New PrintForm
        obj.Reg = TextBox1.Text
        obj.y = studentyear.Text
        obj.Show()
    End Sub
End Class