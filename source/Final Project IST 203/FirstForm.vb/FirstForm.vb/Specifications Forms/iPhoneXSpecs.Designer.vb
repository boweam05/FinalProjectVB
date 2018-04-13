<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iPhoneXSpecs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iPhoneXSpecs))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"DESIGN", "Device type:   Smart phone", "", "OS:   iOS (11.x)", "", "Dimensions:   5.65 x 2.79 x 0.30 inches (143.6 x 70.9 x 7.7 mm)", "", "Weight:   6.14 oz (174 g), the average is 5.6 oz (160 g)", "", "Materials:   Main body: Glass; Accents: Stainless steel", "", "Rugged:   Water, Dust resistant IP certified:  IP 67", "", "Colors:   Gray, Silver", "", "", "DISPLAY ", "Physical size:   5.8 inches", "", "Resolution:   1125 x 2436 pixels", "", "Pixel density:   459 ppi", "", "Technology:   OLED", "", "Screen-to-body ratio:   82.35 %", "", "Peak brightness:   625 cd/m2 (nit)", "", "Features:   HDR video support, Pressure-sensitive, Oleophobic coating, Ambient li" &
                "ght sensor, Proximity sensor", "", "", "CAMERA ", "Camera:   Popup12 megapixels", "", "Flash:   Quad LED", "", "Aperture size: F1.8", "", "Pixel size:   1.22 μm", "", "Optical zoom:   2.0 x", "", "Hardware Features:   Dual-camera (12-megapixel, F2.4 aperture), Sapphire crystal " &
                "lens cover, Optical image stabilization, Autofocus, Back-illuminated sensor (BSI" &
                ")", "", "Software Features:   RAW image capture, Touch to focus, Face detection, Self-time" &
                "r, Digital zoom, Geo tagging", "", "Settings:   Exposure compensation, ISO control, White balance presets", "", "Shooting Modes:  PopupBurst mode, High Dynamic Range mode (HDR), Panorama (up to " &
                "63 megapixels)", "", "Camcorder:  3840x2160 (4K) (60 fps), 1920x1080 (1080p HD) (240 fps), 1280x720 (72" &
                "0p HD) (30 fps)", "", "Features:  Optical image stabilization, Time-lapse video, Continuous autofocus, V" &
                "ideo light, Video calling, Video sharing", "", "Front-facing camera:  7 megapixels", "", "Features:  High Dynamic Range mode (HDR)", "", "", "HARDWARE", "System chip:   Apple A11 Bionic APL1W72", "", "Processor:  Hexa-core, 2390 MHz, 64-bit, 10 nm", "", "Graphics processor:  Apple 3-core GPU", "", "System memory:  3 GB RAM", "", "Built-in storage:  [+]256 GB", "", "", "BATTERY ", "Capacity:  2716 mAh", "", "Wireless charging:  Built-in (Qi)", "", "Music playback:  60.00 hours", "", "Video playback:  13.00 hours", "", "", "MULTIMEDIA", "Music player:", "Filter by:   Album, Artist, Genre, Playlists", "", "Features:  Album art cover, Background playback", "Speakers:  Earpiece, Dual speakers", "", "Additional microphone(s): Yes", "", "", "CELLULAR ", "GSM:  850, 900, 1800, 1900 MHz", "", "UMTS:  850, 900, 1700/2100, 1900, 2100 MHz", "", "LTE (FDD):  Bands 1, 2, 3, 4, 5, 7, 8, 12, 13, 17, 18, 19, 20, 25, 26, 28, 29, 30" &
                ", 66", "", "LTE (TDD):  Bands 38, 39, 40, 41", "", "Data:  LTE-A, HSPA, HSUPA, UMTS", "", "Nano SIM:  Yes", "", "VoLTE:  Yes", "", "", "PHONE FEATURES ", "Sensors:  Accelerometer, Gyroscope, Compass, Barometer", "", "Notifications:  Haptic feedback", "", "Hearing aid compatibility:  M3, T4", "", "Other features:  Voice dialing, Voice commands, Voice recording, TTY/TDD"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 295)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(853, 308)
        Me.ListBox1.TabIndex = 1
        '
        'iPhoneXSpecs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 615)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "iPhoneXSpecs"
        Me.Text = "iPhone X Specs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
End Class
