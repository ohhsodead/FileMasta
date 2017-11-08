Imports System.Windows.Forms.Design.Behavior
Imports System.Drawing.Drawing2D
Imports System.ComponentModel.Design
Imports System.ComponentModel

Public Class CornerGlyph
	Inherits Glyph

#Region "Declarations"

	Private relatedControl As CButton
	Private behaviorSvc As System.Windows.Forms.Design.Behavior.BehaviorService
	Private selectionSvc As ISelectionService = Nothing
	Private relatedDesigner As IDesigner = Nothing
	Private CornAdorner As Adorner
	Private boxFillColor As Brush = New SolidBrush(Color.FromArgb(120, Color.White))

	Public CornerTrack As Rectangle
	Public maxCorner As Integer

	Enum eCorner
		All
		UpperLeft
		UpperRight
		LowerLeft
		LowerRight
	End Enum
	Public Property WhatCorner As eCorner

#End Region

#Region "New"

	Public Sub New(
		ByVal behaviorService As System.Windows.Forms.Design.Behavior.BehaviorService,
		ByVal control As CButton,
		ByVal selectionService As ISelectionService, _
		ByVal relatedDesigner As IDesigner, _
		ByVal myAdorner As Adorner,
		ByVal whatCorner As eCorner)

		MyBase.New(New CornBehavior(relatedDesigner, whatCorner))
		' Cache references for convenience. 
		Me.behaviorSvc = behaviorService
		Me.selectionSvc = selectionService
		Me.relatedDesigner = relatedDesigner
		Me.CornAdorner = myAdorner
		Me.WhatCorner = whatCorner

		' Cache a reference to the control being designed. 
		Me.relatedControl = CType(Me.relatedDesigner.Component, CButton)

		AddHandler Me.relatedControl.Resize, AddressOf relatedControl_Resize

	End Sub

	Private Sub relatedControl_Resize( _
ByVal sender As Object, _
ByVal e As EventArgs)

		SizeCornerTrack()
		Me.relatedControl.Refresh()
		Me.CornAdorner.Invalidate(Bounds)
	End Sub

#End Region

#Region "Methods"

	Public Function GetCorn() As Rectangle
		Dim edge As Point = behaviorSvc.ControlToAdornerWindow(relatedControl)
		Dim xOffset As Integer
		Dim cWidth As Integer
		If relatedControl.Width \ 2 < 30 Then
			xOffset = relatedControl.Width \ 2 - 30
			cWidth = 30
		Else
			xOffset = 0
			cWidth = Math.Min(relatedControl.Width \ 2, 80)
		End If

		Select Case WhatCorner
			Case eCorner.All
				cWidth = Math.Min(relatedControl.Width, 100)
				Return New Rectangle(edge.X + ((relatedControl.Width - cWidth) \ 2), edge.Y + relatedControl.Height \ 2 - 5, cWidth, 10)
			Case eCorner.UpperLeft
				Return New Rectangle(edge.X + xOffset, edge.Y - 15, cWidth, 10)
			Case eCorner.UpperRight
				Return New Rectangle(edge.X - xOffset + relatedControl.Width - cWidth, edge.Y - 15, cWidth, 10)
			Case eCorner.LowerLeft
				Return New Rectangle(edge.X + xOffset, edge.Y + relatedControl.Height + 5, cWidth, 10)
			Case eCorner.LowerRight
				Return New Rectangle(edge.X - xOffset + relatedControl.Width - cWidth, edge.Y + relatedControl.Height + 5, cWidth, 10)

		End Select

	End Function

	Public Sub SizeCornerTrack()

		Dim edge As Point = behaviorSvc.ControlToAdornerWindow(relatedControl)
		CornerTrack = GetCorn()
		maxCorner = CInt(Math.Max(CLng(Math.Min(relatedControl.ButtonArea.Width, relatedControl.ButtonArea.Height)) \ 2, 0))
		If maxCorner > 0 Then

			If WhatCorner = eCorner.All Then
				If relatedControl.Corners.All <> -1 AndAlso relatedControl.Corners.All > maxCorner Then relatedControl.Corners.All = maxCorner
			Else
				If GetValue() > maxCorner Then SetValue(maxCorner)
			End If
		End If

	End Sub

	Private Function GetValue() As Integer
		Select Case WhatCorner
			Case eCorner.All
				Return relatedControl.Corners.All
			Case eCorner.UpperLeft
				Return relatedControl.Corners.UpperLeft
			Case eCorner.UpperRight
				Return relatedControl.Corners.UpperRight
			Case eCorner.LowerLeft
				Return relatedControl.Corners.LowerLeft
			Case eCorner.LowerRight
				Return relatedControl.Corners.LowerRight

		End Select
	End Function

	Private Sub SetValue(val As Integer)
		Select Case WhatCorner
			Case eCorner.All
				relatedControl.Corners.All = val
			Case eCorner.UpperLeft
				relatedControl.Corners.UpperLeft = val
			Case eCorner.UpperRight
				relatedControl.Corners.UpperRight = val
			Case eCorner.LowerLeft
				relatedControl.Corners.LowerLeft = val
			Case eCorner.LowerRight
				relatedControl.Corners.LowerRight = val
		End Select
	End Sub


#End Region

#Region "Overrides"

	Public Overrides ReadOnly Property Bounds() As Rectangle
		Get
			'SizeCornerTrack()
			Return CornerTrack
		End Get

	End Property

	Public Overrides Function GetHitTest(ByVal p As Point) As Cursor

		If Object.ReferenceEquals(Me.selectionSvc.PrimarySelection, Me.relatedControl) AndAlso
			DirectCast(DirectCast(relatedDesigner, CButtonDesigner).ChooseAdorner.Glyphs(0), ChooseGlyph).chooseWhat = ChooseGlyph.eChooseWhat.Corner Then

			Dim box As Rectangle = New Rectangle(CornerTrack.X + GetPos(), CornerTrack.Y, 10, 10)
			If DirectCast(Me.Behavior, CornBehavior)._dragging Then box.Inflate(10, 10)
			If box.Contains(p) Then
				Return Cursors.VSplit
			End If
		End If

		Return Nothing

	End Function


	Public Overrides Sub Paint(ByVal pe As PaintEventArgs)

		If Object.ReferenceEquals(Me.selectionSvc.PrimarySelection, Me.relatedControl) AndAlso
			DirectCast(DirectCast(relatedDesigner, CButtonDesigner).ChooseAdorner.Glyphs(0), ChooseGlyph).chooseWhat = ChooseGlyph.eChooseWhat.Corner Then

			Using pn As New Pen(Brushes.DarkGray, 1) With {.DashStyle = Drawing2D.DashStyle.Solid}
				Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

				SizeCornerTrack()
				Dim pos As Integer = GetPos()

				pe.Graphics.FillRectangle(Brushes.CornflowerBlue, New Rectangle(CornerTrack.X + pos, CornerTrack.Y, 10, 10))
				pn.Color = Color.White
				pe.Graphics.DrawRectangle(pn, New Rectangle(CornerTrack.X + pos, CornerTrack.Y, 9, 9))

			End Using
		End If

	End Sub

	Private Function GetPos() As Integer
		Select Case WhatCorner
			Case eCorner.LowerRight, eCorner.UpperRight
				Return CInt((CornerTrack.Width - 10) * ((maxCorner - GetValue()) / maxCorner))
			Case eCorner.LowerLeft, eCorner.UpperLeft, eCorner.All
				Return CInt((CornerTrack.Width - 10) * ((GetValue()) / maxCorner))
		End Select
	End Function
#End Region



	Class CornBehavior
		Inherits Behavior

#Region "Declarations"

		Private relatedDesigner As IDesigner = Nothing
		Private relatedControl As CButton = Nothing

		Private sngSliderPos As Single
		Private _dragStart As Point
		Public _dragging As Boolean
		Private whatCorner As eCorner

#End Region

#Region "New"

		Friend Sub New(ByVal relatedDesigner As IDesigner, ByVal whatCorner As eCorner)
			Me.relatedDesigner = relatedDesigner
			Me.relatedControl = CType(relatedDesigner.Component, CButton)
			Me.whatCorner = whatCorner
		End Sub

#End Region

#Region "Overrides"

		Public Overrides Function OnMouseDown(g As Glyph, button As MouseButtons, mouseLoc As Point) As Boolean

			Dim pGlyph As CornerGlyph = DirectCast(g, CornerGlyph)
			Select Case whatCorner
				Case eCorner.LowerRight, eCorner.UpperRight
					sngSliderPos = CInt((pGlyph.CornerTrack.Width - 10) * ((pGlyph.maxCorner - pGlyph.GetValue) / pGlyph.maxCorner))

				Case eCorner.LowerLeft, eCorner.UpperLeft, eCorner.All
					sngSliderPos = CInt((pGlyph.CornerTrack.Width - 10) * ((pGlyph.GetValue) / pGlyph.maxCorner))
			End Select

			_dragStart = mouseLoc
			_dragging = True

			Return True
		End Function

		Public Overrides Function OnMouseMove(g As Glyph, button As MouseButtons, mouseLoc As Point) As Boolean

			If button <> MouseButtons.Left Then _dragging = False

			If _dragging Then
				Dim pGlyph As CornerGlyph = DirectCast(g, CornerGlyph)
				Dim xDiff As Integer = (mouseLoc.X - _dragStart.X)
				If (xDiff = 0) Then
					Return True
				End If
				_dragStart = mouseLoc

				Select Case whatCorner
					Case eCorner.LowerRight, eCorner.UpperRight
						sngSliderPos += xDiff

					Case eCorner.LowerLeft, eCorner.UpperLeft, eCorner.All
						sngSliderPos += xDiff
				End Select

				If sngSliderPos < 0 Then sngSliderPos = 0
				If sngSliderPos > pGlyph.CornerTrack.Width - 10 Then sngSliderPos = pGlyph.CornerTrack.Width - 10

				Select Case whatCorner
					Case eCorner.LowerRight, eCorner.UpperRight
						pGlyph.SetValue(CInt(pGlyph.maxCorner - ((sngSliderPos) / ((pGlyph.CornerTrack.Width - 10) / pGlyph.maxCorner))))

					Case eCorner.LowerLeft, eCorner.UpperLeft, eCorner.All
						pGlyph.SetValue(CInt(((sngSliderPos) / ((pGlyph.CornerTrack.Width - 10) / pGlyph.maxCorner))))
				End Select
				If whatCorner = eCorner.All Then
					For Each cg As Glyph In pGlyph.CornAdorner.Glyphs
						pGlyph.CornAdorner.Invalidate(cg.Bounds)
					Next
				Else
					pGlyph.CornAdorner.Invalidate(pGlyph.Bounds)
				End If
				relatedControl.Refresh()
			End If

			Return True

		End Function

		Public Overrides Function OnMouseEnter(g As Glyph) As Boolean
			_dragging = True
			Return True
		End Function

		Public Overrides Function OnMouseLeave(g As Glyph) As Boolean
			If _dragging = True Then
				SetCorners()
				_dragging = False
			End If
			Return True
		End Function

		Public Overrides Function OnMouseUp(ByVal g As Glyph, _
			ByVal button As MouseButtons) As Boolean
			_dragging = False
			SetCorners()
			Return True
		End Function

		Private Sub SetCorners()
			If whatCorner = eCorner.All Then
				SetControlProperty("Corners", New CornersProperty(relatedControl.Corners.All))
			Else

				SetControlProperty("Corners", New CornersProperty(relatedControl.Corners.LowerLeft,
																relatedControl.Corners.LowerRight,
																relatedControl.Corners.UpperLeft,
																relatedControl.Corners.UpperRight))
			End If

		End Sub

		Private Sub SetControlProperty(ByVal property_name As String, ByVal value As Object)
			TypeDescriptor.GetProperties(relatedControl) _
				(property_name).SetValue(relatedControl, value)
		End Sub

#End Region

	End Class

End Class
