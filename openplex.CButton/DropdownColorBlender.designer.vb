<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DropdownColorBlender
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DropdownColorBlender))
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Me.panProps = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel29 = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.nudRed = New System.Windows.Forms.NumericUpDown
        Me.nudGreen = New System.Windows.Forms.NumericUpDown
        Me.nudBlue = New System.Windows.Forms.NumericUpDown
        Me.ColorBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txbAlpha = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbarAlpha = New System.Windows.Forms.TrackBar
        Me.txbCurrColor = New System.Windows.Forms.TextBox
        Me.panCurrColor = New System.Windows.Forms.Panel
        Me.butClear = New System.Windows.Forms.Button
        Me.butApply = New System.Windows.Forms.Button
        Me.panSampleHolder = New System.Windows.Forms.Panel
        Me.TheSample = New CButtonLib.CButton
        Me.panProps.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.nudRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.tbarAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panSampleHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'panProps
        '
        Me.panProps.Controls.Add(Me.TabControl1)
        Me.panProps.Controls.Add(Me.txbCurrColor)
        Me.panProps.Controls.Add(Me.panCurrColor)
        Me.panProps.Location = New System.Drawing.Point(3, 48)
        Me.panProps.Name = "panProps"
        Me.panProps.Size = New System.Drawing.Size(186, 115)
        Me.panProps.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(59, 18)
        Me.TabControl1.Location = New System.Drawing.Point(4, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(182, 90)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel20)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Panel22)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.Panel29)
        Me.TabPage1.Controls.Add(Me.Panel23)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Controls.Add(Me.Panel24)
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.Panel25)
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Controls.Add(Me.Panel26)
        Me.TabPage1.Controls.Add(Me.Panel11)
        Me.TabPage1.Controls.Add(Me.Panel27)
        Me.TabPage1.Controls.Add(Me.Panel12)
        Me.TabPage1.Controls.Add(Me.Panel28)
        Me.TabPage1.Controls.Add(Me.Panel13)
        Me.TabPage1.Controls.Add(Me.Panel18)
        Me.TabPage1.Controls.Add(Me.Panel19)
        Me.TabPage1.Controls.Add(Me.Panel21)
        Me.TabPage1.Controls.Add(Me.Panel14)
        Me.TabPage1.Controls.Add(Me.Panel17)
        Me.TabPage1.Controls.Add(Me.Panel15)
        Me.TabPage1.Controls.Add(Me.Panel16)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(174, 64)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Swatches"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel20.Location = New System.Drawing.Point(48, 6)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(17, 17)
        Me.Panel20.TabIndex = 35
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(6, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(17, 17)
        Me.Panel7.TabIndex = 29
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel22.Location = New System.Drawing.Point(153, 44)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(17, 17)
        Me.Panel22.TabIndex = 43
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(6, 44)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(17, 17)
        Me.Panel6.TabIndex = 30
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.Silver
        Me.Panel29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel29.Location = New System.Drawing.Point(6, 25)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(17, 17)
        Me.Panel29.TabIndex = 28
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel23.Location = New System.Drawing.Point(111, 44)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(17, 17)
        Me.Panel23.TabIndex = 44
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Red
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Location = New System.Drawing.Point(27, 6)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(17, 17)
        Me.Panel8.TabIndex = 33
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel24.Location = New System.Drawing.Point(132, 44)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(17, 17)
        Me.Panel24.TabIndex = 45
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lime
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Location = New System.Drawing.Point(90, 6)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(17, 17)
        Me.Panel9.TabIndex = 32
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel25.Location = New System.Drawing.Point(90, 44)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(17, 17)
        Me.Panel25.TabIndex = 42
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Blue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Location = New System.Drawing.Point(132, 6)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(17, 17)
        Me.Panel10.TabIndex = 31
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel26.Location = New System.Drawing.Point(69, 44)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(17, 17)
        Me.Panel26.TabIndex = 39
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Cyan
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Location = New System.Drawing.Point(111, 6)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(17, 17)
        Me.Panel11.TabIndex = 24
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel27.Location = New System.Drawing.Point(48, 44)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(17, 17)
        Me.Panel27.TabIndex = 40
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Location = New System.Drawing.Point(153, 6)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(17, 17)
        Me.Panel12.TabIndex = 23
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel28.Location = New System.Drawing.Point(27, 44)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(17, 17)
        Me.Panel28.TabIndex = 41
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Maroon
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Location = New System.Drawing.Point(27, 25)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(17, 17)
        Me.Panel13.TabIndex = 22
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Purple
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel18.Location = New System.Drawing.Point(153, 25)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(17, 17)
        Me.Panel18.TabIndex = 34
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Yellow
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel19.Location = New System.Drawing.Point(69, 6)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(17, 17)
        Me.Panel19.TabIndex = 27
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Teal
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel21.Location = New System.Drawing.Point(111, 25)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(17, 17)
        Me.Panel21.TabIndex = 36
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Location = New System.Drawing.Point(48, 25)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(17, 17)
        Me.Panel14.TabIndex = 26
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Navy
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel17.Location = New System.Drawing.Point(132, 25)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(17, 17)
        Me.Panel17.TabIndex = 38
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Location = New System.Drawing.Point(69, 25)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(17, 17)
        Me.Panel15.TabIndex = 25
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Green
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel16.Location = New System.Drawing.Point(90, 25)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(17, 17)
        Me.Panel16.TabIndex = 37
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.nudRed)
        Me.TabPage3.Controls.Add(Me.nudGreen)
        Me.TabPage3.Controls.Add(Me.nudBlue)
        Me.TabPage3.Controls.Add(Me.ColorBox)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(174, 64)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Color"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'nudRed
        '
        Me.nudRed.Location = New System.Drawing.Point(21, 41)
        Me.nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudRed.Name = "nudRed"
        Me.nudRed.Size = New System.Drawing.Size(40, 20)
        Me.nudRed.TabIndex = 8
        Me.nudRed.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nudGreen
        '
        Me.nudGreen.Location = New System.Drawing.Point(67, 41)
        Me.nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudGreen.Name = "nudGreen"
        Me.nudGreen.Size = New System.Drawing.Size(40, 20)
        Me.nudGreen.TabIndex = 8
        Me.nudGreen.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nudBlue
        '
        Me.nudBlue.Location = New System.Drawing.Point(113, 41)
        Me.nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudBlue.Name = "nudBlue"
        Me.nudBlue.Size = New System.Drawing.Size(40, 20)
        Me.nudBlue.TabIndex = 8
        Me.nudBlue.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'ColorBox
        '
        Me.ColorBox.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorBox.FormattingEnabled = True
        Me.ColorBox.Location = New System.Drawing.Point(5, 3)
        Me.ColorBox.Name = "ColorBox"
        Me.ColorBox.Size = New System.Drawing.Size(164, 24)
        Me.ColorBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Red"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(110, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Blue"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(64, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Green"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txbAlpha)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.tbarAlpha)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(174, 64)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Transparency"
        '
        'txbAlpha
        '
        Me.txbAlpha.Location = New System.Drawing.Point(115, 12)
        Me.txbAlpha.Name = "txbAlpha"
        Me.txbAlpha.Size = New System.Drawing.Size(27, 20)
        Me.txbAlpha.TabIndex = 13
        Me.txbAlpha.Text = "255"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Alpha Value"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbarAlpha
        '
        Me.tbarAlpha.AutoSize = False
        Me.tbarAlpha.BackColor = System.Drawing.Color.White
        Me.tbarAlpha.Location = New System.Drawing.Point(6, 35)
        Me.tbarAlpha.Maximum = 255
        Me.tbarAlpha.Name = "tbarAlpha"
        Me.tbarAlpha.Size = New System.Drawing.Size(164, 21)
        Me.tbarAlpha.TabIndex = 12
        Me.tbarAlpha.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbarAlpha.Value = 255
        '
        'txbCurrColor
        '
        Me.txbCurrColor.Location = New System.Drawing.Point(26, 2)
        Me.txbCurrColor.Name = "txbCurrColor"
        Me.txbCurrColor.Size = New System.Drawing.Size(156, 20)
        Me.txbCurrColor.TabIndex = 7
        '
        'panCurrColor
        '
        Me.panCurrColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panCurrColor.Location = New System.Drawing.Point(4, 2)
        Me.panCurrColor.Name = "panCurrColor"
        Me.panCurrColor.Size = New System.Drawing.Size(21, 21)
        Me.panCurrColor.TabIndex = 7
        '
        'butClear
        '
        Me.butClear.Location = New System.Drawing.Point(200, 150)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(42, 23)
        Me.butClear.TabIndex = 8
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = True
        '
        'butApply
        '
        Me.butApply.Location = New System.Drawing.Point(248, 150)
        Me.butApply.Name = "butApply"
        Me.butApply.Size = New System.Drawing.Size(42, 23)
        Me.butApply.TabIndex = 8
        Me.butApply.Text = "Apply"
        Me.butApply.UseVisualStyleBackColor = True
        '
        'panSampleHolder
        '
        Me.panSampleHolder.Controls.Add(Me.TheSample)
        Me.panSampleHolder.Location = New System.Drawing.Point(195, 44)
        Me.panSampleHolder.Name = "panSampleHolder"
        Me.panSampleHolder.Size = New System.Drawing.Size(100, 100)
        Me.panSampleHolder.TabIndex = 9
        '
        'TheSample
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.TheSample.ColorFillBlend = CBlendItems1
        Me.TheSample.Corners.All = CType(0, Int32)
        Me.TheSample.Corners.LowerLeft = CType(0, Int32)
        Me.TheSample.Corners.LowerRight = CType(0, Int32)
        Me.TheSample.Corners.UpperLeft = CType(0, Int32)
        Me.TheSample.Corners.UpperRight = CType(0, Int32)
        Me.TheSample.FillType = CButtonLib.CButton.eFillType.Solid
        Me.TheSample.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TheSample.ImageIndex = 0
        Me.TheSample.Location = New System.Drawing.Point(0, 0)
        Me.TheSample.Name = "TheSample"
        Me.TheSample.Size = New System.Drawing.Size(100, 100)
        Me.TheSample.TabIndex = 0
        Me.TheSample.Text = "CButton1"
        Me.TheSample.TextMargin = New System.Windows.Forms.Padding(0)
        '
        'DropdownColorBlender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.panSampleHolder)
        Me.Controls.Add(Me.butApply)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.panProps)
        Me.Name = "DropdownColorBlender"
        Me.Size = New System.Drawing.Size(301, 176)
        Me.panProps.ResumeLayout(False)
        Me.panProps.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.nudRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.tbarAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panSampleHolder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panProps As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudBlue As System.Windows.Forms.NumericUpDown
    Friend WithEvents txbCurrColor As System.Windows.Forms.TextBox
    Friend WithEvents panCurrColor As System.Windows.Forms.Panel
    Friend WithEvents nudGreen As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents ColorBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents tbarAlpha As System.Windows.Forms.TrackBar
    Friend WithEvents txbAlpha As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents butClear As System.Windows.Forms.Button
    Friend WithEvents butApply As System.Windows.Forms.Button
    Friend WithEvents panSampleHolder As System.Windows.Forms.Panel
    Friend WithEvents TheSample As CButtonLib.CButton

End Class
