<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HuaweiP20ProSpecs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HuaweiP20ProSpecs))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 28)
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
        Me.ListBox1.Items.AddRange(New Object() {"DESIGN ", "Device type: Smart phone", "", "OS: Android (8.1), Huawei Emotion UI", "", "Dimensions: 6.10 x 2.91 x 0.31 inches (155 x 73.9 x 7.8 mm)", "", "Weight: 6.35 oz (180 g), the average is 5.6 oz (160 g)", "", "Materials: Main body: Glass; Accents: Metal", "", "Features: Fingerprint (touch)", "", "Rugged: Water, Dust resistant IP certified: IP 67", "", "Colors: Black, Gold, Pink, Blue", "", "", "DISPLAY ", "", "Physical size: 6.1 inches", "", "Resolution: 1080 x 2240 pixels", "", "Pixel density: 408 ppi", "", "Technology: OLED", "", "Screen-to-body ratio: 82.00 %", "", "Features: Ambient light sensor, Proximity sensor", "", "", "CAMERA ", "Camera: 40 megapixels", "", "Flash: Dual LED", "", "Aperture size: F1.8", "", "Camera sensor size: 1/1.78""", "", "Pixel size: 1.55 μm", "", "Optical zoom: 3.0 x", "", "Hardware Features: Triple-camera (8-megapixel, F2.4 aperture), Autofocus (Laser, " &
                "Phase detection)", "", "Software Features: Manual focus, Digital image stabilization, Touch to focus, Fac" &
                "e detection, Self-timer, Digital zoom, Geo tagging", "", "Settings: Exposure compensation, ISO control, White balance presets, Shutter spee" &
                "d control", "", "Shooting Modes: Burst mode, High Dynamic Range mode (HDR), Panorama, Scenes", "", "Camcorder: 3840x2160 (4K), 1920x1080 (1080p HD), 1280x720 (720p HD) (960 fps)", "", "Features: Video calling, Video sharing", "", "Front-facing camera: 24 megapixels", "", "", "HARDWARE ", "System chip: HiSilicon Kirin 970", "", "Processor: Octa-core, 2360 MHz, ARM Cortex-A73 and ARM Cortex-A53, 64-bit, 10 nm", "", "Graphics processor: Mali-G72 MP12", "", "System memory: 6 GB RAM", "", "Built-in storage: 128 GB", "", "", "BATTERY", "Capacity: 4000 mAh", "", "Talk time: 25.00 hours, the average is 21 h (1247 min)", "", "Stand-by time: 22.0 days (528 hours) the average is 19 days (461 h)", "", "", "MULTIMEDIA", "Screen mirroring: Wireless screen share", "", "Music player:", "Filter by: Album, Artist, Genre, Playlists", "Features: Album art cover, Background playback", "", "Speakers: Earpiece, Dual speakers", "Additional microphone(s): for Noise cancellation", "", "", "CELLULAR", "GSM: 850, 900, 1800, 1900 MHz", "", "UMTS: 850, 900, 1700/2100, 1900, 2100 MHz", "", "Data: LTE-A Pro Cat 18 (1200/150 Mbit/s), HSDPA+ (4G) 42.2 Mbit/s, HSUPA, UMTS", "", "Nano SIM: Yes", "", "", "PHONE FEATURES", "Sensors: Accelerometer, Gyroscope, Compass, Hall (for flip covers)", "", "Notifications: Haptic feedback, Music ringtones, Vibration, Flight mode, Silent m" &
                "ode, Speakerphone", "", "Other features: Voice dialing, Voice commands, Voice recording", "", "", "CONNECTIVITY", "Bluetooth: 4.2", "", "Wi-Fi: 802.11 a, b, g, n, ac, dual-band", "", "Mobile hotspot: Yes", "", "USB: USB 3.1", "", "Connector: USB Type-C (reversible)", "", "Features: Mass storage device, USB Host", "", "Positioning: GPS, A-GPS, Glonass, BeiDou", "", "Navigation: Turn-by-turn navigation, Voice navigation", "", "Other: NFC, Infrared, VoIP, Tethering, Computer sync, OTA sync"})
        Me.ListBox1.Location = New System.Drawing.Point(8, 300)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(853, 308)
        Me.ListBox1.TabIndex = 1
        '
        'HuaweiP20ProSpecs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 615)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HuaweiP20ProSpecs"
        Me.Text = "Huawei P20 Pro Specs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
End Class
