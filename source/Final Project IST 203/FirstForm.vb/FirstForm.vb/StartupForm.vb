Public Class StartupForm
    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        'opens up buying form 
        Hide()
        BuyingForm.ShowDialog()
    End Sub

    Private Sub btnRepair_Click(sender As Object, e As EventArgs) Handles btnRepair.Click
        'opens repair form 
        Hide()
        RepairForm.ShowDialog()
    End Sub
End Class
