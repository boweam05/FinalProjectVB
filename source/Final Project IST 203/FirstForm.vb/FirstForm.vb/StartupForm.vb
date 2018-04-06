Public Class StartupForm
    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        'opens up buying form 
        Hide()
        BuyingForm.ShowDialog()
    End Sub

    Private Sub btnRepair_Click(sender As Object, e As EventArgs) Handles btnRepair.Click
        'clears errorprovider 
        errProvider.Clear()

        'if textboxes are blank throw an error 
        If txtName.Text = "" Then
            errProvider.SetError(txtName, "Name Cannot Be Blank")
            txtName.Focus()
            Return
        End If
        If txtPhone.Text = "" Then
            errProvider.SetError(txtPhone, "Phone Number Can Not Be Blank")
            txtPhone.Focus()
            Return
        End If
        If txtEmail.Text = "" Then
            errProvider.SetError(txtEmail, "Email Cannot Be Blank")
            txtEmail.Focus()
            Return
        End If

        'if textboxes contains numbers 
        If IsNumeric(txtName.Text) Then
            errProvider.SetError(txtName, "Names Do Not Contain Such Characters")
            txtName.Focus()
            Return
        End If

        'opens repair form 
        Hide()
        RepairForm.ShowDialog()
    End Sub

    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Hello and welcome to Austin's Cell Phone Shop. Here you will be able to buy, browse, purchase and repair a cell phone at your convience. This shop does not use sales tax.")

    End Sub
End Class
