Public Class RepairTotalCostInfo

    Private Sub RepairTotalCostInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adds user information from Startup form 
        txtCustomerPhone.Text = StartupForm.txtPhone.Text
        txtCustomerName.Text = StartupForm.txtName.Text
        txtEmail.Text = StartupForm.txtEmail.Text

        'adds selected repairs from repairform to repairtotalcostinfo 
        Dim choice As String
        If RepairForm.chkScreenRepair.Checked Then
            choice = "Screen Repair ($50.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkBatteryReplacment.Checked Then
            choice = "Battery Replacement ($30.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkChargingPortRepair.Checked Then
            choice = "Charging Port Repair ($35.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkHeadphonejackRepair.Checked Then
            choice = "Headphone Jack Repair ($25.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkCameraRepair.Checked Then
            choice = "Camera Repair ($30.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkOutterShellReplace.Checked Then
            choice = "Outer Shell Replacement ($15.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkPasswordRemoval.Checked Then
            choice = "Password Removal ($20.00)"
            lstRepairTypes.Items.Add(choice)
        End If
        If RepairForm.chkVirusRemoval.Checked Then
            choice = "Virus Removal ($25.00)"
            lstRepairTypes.Items.Add(choice)
        End If


        'update total cost label 
        lblTotalCost.Text = CType(RepairForm.calcTotalRepair, String)
    End Sub

End Class