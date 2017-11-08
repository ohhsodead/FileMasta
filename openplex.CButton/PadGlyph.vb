Imports System.Windows.Forms.Design.Behavior
Imports System.Drawing.Drawing2D
Imports System.ComponentModel.Design

Public Class PadGlyph
	Inherits Glyph
	Private relatedControl As CButton
	Private behaviorSvc As System.Windows.Forms.Design.Behavior.BehaviorService
	Private selectionSvc As ISelectionService = Nothing
	Private relatedDesigner As IDesigner = Nothing
	Private PadAdorner As Adorner

	Enum eWhatBorder
		Top
		Left
		Right
		Bottom
	End Enum
	Private WhatBorder As eWhatBorder

	Enum eAdjWhat
		Button
		Text
	End Enum
	Public Property AdjWhat As eAdjWhat

	Public Sub New(
		ByVal behaviorService As System.Windows.Forms.Design.Behavior.BehaviorService,
		ByVal control As CButton,
		ByVal selectionService As ISelectionService, _
		ByVal relatedDesigner As IDesigner, _
		ByVal myAdorner As Adorner,
		ByVal adjWhat As eAdjWhat)

		MyBase.New(New PadBehavior(relatedDesigner, adjWhat))
		' Cache references for convenience. 
		Me.behaviorSvc = behaviorService
		Me.selectionSvc = selectionService
		Me.relatedDesigner = relatedDesigner
		Me.PadAdorner = myAdorner
		Me.AdjWhat = adjWhat

		' Cache a reference to the control being designed. 
		Me.relatedControl = CType(Me.relatedDesigner.Component, CButton)

	End Sub

	Public Overrides ReadOnly Property Bounds() As Rectangle
		Get

			Dim edge As Point = behaviorSvc.ControlToAdornerWindow(relatedControl)
			Dim pad As Rectangle
			If AdjWhat = eAdjWhat.Button Then
				pad = Rectangle.Round(relatedControl.ButtonArea)
			Else
				pad = Rectangle.Round(relatedControl.TextArea)
			End If
			pad.Offset(edge)
			Return pad
		End Get

	End Property

	Private isOver As Boolean = False
	Public Overrides Function GetHitTest(ByVal p As Point) As Cursor

		If Object.ReferenceEquals(Me.selectionSvc.PrimarySelection, Me.relatedControl) AndAlso
			DirectCast(DirectCast(relatedDesigner, CButtonDesigner).ChooseAdorner.Glyphs(0), ChooseGlyph).chooseWhat = ChooseGlyph.eChooseWhat.Pad Then
'			WhatBorder = eWhatBorder.None

			Using gp As GraphicsPath = New GraphicsPath(),
				pn As Pen = New Pen(Brushes.Black, 7)
				If DirectCast(MyBase.Behavior, PadBehavior)._dragging Then
					pn.Width = 20
				Else
					pn.Width = 3
				End If

				If Control.ModifierKeys = Keys.Shift and AdjWhat = eAdjWhat.Button then Return nothing

				gp.AddLine(Bounds.X, Bounds.Y, Bounds.Right, Bounds.Y)
				If gp.IsOutlineVisible(p, pn) Then
					WhatBorder = eWhatBorder.Top
					If isOver = False Then
						isOver = True
						Me.PadAdorner.Invalidate()
					End If
					Return Cursors.HSplit
				End If
				gp.Reset()
				gp.AddLine(Bounds.X, Bounds.Y, Bounds.X, Bounds.Bottom)
				If gp.IsOutlineVisible(p, pn) Then
					WhatBorder = eWhatBorder.Left
					If isOver = False Then
						isOver = True
						Me.PadAdorner.Invalidate()
					End If
					Return Cursors.VSplit
				End If
				gp.Reset()
				gp.AddLine(Bounds.Right, Bounds.Y, Bounds.Right, Bounds.Bottom)
				If gp.IsOutlineVisible(p, pn) Then
					WhatBorder = eWhatBorder.Right
					If isOver = False Then
						isOver = True
						Me.PadAdorner.Invalidate()
					End If
					Return Cursors.VSplit
				End If
				gp.Reset()
				gp.AddLine(Bounds.X, Bounds.Bottom, Bounds.Right, Bounds.Bottom)
				If gp.IsOutlineVisible(p, pn) Then
					WhatBorder = eWhatBorder.Bottom
					If isOver = False Then
						isOver = True
						Me.PadAdorner.Invalidate()
					End If
					Return Cursors.HSplit
				End If

				If isOver = True Then
					isOver = False
					Me.PadAdorner.Invalidate()
				End If
				Return Nothing

			End Using
		End If
		Return Nothing

	End Function

	Public Overrides Sub Paint(ByVal pe As PaintEventArgs)

		If Object.ReferenceEquals(Me.selectionSvc.PrimarySelection, Me.relatedControl) AndAlso
			DirectCast(DirectCast(relatedDesigner, CButtonDesigner).ChooseAdorner.Glyphs(0), ChooseGlyph).chooseWhat = ChooseGlyph.eChooseWhat.Pad Then

			Using pn As New Pen(Brushes.DarkGray, 1.5) With {.DashStyle = Drawing2D.DashStyle.Dash}
				If isOver = True Then pn.Color = Color.Black
				pe.Graphics.DrawRectangle(pn, New Rectangle(Bounds.X, Bounds.Y, Bounds.Width - 1, Bounds.Height - 1))

			End Using
		End If

	End Sub


	Class PadBehavior
		Inherits System.Windows.Forms.Design.Behavior.Behavior
		Private relatedDesigner As IDesigner = Nothing
		Private relatedControl As CButton = Nothing
		Private AdjWhat As eAdjWhat

		Friend Sub New(ByVal relatedDesigner As IDesigner, ByVal adjWhat As eAdjWhat)
			Me.relatedDesigner = relatedDesigner
			Me.relatedControl = CType(relatedDesigner.Component, CButton)
			Me.AdjWhat = adjWhat
		End Sub


		Dim _dragStart As Point
		Public _dragging As Boolean

		Public Overrides Function OnMouseDown(g As Glyph, button As MouseButtons, mouseLoc As Point) As Boolean
			_dragStart = mouseLoc
			_dragging = True
			Return True
		End Function

		Public Overrides Function OnMouseMove(g As Glyph, button As MouseButtons, mouseLoc As Point) As Boolean

			If button <> MouseButtons.Left Then _dragging = False

			If _dragging Then
				Dim pGlyph As PadGlyph = DirectCast(g, PadGlyph)

				Dim xDiff As Integer = (mouseLoc.X - _dragStart.X)
				Dim yDiff As Integer = (mouseLoc.Y - _dragStart.Y)

				If ((xDiff = 0) AndAlso (yDiff = 0)) Then
					Return True
				End If
				_dragStart = mouseLoc

				Dim pos As Integer
				Dim pad As Padding
				If AdjWhat = eAdjWhat.Button Then
					pad = relatedControl.Padding
				Else
					pad = relatedControl.TextMargin
				End If

				Select Case pGlyph.WhatBorder
					Case eWhatBorder.Top
						pos = pad.Top
						pos += yDiff
						pad = New Padding(pad.Left,
											pos,
											pad.Right,
											pad.Bottom)
					Case eWhatBorder.Left
						pos = pad.Left
						pos += xDiff
						pad = New Padding(pos,
											pad.Top,
											pad.Right,
											pad.Bottom)
					Case eWhatBorder.Right
						pos = pad.Right
						pos -= xDiff
						pad = New Padding(pad.Left,
											pad.Top,
											pos,
											pad.Bottom)
					Case eWhatBorder.Bottom
						pos = pad.Bottom
						pos -= yDiff
						pad = New Padding(pad.Left,
											pad.Top,
											pad.Right,
											pos)
				End Select

				If AdjWhat = eAdjWhat.Button Then
					relatedControl.Padding = pad
				Else
					relatedControl.TextMargin = pad
				End If
				pGlyph.PadAdorner.Invalidate()
			End If

			Return True

		End Function

		Public Overrides Function OnMouseUp(ByVal g As Glyph, _
			ByVal button As MouseButtons) As Boolean
			_dragging = False
			Return True
		End Function
	End Class


End Class
