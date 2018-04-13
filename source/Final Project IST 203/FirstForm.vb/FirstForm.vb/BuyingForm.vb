Public Class BuyingForm
    Private Sub btnSpecsSheet_Click(sender As Object, e As EventArgs) Handles btnSpecsSheet.Click
        'opens specifications form 
        SpecificationsForm.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Hide()
        BuyingTotalCostInfo.ShowDialog()
    End Sub

    Private Sub UpdateView()
        dgvPhones.DataSource = DBUtilities.GetPhonesTable
    End Sub

    Private Sub BuyingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateView()
    End Sub
End Class