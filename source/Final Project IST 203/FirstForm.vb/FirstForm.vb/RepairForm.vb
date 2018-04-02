Public Class RepairForm
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Hide()
        RepairTotalCostInfo.ShowDialog()
    End Sub
End Class