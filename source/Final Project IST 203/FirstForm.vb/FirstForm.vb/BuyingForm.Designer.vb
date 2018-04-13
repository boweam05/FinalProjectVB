<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuyingForm
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
        Me.dgvPhones = New System.Windows.Forms.DataGridView()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSpecsSheet = New System.Windows.Forms.Button()
        CType(Me.dgvPhones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPhones
        '
        Me.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhones.Location = New System.Drawing.Point(12, 12)
        Me.dgvPhones.Name = "dgvPhones"
        Me.dgvPhones.Size = New System.Drawing.Size(400, 272)
        Me.dgvPhones.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(405, 307)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSpecsSheet
        '
        Me.btnSpecsSheet.Location = New System.Drawing.Point(68, 307)
        Me.btnSpecsSheet.Name = "btnSpecsSheet"
        Me.btnSpecsSheet.Size = New System.Drawing.Size(151, 23)
        Me.btnSpecsSheet.TabIndex = 2
        Me.btnSpecsSheet.Text = "Specifications of Phones"
        Me.btnSpecsSheet.UseVisualStyleBackColor = True
        '
        'BuyingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 355)
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

    End Sub

    Friend WithEvents dgvPhones As DataGridView
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSpecsSheet As Button
End Class
