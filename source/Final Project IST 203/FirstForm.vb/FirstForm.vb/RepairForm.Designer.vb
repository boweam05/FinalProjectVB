<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepairForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.grpRepairs = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radFastRepair = New System.Windows.Forms.RadioButton()
        Me.radSlowRepair = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpRepairs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "We Have These Repairs For You"
        '
        'chkScreenRepair
        '
        Me.chkScreenRepair.AutoSize = True
        Me.chkScreenRepair.Location = New System.Drawing.Point(18, 22)
        Me.chkScreenRepair.Name = "chkScreenRepair"
        Me.chkScreenRepair.Size = New System.Drawing.Size(136, 17)
        Me.chkScreenRepair.TabIndex = 1
        Me.chkScreenRepair.Text = "Screen Repair ($50.00)"
        Me.chkScreenRepair.UseVisualStyleBackColor = True
        '
        'chkBatteryReplacment
        '
        Me.chkBatteryReplacment.AutoSize = True
        Me.chkBatteryReplacment.Location = New System.Drawing.Point(18, 56)
        Me.chkBatteryReplacment.Name = "chkBatteryReplacment"
        Me.chkBatteryReplacment.Size = New System.Drawing.Size(167, 17)
        Me.chkBatteryReplacment.TabIndex = 2
        Me.chkBatteryReplacment.Text = "Battery Replacement ($30.00)"
        Me.chkBatteryReplacment.UseVisualStyleBackColor = True
        '
        'chkChargingPortRepair
        '
        Me.chkChargingPortRepair.AutoSize = True
        Me.chkChargingPortRepair.Location = New System.Drawing.Point(18, 91)
        Me.chkChargingPortRepair.Name = "chkChargingPortRepair"
        Me.chkChargingPortRepair.Size = New System.Drawing.Size(166, 17)
        Me.chkChargingPortRepair.TabIndex = 3
        Me.chkChargingPortRepair.Text = "Charging Port Repair ($35.00)"
        Me.chkChargingPortRepair.UseVisualStyleBackColor = True
        '
        'chkHeadphonejackRepair
        '
        Me.chkHeadphonejackRepair.AutoSize = True
        Me.chkHeadphonejackRepair.Location = New System.Drawing.Point(18, 125)
        Me.chkHeadphonejackRepair.Name = "chkHeadphonejackRepair"
        Me.chkHeadphonejackRepair.Size = New System.Drawing.Size(184, 17)
        Me.chkHeadphonejackRepair.TabIndex = 4
        Me.chkHeadphonejackRepair.Text = "Headphone Jack Repair ($25.00)"
        Me.chkHeadphonejackRepair.UseVisualStyleBackColor = True
        '
        'chkCameraRepair
        '
        Me.chkCameraRepair.AutoSize = True
        Me.chkCameraRepair.Location = New System.Drawing.Point(18, 160)
        Me.chkCameraRepair.Name = "chkCameraRepair"
        Me.chkCameraRepair.Size = New System.Drawing.Size(138, 17)
        Me.chkCameraRepair.TabIndex = 5
        Me.chkCameraRepair.Text = "Camera Repair ($30.00)"
        Me.chkCameraRepair.UseVisualStyleBackColor = True
        '
        'chkOutterShellReplace
        '
        Me.chkOutterShellReplace.AutoSize = True
        Me.chkOutterShellReplace.Location = New System.Drawing.Point(18, 195)
        Me.chkOutterShellReplace.Name = "chkOutterShellReplace"
        Me.chkOutterShellReplace.Size = New System.Drawing.Size(189, 17)
        Me.chkOutterShellReplace.TabIndex = 6
        Me.chkOutterShellReplace.Text = "Outter Shell Replacement ($15.00)"
        Me.chkOutterShellReplace.UseVisualStyleBackColor = True
        '
        'chkPasswordRemoval
        '
        Me.chkPasswordRemoval.AutoSize = True
        Me.chkPasswordRemoval.Location = New System.Drawing.Point(18, 229)
        Me.chkPasswordRemoval.Name = "chkPasswordRemoval"
        Me.chkPasswordRemoval.Size = New System.Drawing.Size(159, 17)
        Me.chkPasswordRemoval.TabIndex = 7
        Me.chkPasswordRemoval.Text = "Password Removal ($20.00)"
        Me.chkPasswordRemoval.UseVisualStyleBackColor = True
        '
        'chkVirusRemoval
        '
        Me.chkVirusRemoval.AutoSize = True
        Me.chkVirusRemoval.Location = New System.Drawing.Point(18, 262)
        Me.chkVirusRemoval.Name = "chkVirusRemoval"
        Me.chkVirusRemoval.Size = New System.Drawing.Size(136, 17)
        Me.chkVirusRemoval.TabIndex = 8
        Me.chkVirusRemoval.Text = "Virus Removal ($25.00)"
        Me.chkVirusRemoval.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(224, 544)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Have You Came To Our Store Before"
        '
        'radNO
        '
        Me.radNO.AutoSize = True
        Me.radNO.Location = New System.Drawing.Point(87, 19)
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
        Me.radYES.Location = New System.Drawing.Point(17, 19)
        Me.radYES.Name = "radYES"
        Me.radYES.Size = New System.Drawing.Size(46, 17)
        Me.radYES.TabIndex = 12
        Me.radYES.TabStop = True
        Me.radYES.Text = "YES"
        Me.radYES.UseVisualStyleBackColor = True
        '
        'grpRepairs
        '
        Me.grpRepairs.Controls.Add(Me.chkScreenRepair)
        Me.grpRepairs.Controls.Add(Me.chkBatteryReplacment)
        Me.grpRepairs.Controls.Add(Me.chkChargingPortRepair)
        Me.grpRepairs.Controls.Add(Me.chkHeadphonejackRepair)
        Me.grpRepairs.Controls.Add(Me.chkCameraRepair)
        Me.grpRepairs.Controls.Add(Me.chkVirusRemoval)
        Me.grpRepairs.Controls.Add(Me.chkOutterShellReplace)
        Me.grpRepairs.Controls.Add(Me.chkPasswordRemoval)
        Me.grpRepairs.Location = New System.Drawing.Point(12, 71)
        Me.grpRepairs.Name = "grpRepairs"
        Me.grpRepairs.Size = New System.Drawing.Size(287, 299)
        Me.grpRepairs.TabIndex = 13
        Me.grpRepairs.TabStop = False
        Me.grpRepairs.Text = "Please Select Atleast One Repair"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Please Select A Repair Speed."
        '
        'radFastRepair
        '
        Me.radFastRepair.AutoSize = True
        Me.radFastRepair.Location = New System.Drawing.Point(13, 25)
        Me.radFastRepair.Name = "radFastRepair"
        Me.radFastRepair.Size = New System.Drawing.Size(118, 17)
        Me.radFastRepair.TabIndex = 15
        Me.radFastRepair.TabStop = True
        Me.radFastRepair.Text = "Fast Repair = $7.00"
        Me.radFastRepair.UseVisualStyleBackColor = True
        '
        'radSlowRepair
        '
        Me.radSlowRepair.AutoSize = True
        Me.radSlowRepair.Location = New System.Drawing.Point(13, 48)
        Me.radSlowRepair.Name = "radSlowRepair"
        Me.radSlowRepair.Size = New System.Drawing.Size(122, 17)
        Me.radSlowRepair.TabIndex = 16
        Me.radSlowRepair.TabStop = True
        Me.radSlowRepair.Text = "Slow Repair = FREE"
        Me.radSlowRepair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radYES)
        Me.GroupBox1.Controls.Add(Me.radNO)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 55)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFastRepair)
        Me.GroupBox2.Controls.Add(Me.radSlowRepair)
        Me.GroupBox2.Location = New System.Drawing.Point(71, 477)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 87)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'RepairForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 579)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpRepairs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RepairForm"
        Me.Text = "Repair Form"
        Me.grpRepairs.ResumeLayout(False)
        Me.grpRepairs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpRepairs As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents radFastRepair As RadioButton
    Friend WithEvents radSlowRepair As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents errProvider As ErrorProvider
End Class
