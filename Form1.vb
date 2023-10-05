Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnAddItems_Click(sender As Object, e As EventArgs) Handles btnAddItems.Click
        Dim counter, sum As Integer
        sum = 1000
        For counter = 100 To 5 Step -5
            sum -= counter
            lBoxItems.Items.Add(sum)
        Next
    End Sub
End Class
