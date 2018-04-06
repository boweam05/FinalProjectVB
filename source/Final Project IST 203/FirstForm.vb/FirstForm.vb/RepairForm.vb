Public Class RepairForm

    Dim FinalCost As Integer
    Const FastRepair As Integer = 7
    Const SlowRepair As Integer = 0
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'clears errprovider 
        errProvider.Clear()
        Hide()
        RepairTotalCostInfo.Show()
        'repair costs 
        Dim TotalRepairs As Integer

        If chkScreenRepair.Checked Then
            TotalRepairs = 50
        End If
        If chkBatteryReplacment.Checked Then
            TotalRepairs += 30
        End If
        If chkChargingPortRepair.Checked Then
            TotalRepairs += 35
        End If
        If chkHeadphonejackRepair.Checked Then
            TotalRepairs += 25
        End If
        If chkCameraRepair.Checked Then
            TotalRepairs += 30
        End If
        If chkOutterShellReplace.Checked Then
            TotalRepairs += 15
        End If
        If chkPasswordRemoval.Checked Then
            TotalRepairs += 20
        End If
        If chkVirusRemoval.Checked Then
            TotalRepairs += 25
        End If

        'when the user hits the yes or no buttton on whether they have been to my store before. 
        Const YESCost As Integer = 2
        Dim FirstDiscount As Integer
        If radYES.Checked Then
            FirstDiscount = YESCost
        End If

        'calculate total repair cost 
        Const FastRepair As Integer = 7
        If radFastRepair.Checked Then
            FinalCost = TotalRepairs - FirstDiscount + FastRepair
        End If
        If radSlowRepair.Checked Then
            FinalCost = TotalRepairs - FirstDiscount + SlowRepair
        End If



        RepairTotalCostInfo.lblTotalCost.Text = calcTotalRepair.ToString("C")
    End Sub
    'return total cost 
    Public Function calcTotalRepair() As Integer
        Dim cost As Integer

        cost = FinalCost

        Return cost
    End Function

    Private Sub radYES_CheckedChanged(sender As Object, e As EventArgs) Handles radYES.CheckedChanged

        If radYES.Checked Then
            MessageBox.Show("Since you have visited the store in the past, you will be rewarded with a $2.00 discount.

                                     Thank you for coming again!")
        End If

    End Sub

    Private Sub radNO_CheckedChanged(sender As Object, e As EventArgs) Handles radNO.CheckedChanged
        If radNO.Checked Then
            MessageBox.Show("You have not visited the store before. Unfortunatley we can not give you a $2.00 discount.

                              Thank you for shopping with us!")
        End If
    End Sub


End Class

