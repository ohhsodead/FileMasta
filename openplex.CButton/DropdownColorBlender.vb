Imports System.Windows.Forms.Design
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

<ToolboxItem(False), ToolboxItemFilter("Prevent", ToolboxItemFilterType.Prevent)> _
Public Class DropdownColorBlender
    Inherits UserControl

    Private _editorService As IWindowsFormsEditorService

    Dim StartPointer As cblPointer = New cblPointer(0, Color.White, False)
    Dim EndPointer As cblPointer = New cblPointer(1, Color.White, False)
    Dim MiddlePointers As New Collection
    Dim MouseMoving As Boolean = False
    Dim CurrPointer As Integer
    Dim TopMargin As Integer = 8

    Public Sub New(ByVal editorService As IWindowsFormsEditorService)
        InitializeComponent()
        _editorService = editorService
    End Sub

    Private Sub ColorBlender_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ColorBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        ColorBox.DropDownStyle = ComboBoxStyle.DropDownList
        AddHandler ColorBox.DrawItem, AddressOf Me.ColorList_DrawItem
        If Not DesignMode Then
            ColorBox.Items.Clear()
            Dim cList As New List(Of Color)
            For Each s As String In [Enum].GetNames(GetType(KnownColor))
                If Not Color.FromName(s).IsSystemColor Then
                    cList.Add(Color.FromName(s))
                End If
            Next
            cList.Sort(AddressOf SortColors)

            For Each c As Color In cList
                ColorBox.Items.Add(c.Name)
            Next

        End If

        ColorBox.SelectedIndex = 1
    End Sub

    Private Function SortColors(ByVal x As Color, ByVal y As Color) As Integer
        'To use it first add all non-system colors to a List(Of Color), 
        'sort it by calling colors.Sort(AddressOf SortColors), 
        'then add all the list colors to the combo Items. 
        Dim huecompare As Integer = x.GetHue.CompareTo(y.GetHue)
        Dim satcompare As Integer = x.GetSaturation.CompareTo(y.GetSaturation)
        Dim brightcompare As Integer = x.GetBrightness.CompareTo(y.GetBrightness)
        If huecompare <> 0 Then
            Return huecompare
        ElseIf satcompare <> 0 Then
            Return satcompare
        ElseIf brightcompare <> 0 Then
            Return brightcompare
        Else
            Return 0
        End If
    End Function

    Private Sub panProps_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles panProps.SizeChanged
        Width = panSampleHolder.Left + panSampleHolder.Width
        Height = butApply.Top + butApply.Height
    End Sub

    Private Sub panSampleHolder_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles panSampleHolder.SizeChanged
        Width = panSampleHolder.Left + panSampleHolder.Width
        Height = butApply.Top + butApply.Height
    End Sub

#Region "Properties"

    Private _BlendColors() As Color = New Color() {Color.White, Color.Black}
    <Category("ColorBlender")> _
    <Description("Array of Colors used in ColorBlend")> _
    Public Property BlendColors() As Color()
        Get
            Return _BlendColors
        End Get
        Set(ByVal value As Color())
            _BlendColors = value
            'Invalidate()
        End Set
    End Property

    Private _BlendPositions() As Single = New Single() {0, 1}
    <Category("ColorBlender")> _
    <Description("Array of Color Positions used in ColorBlend")> _
    Public Property BlendPositions() As Single()
        Get
            Return _BlendPositions
        End Get
        Set(ByVal value As Single())
            _BlendPositions = value
            'Invalidate()
        End Set
    End Property

    Private _BarHeight As Integer = 20
    <Category("ColorBlender")> _
    <Description("Height of color blender bar")> _
    Public Property BarHeight() As Integer
        Get
            Return _BarHeight
        End Get
        Set(ByVal value As Integer)
            _BarHeight = value
            panProps.Location = New Point(10, value + 20)
            Invalidate()
        End Set
    End Property

#End Region 'Properties

#Region "Mouse Events"

    Private Sub ColorBlender_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        If e.Y > TopMargin + BarHeight - 10 And e.Y < TopMargin + BarHeight + 20 And e.X > 5 And e.X < Width - 5 Then
            'Check if the cursor is over a MiddlePointer
            Dim mOver As Integer = IsMouseOverPointer(e.X, e.Y)
            If mOver > -1 Then
                If Not CurrPointer = mOver Then
                    CurrPointer = mOver
                    ClearCurrPointer()
                    CType(CType(MiddlePointers(CurrPointer), cblPointer), cblPointer).pIsCurr = True
                    UpdateRGBnuds(CType(MiddlePointers(CurrPointer), cblPointer).pColor)
                End If

                If e.Button = Windows.Forms.MouseButtons.Left Then
                    MouseMoving = True
                ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                    MiddlePointers.Remove(CurrPointer)
                End If
            Else
                'Check if the cursor is over a Start or End Pointer
                If IsMouseOverStartPointer(e.X, e.Y) Then
                    ClearCurrPointer()
                    CurrPointer = -1
                    StartPointer.pIsCurr = True
                    UpdateRGBnuds(StartPointer.pColor)
                ElseIf IsMouseOverEndPointer(e.X, e.Y) Then
                    ClearCurrPointer()
                    CurrPointer = -1
                    EndPointer.pIsCurr = True
                    UpdateRGBnuds(EndPointer.pColor)
                Else
                    'If the cursor is not over a cblPointer then Add One
                    If e.Button = Windows.Forms.MouseButtons.Left Then
                        ClearCurrPointer()
                        MiddlePointers.Add(New cblPointer(CSng(((e.X - 10) / (Width - 20))), _
                            Color.FromArgb(tbarAlpha.Value, CInt(nudRed.Value), CInt(nudGreen.Value), CInt(nudBlue.Value)), True))
                        SortCollection(MiddlePointers, "pPos", True)
                        CurrPointer = FindCurr()
                        Invalidate()
                        MouseMoving = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ColorBlender_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If MouseMoving Then
                If e.X >= 11 And e.X <= (Width - 11) Then
                    CType(MiddlePointers(CurrPointer), cblPointer).pPos = CSng(((e.X - 10) / (Width - 20)))
                    SortCollection(MiddlePointers, "pPos", True)
                    CurrPointer = FindCurr()
                    Invalidate()
                End If
            End If
        End If
    End Sub

    Private Sub ColorBlender_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        MouseMoving = False
        SortCollection(MiddlePointers, "pPos", True)
        CurrPointer = FindCurr()
        Invalidate()
    End Sub

    Private Function IsMouseOverStartPointer(ByVal X As Integer, ByVal Y As Integer) As Boolean
        'Convert to Region.
        Using PointerRegion As New Region(BuildPointer(GetpX(0)))
            'Is the point inside the region.
            Return PointerRegion.IsVisible(X, Y)
        End Using
    End Function

    Private Function IsMouseOverEndPointer(ByVal X As Integer, ByVal Y As Integer) As Boolean
        'Convert to Region.
        Using PointerRegion As New Region(BuildPointer(GetpX(1)))
            'Is the point inside the region.
            Return PointerRegion.IsVisible(X, Y)
        End Using
    End Function

    Private Function IsMouseOverPointer(ByVal X As Integer, ByVal Y As Integer) As Integer
        If MiddlePointers IsNot Nothing Then

            For I As Integer = 1 To MiddlePointers.Count
                'Convert to Region.
                Using PointerRegion As New Region(BuildPointer(GetpX(CType(MiddlePointers(I), cblPointer).pPos)))
                    'Is the point inside the region.
                    If PointerRegion.IsVisible(X, Y) Then Return I
                End Using
            Next
            Return -1
        End If
    End Function

    Private Sub ClearCurrPointer()
        For Each ptr As cblPointer In MiddlePointers
            ptr.pIsCurr = False
        Next
        StartPointer.pIsCurr = False
        EndPointer.pIsCurr = False
    End Sub

    Private Function FindCurr() As Integer
        For i As Integer = 1 To MiddlePointers.Count
            If CType(MiddlePointers(i), cblPointer).pIsCurr Then Return i
        Next
        Return -1
    End Function
#End Region 'Mouse Events

#Region "Drawing"

    Private Sub DrawPointer(ByRef g As Graphics, ByVal bColor As Color, ByVal pt As Single, ByVal IsCurr As Boolean)
        Using cpbr As Brush = New SolidBrush(bColor)
            Using pn As New Pen(Color.LightGray, 2)
                Dim pX As Single = GetpX(pt)
                g.FillPath(cpbr, BuildPointer(pX))
                g.DrawPath(pn, BuildPointer(pX))
                pn.Width = 1
                pn.Color = Color.Black
                g.DrawPath(pn, BuildPointer(pX))
                If IsCurr Then
                    g.FillEllipse(Brushes.Red, pX + 10, TopMargin + BarHeight + 8, 10, 4)
                End If
            End Using
        End Using
    End Sub

    Private Function GetpX(ByVal pos As Single) As Single
        Return ((Width - 20) * pos) - 5
    End Function

    Private Function BuildPointer(ByVal CenterPtX As Single) As GraphicsPath
        CenterPtX += 10
        Dim gp As New GraphicsPath
        gp.AddLine(CenterPtX + 5, TopMargin + BarHeight - 3, CenterPtX + 10, TopMargin + BarHeight)
        gp.AddLine(CenterPtX + 10, TopMargin + BarHeight, CenterPtX + 10, TopMargin + BarHeight + 7)
        gp.AddLine(CenterPtX + 10, TopMargin + BarHeight + 7, CenterPtX, TopMargin + BarHeight + 7)
        gp.AddLine(CenterPtX, TopMargin + BarHeight + 7, CenterPtX, TopMargin + BarHeight)
        gp.CloseFigure()
        Return gp
    End Function

    Public Function LinearBrush(ByVal BaseRect As Rectangle, ByVal Mode As LinearGradientMode) As LinearGradientBrush
        Dim br As LinearGradientBrush = New LinearGradientBrush(New Rectangle(BaseRect.X - 1, BaseRect.Y - 1, _
            BaseRect.Width + 2, BaseRect.Height + 2), Color.AliceBlue, Color.Blue, Mode)
        Dim blend As ColorBlend = New ColorBlend()
        blend.Colors = BlendColors
        blend.Positions = BlendPositions
        br.InterpolationColors = blend
        Return br
    End Function

    Private Sub BuildABlend()
        Dim lColors As New List(Of Color)
        lColors.Add(StartPointer.pColor)
        If MiddlePointers IsNot Nothing Then
            For Each ptr As cblPointer In MiddlePointers
                lColors.Add(ptr.pColor)
            Next
        End If
        lColors.Add(EndPointer.pColor)
        BlendColors = lColors.ToArray
        lColors = Nothing

        Dim lPos As New List(Of Single)
        lPos.Add(StartPointer.pPos)
        If MiddlePointers IsNot Nothing Then
            For Each ptr As cblPointer In MiddlePointers
                lPos.Add(ptr.pPos)
            Next
        End If
        lPos.Add(EndPointer.pPos)
        BlendPositions = lPos.ToArray
        lPos = Nothing

        TheSample.ColorFillBlend = New cBlendItems(BlendColors, BlendPositions)
    End Sub

    Public Sub LoadABlend(ByVal cb As cBlendItems)

        StartPointer.pColor = cb.iColor(0)
        StartPointer.pPos = cb.iPoint(0)
        EndPointer.pColor = cb.iColor(cb.iColor.Length - 1)
        EndPointer.pPos = cb.iPoint(cb.iColor.Length - 1)

        If cb.iColor.Length > 2 Then
            For i As Integer = 1 To cb.iColor.Length - 2
                MiddlePointers.Add(New cblPointer(cb.iPoint(i), cb.iColor(i), False))
            Next
        End If
    End Sub

    Private Sub UpdatePointerColor()
        Dim CurrColor As Color = Color.FromArgb(tbarAlpha.Value, CInt(nudRed.Value), CInt(nudGreen.Value), CInt(nudBlue.Value))
        If StartPointer.pIsCurr Then
            StartPointer.pColor = CurrColor
        ElseIf EndPointer.pIsCurr Then
            EndPointer.pColor = CurrColor
        Else
            Dim curr As Integer = FindCurr()
            If curr > -1 Then CType(MiddlePointers(curr), cblPointer).pColor = CurrColor
        End If
        panCurrColor.BackColor = CurrColor

        txbCurrColor.Text = GetColorName(CurrColor)
        Invalidate()
    End Sub

    Function GetColorName(ByVal c As Color) As String
        For Each ColorName As String In [Enum].GetNames(GetType(KnownColor))
            If Not (Color.FromName(ColorName).IsSystemColor) Then
                If CInt(ColorTranslator.ToWin32(Color.FromName(ColorName))) = CInt(ColorTranslator.ToWin32(c)) Then
                    Return CStr(IIf(c.Name = "ffffffff", "White- ffffffff", String.Format("{0}- {1}", ColorName, c.Name)))
                End If
            End If
        Next
        Return CStr(IIf(c.Name = "ff7f007f", "Transparent- ff7f007f", c.Name))

    End Function
#End Region 'Drawing

#Region "Painting"

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        'Do Nothing
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        'Go through each cblPointer in the collection to get the current Color and Position arrays
        BuildABlend()

        'Create a canvas to aint on the same size as the control
        Dim bitmapBuffer As Bitmap = New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(bitmapBuffer)
        g.Clear(BackColor)
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Paint the ColorBlender Bar with the Linear Brush
        Dim barRect As Rectangle = New Rectangle(10, TopMargin, ClientSize.Width - 20, BarHeight)
        Dim br As Brush = LinearBrush(barRect, LinearGradientMode.Horizontal)
        g.FillRectangle(br, barRect)

        'Draw all the cblPointers in their Color at their Position along the Bar
        Using pn As New Pen(Color.Gray, 1)
            pn.DashStyle = DashStyle.Dash
            g.DrawLine(pn, 10, TopMargin + BarHeight + 7, ClientSize.Width - 15, TopMargin + BarHeight + 7)

            pn.Color = Color.Black
            pn.DashStyle = DashStyle.Solid

            DrawPointer(g, StartPointer.pColor, 0, StartPointer.pIsCurr)
            DrawPointer(g, EndPointer.pColor, 1, EndPointer.pIsCurr)

            If MiddlePointers IsNot Nothing Then
                For I As Integer = 1 To MiddlePointers.Count
                    DrawPointer(g, CType(MiddlePointers(I), cblPointer).pColor, _
                    CType(MiddlePointers(I), cblPointer).pPos, I = CurrPointer)
                Next
            End If

        End Using
        'Draw the entire image to the control in one shot to eliminate flicker
        e.Graphics.DrawImage(CType(bitmapBuffer.Clone, Bitmap), 0, 0)

        bitmapBuffer.Dispose()
        br.Dispose()
        g.Dispose()

        If TheSample.FillType = CButton.eFillType.GradientPath Then
            TheSample.Refresh()
        End If

    End Sub
#End Region 'Painting

#Region "SortCollection"

    Private Shared Sub SortCollection(ByVal col As Collection, _
    ByVal psSortPropertyName As String, ByVal pbAscending As Boolean, _
    Optional ByVal psKeyPropertyName As String = "")

        Dim obj As Object
        Dim i As Integer
        Dim j As Integer
        Dim iMinMaxIndex As Integer
        Dim vMinMax As Single
        Dim vValue As Single
        Dim bSortCondition As Boolean
        Dim bUseKey As Boolean = (psKeyPropertyName <> "")
        Dim sKey As String

        For i = 1 To col.Count - 1
            obj = col(i)
            vMinMax = CSng(CallByName(obj, psSortPropertyName, vbGet))
            iMinMaxIndex = i

            For j = i + 1 To col.Count
                obj = col(j)
                vValue = CSng(CallByName(obj, psSortPropertyName, vbGet))

                If (pbAscending) Then
                    bSortCondition = (vValue < vMinMax)
                Else
                    bSortCondition = (vValue > vMinMax)
                End If

                If (bSortCondition) Then
                    vMinMax = vValue
                    iMinMaxIndex = j
                End If

                obj = Nothing
            Next j

            If (iMinMaxIndex <> i) Then
                obj = col(iMinMaxIndex)

                col.Remove(iMinMaxIndex)
                If (bUseKey) Then
                    sKey = CStr(CallByName(obj, _
                       psKeyPropertyName, vbGet))
                    col.Add(obj, sKey, i)
                Else
                    col.Add(obj, , i)
                End If

                obj = Nothing
            End If

            obj = Nothing
        Next i

    End Sub

#End Region 'SortCollection

#Region "Controls"

    Private Sub ColorBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorBox.SelectedIndexChanged
        UpdateRGBnuds(Color.FromName(ColorBox.Text))
        Invalidate()
    End Sub

    Private Sub Panel7_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Panel22.Click, Panel7.Click, Panel8.Click, Panel9.Click, Panel10.Click, Panel11.Click, _
        Panel12.Click, Panel13.Click, Panel20.Click, Panel19.Click, Panel14.Click, Panel15.Click, Panel16.Click, _
        Panel17.Click, Panel21.Click, Panel18.Click, Panel28.Click, Panel27.Click, Panel26.Click, Panel25.Click, _
        Panel24.Click, Panel23.Click, Panel6.Click, Panel29.Click
        UpdateRGBnuds(CType(sender, Panel).BackColor)
        Invalidate()
    End Sub

    Private CurrSwatch As Panel
    Private Sub Panel10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Panel22.MouseEnter, Panel7.MouseEnter, Panel8.MouseEnter, Panel9.MouseEnter, Panel10.MouseEnter, Panel11.MouseEnter, _
        Panel12.MouseEnter, Panel13.MouseEnter, Panel20.MouseEnter, Panel19.MouseEnter, Panel14.MouseEnter, Panel15.MouseEnter, Panel16.MouseEnter, _
        Panel17.MouseEnter, Panel21.MouseEnter, Panel18.MouseEnter, Panel28.MouseEnter, Panel27.MouseEnter, Panel26.MouseEnter, Panel25.MouseEnter, _
        Panel24.MouseEnter, Panel23.MouseEnter, Panel6.MouseEnter, Panel29.MouseEnter
        Try
            CurrSwatch.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        Catch ex As Exception
        End Try
        CurrSwatch = CType(sender, Panel)
        CurrSwatch.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
    End Sub

    Private Sub TabControl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.MouseLeave
        Try
            CurrSwatch.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        Catch ex As Exception
        End Try

    End Sub

    Private Sub UpdateRGBnuds(ByVal c As Color)
        tbarAlpha.Value = c.A
        nudRed.Value = c.R
        nudGreen.Value = c.G
        nudBlue.Value = c.B
        UpdatePointerColor()
    End Sub

    Private Sub nud_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles nudRed.ValueChanged, nudGreen.ValueChanged, nudBlue.ValueChanged, _
        tbarAlpha.ValueChanged
        txbAlpha.Text = tbarAlpha.Value.ToString
        UpdatePointerColor()
    End Sub

    Private Sub txbAlpha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbAlpha.TextChanged
        If txbAlpha.Text <> "" Then
            Select Case CInt(txbAlpha.Text)
                Case Is < 0
                    txbAlpha.Text = "0"
                Case Is > 255
                    txbAlpha.Text = "255"
            End Select
            tbarAlpha.Value = CInt(txbAlpha.Text)
        End If
    End Sub

    Private Sub butApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butApply.Click
        _editorService.CloseDropDown()
    End Sub

    Private Sub butClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClear.Click
        StartPointer.pColor = Color.White
        EndPointer.pColor = Color.White
        MiddlePointers.Clear()
        Invalidate()
    End Sub
#End Region

#Region "ColorBox"

    Private Sub ColorList_DrawItem(ByVal sender As Object, _
        ByVal e As DrawItemEventArgs)
        ' If the item is the edit box item, then draw the rectangle white
        ' If the item is the selected item, then draw the rectangle blue
        ' Otherwise, draw the rectangle filled in beige
        If (e.State And DrawItemState.ComboBoxEdit) = DrawItemState.ComboBoxEdit Then
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        ElseIf (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds)
        Else
            e.Graphics.FillRectangle(Brushes.Beige, e.Bounds)
        End If

        ' Cast the sender object  to ComboBox type.
        Dim TheBox As ComboBox = CType(sender, ComboBox)
        Dim itemString As String = CType(TheBox.Items(e.Index), String)
        Using MyFont As Font = New Font("Tahoma", 10)
            Dim myBrush As New SolidBrush(Color.FromName(itemString))
            'Draw a Color Swatch
            e.Graphics.FillRectangle(myBrush, e.Bounds.X + 3, e.Bounds.Y + 3, 20, e.Bounds.Height - 5)
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds.X + 3, e.Bounds.Y + 3, 20, e.Bounds.Height - 5)
            ' Draw the text in the item.
            e.Graphics.DrawString(itemString, MyFont, Brushes.Black, e.Bounds.X + 25, e.Bounds.Y + 1)
            ' Draw the focus rectangle around the selected item.
            e.DrawFocusRectangle()
            myBrush.Dispose()
        End Using
    End Sub

#End Region 'ColorBox

End Class

#Region "cblPointer Class"

Class cblPointer

    Sub New(ByVal pt As Single, ByVal c As Color, ByVal IsCurr As Boolean)
        pPos = pt
        pColor = c
        pIsCurr = IsCurr
    End Sub

    Private _pPos As Single
    Public Property pPos() As Single
        Get
            Return _pPos
        End Get
        Set(ByVal value As Single)
            _pPos = value
        End Set
    End Property

    Private _pColor As Color
    Public Property pColor() As Color
        Get
            Return _pColor
        End Get
        Set(ByVal value As Color)
            _pColor = value
        End Set
    End Property

    Private _pIsCurr As Boolean
    Public Property pIsCurr() As Boolean
        Get
            Return _pIsCurr
        End Get
        Set(ByVal value As Boolean)
            _pIsCurr = value
        End Set
    End Property

End Class

#End Region 'cblPointer Class

