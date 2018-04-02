<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkScreenRepair = New System.Windows.Forms.CheckBox()
        Me.chkBatteryReplacment = New System.Windows.Forms.CheckBox()
        Me.chkChargingPortRepair = New System.Windows.Forms.CheckBox()
        Me.chkHeadphonejackRepair = New System.Windows.Forms.CheckBox()
        Me.chkCameraRepair = New System.Windows.Forms.CheckBox()
        Me.chkOutterShellReplace = New System.Windows.Forms.CheckBox()
        Me.chkPasswordRemoval = New System.Windows.Forms.CheckBox()
        Me.chkVirusRemoval = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radNO = New System.Windows.Forms.RadioButton()
        Me.radYES = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "We Have These Repairs For You"
        '
        'chkScreenRepair
        '
        Me.chkScreenRepair.AutoSize = True
        Me.chkScreenRepair.Location = New System.Drawing.Point(34, 83)
        Me.chkScreenRepair.Name = "chkScreenRepair"
        Me.chkScreenRepair.Size = New System.Drawing.Size(136, 17)
        Me.chkScreenRepair.TabIndex = 1
        Me.chkScreenRepair.Text = "Screen Repair ($50.00)"
        Me.chkScreenRepair.UseVisualStyleBackColor = True
        '
        'chkBatteryReplacment
        '
        Me.chkBatteryReplacment.AutoSize = True
        Me.chkBatteryReplacment.Location = New System.Drawing.Point(34, 117)
        Me.chkBatteryReplacment.Name = "chkBatteryReplacment"
        Me.chkBatteryReplacment.Size = New System.Drawing.Size(167, 17)
        Me.chkBatteryReplacment.TabIndex = 2
        Me.chkBatteryReplacment.Text = "Battery Replacement ($30.00)"
        Me.chkBatteryReplacment.UseVisualStyleBackColor = True
        '
        'chkChargingPortRepair
        '
        Me.chkChargingPortRepair.AutoSize = True
        Me.chkChargingPortRepair.Location = New System.Drawing.Point(34, 152)
        Me.chkChargingPortRepair.Name = "chkChargingPortRepair"
        Me.chkChargingPortRepair.Size = New System.Drawing.Size(166, 17)
        Me.chkChargingPortRepair.TabIndex = 3
        Me.chkChargingPortRepair.Text = "Charging Port Repair ($35.00)"
        Me.chkChargingPortRepair.UseVisualStyleBackColor = True
        '
        'chkHeadphonejackRepair
        '
        Me.chkHeadphonejackRepair.AutoSize = True
        Me.chkHeadphonejackRepair.Location = New System.Drawing.Point(34, 186)
        Me.chkHeadphonejackRepair.Name = "chkHeadphonejackRepair"
        Me.chkHeadphonejackRepair.Size = New System.Drawing.Size(184, 17)
        Me.chkHeadphonejackRepair.TabIndex = 4
        Me.chkHeadphonejackRepair.Text = "Headphone Jack Repair ($25.00)"
        Me.chkHeadphonejackRepair.UseVisualStyleBackColor = True
        '
        'chkCameraRepair
        '
        Me.chkCameraRepair.AutoSize = True
        Me.chkCameraRepair.Location = New System.Drawing.Point(34, 221)
        Me.chkCameraRepair.Name = "chkCameraRepair"
        Me.chkCameraRepair.Size = New System.Drawing.Size(138, 17)
        Me.chkCameraRepair.TabIndex = 5
        Me.chkCameraRepair.Text = "Camera Repair ($30.00)"
        Me.chkCameraRepair.UseVisualStyleBackColor = True
        '
        'chkOutterShellReplace
        '
        Me.chkOutterShellReplace.AutoSize = True
        Me.chkOutterShellReplace.Location = New System.Drawing.Point(34, 256)
        Me.chkOutterShellReplace.Name = "chkOutterShellReplace"
        Me.chkOutterShellReplace.Size = New System.Drawing.Size(189, 17)
        Me.chkOutterShellReplace.TabIndex = 6
        Me.chkOutterShellReplace.Text = "Outter Shell Replacement ($15.00)"
        Me.chkOutterShellReplace.UseVisualStyleBackColor = True
        '
        'chkPasswordRemoval
        '
        Me.chkPasswordRemoval.AutoSize = True
        Me.chkPasswordRemoval.Location = New System.Drawing.Point(34, 290)
        Me.chkPasswordRemoval.Name = "chkPasswordRemoval"
        Me.chkPasswordRemoval.Size = New System.Drawing.Size(159, 17)
        Me.chkPasswordRemoval.TabIndex = 7
        Me.chkPasswordRemoval.Text = "Password Removal ($20.00)"
        Me.chkPasswordRemoval.UseVisualStyleBackColor = True
        '
        'chkVirusRemoval
        '
        Me.chkVirusRemoval.AutoSize = True
        Me.chkVirusRemoval.Location = New System.Drawing.Point(34, 323)
        Me.chkVirusRemoval.Name = "chkVirusRemoval"
        Me.chkVirusRemoval.Size = New System.Drawing.Size(136, 17)
        Me.chkVirusRemoval.TabIndex = 8
        Me.chkVirusRemoval.Text = "Virus Removal ($25.00)"
        Me.chkVirusRemoval.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(224, 426)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Have You Came To Our Store Before"
        '
        'radNO
        '
        Me.radNO.AutoSize = True
        Me.radNO.Location = New System.Drawing.Point(140, 400)
        Me.radNO.Name = "radNO"
        Me.radNO.Size = New System.Drawing.Size(41, 17)
        Me.radNO.TabIndex = 11
        Me.radNO.TabStop = True
        Me.radNO.Text = "NO"
        Me.radNO.UseVisualStyleBackColor = True
        '
        'radYES
        '
        Me.radYES.AutoSize = True
        Me.radYES.Location = New System.Drawing.Point(70, 400)
        Me.radYES.Name = "radYES"
        Me.radYES.Size = New System.Drawing.Size(46, 17)
        Me.radYES.TabIndex = 12
        Me.radYES.TabStop = True
        Me.radYES.Text = "YES"
        Me.radYES.UseVisualStyleBackColor = True
        '
        'RepairForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 464)
        Me.Controls.Add(Me.radYES)
        Me.Controls.Add(Me.radNO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.chkVirusRemoval)
        Me.Controls.Add(Me.chkPasswordRemoval)
        Me.Controls.Add(Me.chkOutterShellReplace)
        Me.Controls.Add(Me.chkCameraRepair)
        Me.Controls.Add(Me.chkHeadphonejackRepair)
        Me.Controls.Add(Me.chkChargingPortRepair)
        Me.Controls.Add(Me.chkBatteryReplacment)
        Me.Controls.Add(Me.chkScreenRepair)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RepairForm"
        Me.Text = "Repair Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkScreenRepair As CheckBox
    Friend WithEvents chkBatteryReplacment As CheckBox
    Friend WithEvents chkChargingPortRepair As CheckBox
    Friend WithEvents chkHeadphonejackRepair As CheckBox
    Friend WithEvents chkCameraRepair As CheckBox
    Friend WithEvents chkOutterShellReplace As CheckBox
    Friend WithEvents chkPasswordRemoval As CheckBox
    Friend WithEvents chkVirusRemoval As CheckBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents radNO As RadioButton
    Friend WithEvents radYES As RadioButton
End Class
