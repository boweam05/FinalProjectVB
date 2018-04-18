<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuyingForm
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
        Me.dgvPhones = New System.Windows.Forms.DataGridView()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSpecsSheet = New System.Windows.Forms.Button()
        Me.radSamsungGalaxyS8Plus = New System.Windows.Forms.RadioButton()
        Me.radiPhone8Plus = New System.Windows.Forms.RadioButton()
        Me.radHuaweiP20 = New System.Windows.Forms.RadioButton()
        Me.radSonyExperiaX72 = New System.Windows.Forms.RadioButton()
        Me.radGooglePixel2 = New System.Windows.Forms.RadioButton()
        Me.radiPhone8 = New System.Windows.Forms.RadioButton()
        Me.radSamsungGalaxyS8 = New System.Windows.Forms.RadioButton()
        Me.radLGV30 = New System.Windows.Forms.RadioButton()
        Me.radSamsungGalaxyNote8 = New System.Windows.Forms.RadioButton()
        Me.radiPhoneX = New System.Windows.Forms.RadioButton()
        Me.radSamsungGalaxyS9Plus = New System.Windows.Forms.RadioButton()
        Me.radHuaweiP20Pro = New System.Windows.Forms.RadioButton()
        Me.radSamsungGalaxyS9 = New System.Windows.Forms.RadioButton()
        Me.radGooglePixelXL2 = New System.Windows.Forms.RadioButton()
        Me.radHuaweiMate10Pro = New System.Windows.Forms.RadioButton()
        Me.txtFirmware = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddPhone = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvPhones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPhones
        '
        Me.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhones.Location = New System.Drawing.Point(12, 12)
        Me.dgvPhones.Name = "dgvPhones"
        Me.dgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhones.Size = New System.Drawing.Size(641, 272)
        Me.dgvPhones.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(550, 610)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(103, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSpecsSheet
        '
        Me.btnSpecsSheet.Location = New System.Drawing.Point(15, 297)
        Me.btnSpecsSheet.Name = "btnSpecsSheet"
        Me.btnSpecsSheet.Size = New System.Drawing.Size(151, 23)
        Me.btnSpecsSheet.TabIndex = 2
        Me.btnSpecsSheet.Text = "Specifications of Phones"
        Me.btnSpecsSheet.UseVisualStyleBackColor = True
        '
        'radSamsungGalaxyS8Plus
        '
        Me.radSamsungGalaxyS8Plus.AutoSize = True
        Me.radSamsungGalaxyS8Plus.Location = New System.Drawing.Point(350, 496)
        Me.radSamsungGalaxyS8Plus.Name = "radSamsungGalaxyS8Plus"
        Me.radSamsungGalaxyS8Plus.Size = New System.Drawing.Size(143, 17)
        Me.radSamsungGalaxyS8Plus.TabIndex = 3
        Me.radSamsungGalaxyS8Plus.TabStop = True
        Me.radSamsungGalaxyS8Plus.Text = "Samsung Galaxy S8 Plus"
        Me.radSamsungGalaxyS8Plus.UseVisualStyleBackColor = True
        '
        'radiPhone8Plus
        '
        Me.radiPhone8Plus.AutoSize = True
        Me.radiPhone8Plus.Location = New System.Drawing.Point(350, 462)
        Me.radiPhone8Plus.Name = "radiPhone8Plus"
        Me.radiPhone8Plus.Size = New System.Drawing.Size(90, 17)
        Me.radiPhone8Plus.TabIndex = 4
        Me.radiPhone8Plus.TabStop = True
        Me.radiPhone8Plus.Text = "iPhone 8 Plus"
        Me.radiPhone8Plus.UseVisualStyleBackColor = True
        '
        'radHuaweiP20
        '
        Me.radHuaweiP20.AutoSize = True
        Me.radHuaweiP20.Location = New System.Drawing.Point(350, 428)
        Me.radHuaweiP20.Name = "radHuaweiP20"
        Me.radHuaweiP20.Size = New System.Drawing.Size(83, 17)
        Me.radHuaweiP20.TabIndex = 5
        Me.radHuaweiP20.TabStop = True
        Me.radHuaweiP20.Text = "Huawei P20"
        Me.radHuaweiP20.UseVisualStyleBackColor = True
        '
        'radSonyExperiaX72
        '
        Me.radSonyExperiaX72.AutoSize = True
        Me.radSonyExperiaX72.Location = New System.Drawing.Point(203, 598)
        Me.radSonyExperiaX72.Name = "radSonyExperiaX72"
        Me.radSonyExperiaX72.Size = New System.Drawing.Size(104, 17)
        Me.radSonyExperiaX72.TabIndex = 6
        Me.radSonyExperiaX72.TabStop = True
        Me.radSonyExperiaX72.Text = "Sony Xperia X72"
        Me.radSonyExperiaX72.UseVisualStyleBackColor = True
        '
        'radGooglePixel2
        '
        Me.radGooglePixel2.AutoSize = True
        Me.radGooglePixel2.Location = New System.Drawing.Point(203, 566)
        Me.radGooglePixel2.Name = "radGooglePixel2"
        Me.radGooglePixel2.Size = New System.Drawing.Size(93, 17)
        Me.radGooglePixel2.TabIndex = 7
        Me.radGooglePixel2.TabStop = True
        Me.radGooglePixel2.Text = "Google Pixel 2"
        Me.radGooglePixel2.UseVisualStyleBackColor = True
        '
        'radiPhone8
        '
        Me.radiPhone8.AutoSize = True
        Me.radiPhone8.Location = New System.Drawing.Point(203, 530)
        Me.radiPhone8.Name = "radiPhone8"
        Me.radiPhone8.Size = New System.Drawing.Size(67, 17)
        Me.radiPhone8.TabIndex = 8
        Me.radiPhone8.TabStop = True
        Me.radiPhone8.Text = "iPhone 8"
        Me.radiPhone8.UseVisualStyleBackColor = True
        '
        'radSamsungGalaxyS8
        '
        Me.radSamsungGalaxyS8.AutoSize = True
        Me.radSamsungGalaxyS8.Location = New System.Drawing.Point(203, 496)
        Me.radSamsungGalaxyS8.Name = "radSamsungGalaxyS8"
        Me.radSamsungGalaxyS8.Size = New System.Drawing.Size(120, 17)
        Me.radSamsungGalaxyS8.TabIndex = 9
        Me.radSamsungGalaxyS8.TabStop = True
        Me.radSamsungGalaxyS8.Text = "Samsung Galaxy S8"
        Me.radSamsungGalaxyS8.UseVisualStyleBackColor = True
        '
        'radLGV30
        '
        Me.radLGV30.AutoSize = True
        Me.radLGV30.Location = New System.Drawing.Point(203, 462)
        Me.radLGV30.Name = "radLGV30"
        Me.radLGV30.Size = New System.Drawing.Size(64, 17)
        Me.radLGV30.TabIndex = 10
        Me.radLGV30.TabStop = True
        Me.radLGV30.Text = "LG V30 "
        Me.radLGV30.UseVisualStyleBackColor = True
        '
        'radSamsungGalaxyNote8
        '
        Me.radSamsungGalaxyNote8.AutoSize = True
        Me.radSamsungGalaxyNote8.Location = New System.Drawing.Point(203, 428)
        Me.radSamsungGalaxyNote8.Name = "radSamsungGalaxyNote8"
        Me.radSamsungGalaxyNote8.Size = New System.Drawing.Size(142, 17)
        Me.radSamsungGalaxyNote8.TabIndex = 11
        Me.radSamsungGalaxyNote8.TabStop = True
        Me.radSamsungGalaxyNote8.Text = "Samsung Galaxy Note 8 "
        Me.radSamsungGalaxyNote8.UseVisualStyleBackColor = True
        '
        'radiPhoneX
        '
        Me.radiPhoneX.AutoSize = True
        Me.radiPhoneX.Location = New System.Drawing.Point(38, 428)
        Me.radiPhoneX.Name = "radiPhoneX"
        Me.radiPhoneX.Size = New System.Drawing.Size(68, 17)
        Me.radiPhoneX.TabIndex = 12
        Me.radiPhoneX.TabStop = True
        Me.radiPhoneX.Text = "iPhone X"
        Me.radiPhoneX.UseVisualStyleBackColor = True
        '
        'radSamsungGalaxyS9Plus
        '
        Me.radSamsungGalaxyS9Plus.AutoSize = True
        Me.radSamsungGalaxyS9Plus.Location = New System.Drawing.Point(38, 462)
        Me.radSamsungGalaxyS9Plus.Name = "radSamsungGalaxyS9Plus"
        Me.radSamsungGalaxyS9Plus.Size = New System.Drawing.Size(143, 17)
        Me.radSamsungGalaxyS9Plus.TabIndex = 13
        Me.radSamsungGalaxyS9Plus.TabStop = True
        Me.radSamsungGalaxyS9Plus.Text = "Samsung Galaxy S9 Plus"
        Me.radSamsungGalaxyS9Plus.UseVisualStyleBackColor = True
        '
        'radHuaweiP20Pro
        '
        Me.radHuaweiP20Pro.AutoSize = True
        Me.radHuaweiP20Pro.Location = New System.Drawing.Point(38, 496)
        Me.radHuaweiP20Pro.Name = "radHuaweiP20Pro"
        Me.radHuaweiP20Pro.Size = New System.Drawing.Size(102, 17)
        Me.radHuaweiP20Pro.TabIndex = 14
        Me.radHuaweiP20Pro.TabStop = True
        Me.radHuaweiP20Pro.Text = "Huawei P20 Pro"
        Me.radHuaweiP20Pro.UseVisualStyleBackColor = True
        '
        'radSamsungGalaxyS9
        '
        Me.radSamsungGalaxyS9.AutoSize = True
        Me.radSamsungGalaxyS9.Location = New System.Drawing.Point(38, 530)
        Me.radSamsungGalaxyS9.Name = "radSamsungGalaxyS9"
        Me.radSamsungGalaxyS9.Size = New System.Drawing.Size(123, 17)
        Me.radSamsungGalaxyS9.TabIndex = 15
        Me.radSamsungGalaxyS9.TabStop = True
        Me.radSamsungGalaxyS9.Text = "Samsung Galaxy S9 "
        Me.radSamsungGalaxyS9.UseVisualStyleBackColor = True
        '
        'radGooglePixelXL2
        '
        Me.radGooglePixelXL2.AutoSize = True
        Me.radGooglePixelXL2.Location = New System.Drawing.Point(38, 566)
        Me.radGooglePixelXL2.Name = "radGooglePixelXL2"
        Me.radGooglePixelXL2.Size = New System.Drawing.Size(109, 17)
        Me.radGooglePixelXL2.TabIndex = 16
        Me.radGooglePixelXL2.TabStop = True
        Me.radGooglePixelXL2.Text = "Google Pixel XL 2"
        Me.radGooglePixelXL2.UseVisualStyleBackColor = True
        '
        'radHuaweiMate10Pro
        '
        Me.radHuaweiMate10Pro.AutoSize = True
        Me.radHuaweiMate10Pro.Location = New System.Drawing.Point(38, 598)
        Me.radHuaweiMate10Pro.Name = "radHuaweiMate10Pro"
        Me.radHuaweiMate10Pro.Size = New System.Drawing.Size(122, 17)
        Me.radHuaweiMate10Pro.TabIndex = 17
        Me.radHuaweiMate10Pro.TabStop = True
        Me.radHuaweiMate10Pro.Text = "Huawei Mate 10 Pro"
        Me.radHuaweiMate10Pro.UseVisualStyleBackColor = True
        '
        'txtFirmware
        '
        Me.txtFirmware.Location = New System.Drawing.Point(375, 378)
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.Size = New System.Drawing.Size(157, 20)
        Me.txtFirmware.TabIndex = 18
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(375, 341)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(157, 20)
        Me.txtMake.TabIndex = 19
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(375, 300)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 20)
        Me.txtName.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Make:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Firmware:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Name: "
        '
        'btnAddPhone
        '
        Me.btnAddPhone.Location = New System.Drawing.Point(546, 298)
        Me.btnAddPhone.Name = "btnAddPhone"
        Me.btnAddPhone.Size = New System.Drawing.Size(107, 23)
        Me.btnAddPhone.TabIndex = 24
        Me.btnAddPhone.Text = "Add Phone"
        Me.btnAddPhone.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(546, 339)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 23)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete Phone"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(546, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear Textboxes"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'BuyingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 645)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddPhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.txtFirmware)
        Me.Controls.Add(Me.radHuaweiMate10Pro)
        Me.Controls.Add(Me.radGooglePixelXL2)
        Me.Controls.Add(Me.radSamsungGalaxyS9)
        Me.Controls.Add(Me.radHuaweiP20Pro)
        Me.Controls.Add(Me.radSamsungGalaxyS9Plus)
        Me.Controls.Add(Me.radiPhoneX)
        Me.Controls.Add(Me.radSamsungGalaxyNote8)
        Me.Controls.Add(Me.radLGV30)
        Me.Controls.Add(Me.radSamsungGalaxyS8)
        Me.Controls.Add(Me.radiPhone8)
        Me.Controls.Add(Me.radGooglePixel2)
        Me.Controls.Add(Me.radSonyExperiaX72)
        Me.Controls.Add(Me.radHuaweiP20)
        Me.Controls.Add(Me.radiPhone8Plus)
        Me.Controls.Add(Me.radSamsungGalaxyS8Plus)
        Me.Controls.Add(Me.btnSpecsSheet)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.dgvPhones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuyingForm"
        Me.Text = "Buying Form"
        CType(Me.dgvPhones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPhones As DataGridView
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSpecsSheet As Button
    Friend WithEvents radSamsungGalaxyS8Plus As RadioButton
    Friend WithEvents radiPhone8Plus As RadioButton
    Friend WithEvents radHuaweiP20 As RadioButton
    Friend WithEvents radSonyExperiaX72 As RadioButton
    Friend WithEvents radGooglePixel2 As RadioButton
    Friend WithEvents radiPhone8 As RadioButton
    Friend WithEvents radSamsungGalaxyS8 As RadioButton
    Friend WithEvents radLGV30 As RadioButton
    Friend WithEvents radSamsungGalaxyNote8 As RadioButton
    Friend WithEvents radiPhoneX As RadioButton
    Friend WithEvents radSamsungGalaxyS9Plus As RadioButton
    Friend WithEvents radHuaweiP20Pro As RadioButton
    Friend WithEvents radSamsungGalaxyS9 As RadioButton
    Friend WithEvents radGooglePixelXL2 As RadioButton
    Friend WithEvents radHuaweiMate10Pro As RadioButton
    Friend WithEvents txtFirmware As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddPhone As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
End Class
