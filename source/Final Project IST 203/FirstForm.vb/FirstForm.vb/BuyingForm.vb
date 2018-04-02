Public Class BuyingForm
    Private Sub btnSpecsSheet_Click(sender As Object, e As EventArgs) Handles btnSpecsSheet.Click
        'opens specifications form 
        SpecificationsForm.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Hide()
        BuyingTotalCostInfo.ShowDialog()
    End Sub
End Class