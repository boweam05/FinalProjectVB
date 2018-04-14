Public Class BuyingTotalCostInfo
    Private Sub BuyingTotalCostInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'update buying customer textbox 
        txtPhone.Text = StartupForm.txtPhone.Text
        txtCustomerName.Text = StartupForm.txtName.Text
        txtEmail.Text = StartupForm.txtEmail.Text

        If BuyingForm.radiPhoneX.Checked Then
            txtPhoneUserBought.Text = "iPhone X"
        End If
        If BuyingForm.radSamsungGalaxyS9Plus.Checked Then
            txtPhoneUserBought.Text = "Samsung Galaxy S9 Plus"
        End If
        If BuyingForm.radHuaweiP20Pro.Checked Then
            txtPhoneUserBought.Text = "Huawei P20 Pro"
        End If
        If BuyingForm.radSamsungGalaxyS9.Checked Then
            txtPhoneUserBought.Text = "Samsung Galaxy S9"
        End If
        If BuyingForm.radGooglePixelXL2.Checked Then
            txtPhoneUserBought.Text = "Google Pixel XL 2"
        End If
        If BuyingForm.radHuaweiMate10Pro.Checked Then
            txtPhoneUserBought.Text = "Huawei Mate 10 Pro"
        End If
        If BuyingForm.radSamsungGalaxyNote8.Checked Then
            txtPhoneUserBought.Text = "Samsung Galaxy Note 8"
        End If
        If BuyingForm.radLGV30.Checked Then
            txtPhoneUserBought.Text = "LG V30"
        End If
        If BuyingForm.radSamsungGalaxyS8.Checked Then
            txtPhoneUserBought.Text = "Samsung Galaxy S8"
        End If
        If BuyingForm.radiPhone8.Checked Then
            txtPhoneUserBought.Text = "iPhone 8"
        End If
        If BuyingForm.radGooglePixel2.Checked Then
            txtPhoneUserBought.Text = "Google Pixel 2"
        End If
        If BuyingForm.radSonyExperiaX72.Checked Then
            txtPhoneUserBought.Text = "Sony Xperia X72"
        End If
        If BuyingForm.radHuaweiP20.Checked Then
            txtPhoneUserBought.Text = "Huawei P20"
        End If
        If BuyingForm.radiPhone8Plus.Checked Then
            txtPhoneUserBought.Text = "iPhone 8 Plus "
        End If
        If BuyingForm.radSamsungGalaxyS8Plus.Checked Then
            txtPhoneUserBought.Text = "Samsung Galaxy S8 Plus"
        End If
    End Sub
End Class