Public Class RepairForm

    Dim FinalCost As Integer
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
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

        'calculate total repair cost 
        FinalCost = TotalRepairs
        RepairTotalCostInfo.lblTotalCost.Text = calcTotalRepair.ToString("C")
    End Sub
    'return total cost 
    Public Function calcTotalRepair() As Integer
        Dim cost As Integer

        cost = FinalCost

        Return cost
    End Function


End Class