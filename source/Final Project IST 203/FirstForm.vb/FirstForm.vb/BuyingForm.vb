Public Class BuyingForm
    Dim FinalCost As Integer


    Private Sub btnSpecsSheet_Click(sender As Object, e As EventArgs) Handles btnSpecsSheet.Click
        'opens specifications form 
        SpecificationsForm.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Hide()
        BuyingTotalCostInfo.Show()

        Dim TotalBuys As Integer

        'buying costs 
        If radiPhoneX.Checked Then
            TotalBuys = 999
        End If
        If radSamsungGalaxyS9Plus.Checked Then
            TotalBuys = 840
        End If
        If radHuaweiP20Pro.Checked Then
            TotalBuys = 1110
        End If
        If radSamsungGalaxyS9.Checked Then
            TotalBuys = 719
        End If
        If radGooglePixelXL2.Checked Then
            TotalBuys = 849
        End If
        If radHuaweiMate10Pro.Checked Then
            TotalBuys = 800
        End If
        If radSamsungGalaxyNote8.Checked Then
            TotalBuys = 900
        End If
        If radLGV30.Checked Then
            TotalBuys = 800
        End If
        If radiPhone8.Checked Then
            TotalBuys = 699
        End If
        If radGooglePixel2.Checked Then
            TotalBuys = 649
        End If
        If radSonyExperiaX72.Checked Then
            TotalBuys = 799
        End If
        If radHuaweiP20.Checked Then
            TotalBuys = 740
        End If
        If radiPhone8Plus.Checked Then
            TotalBuys = 699
        End If
        If radSamsungGalaxyS8Plus.Checked Then
            TotalBuys = 750
        End If

        'calculate final cost 
        FinalCost = TotalBuys


        BuyingTotalCostInfo.lblTotalCost.Text = calcTotalBuys.ToString("C")
    End Sub




    Private Sub UpdateView()
        dgvPhones.DataSource = DBUtilities.GetPhonesTable
    End Sub

    Private Sub BuyingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateView()
    End Sub

    Public Function calcTotalBuys() As Integer
        Dim cost As Integer

        cost = FinalCost

        Return cost
    End Function


End Class