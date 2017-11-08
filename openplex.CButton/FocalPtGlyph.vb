Imports System.Windows.Forms.Design.Behavior
Imports System.Drawing.Drawing2D
Imports System.ComponentModel.Design

Public Class FocalPtGlyph
	Inherits Glyph

#Region "Declarations"

	Private relatedControl As CButton
	Private behaviorSvc As System.Windows.Forms.Design.Behavior.BehaviorService
	Private selectionSvc As ISelectionService = Nothing
	Private relatedDesigner As IDesigner = Nothing
	Private FocalPtAdorner As Adorner
	Private FocalBox As Rectangle
	Private boxFillColor As Brush = New SolidBrush(Color.FromArgb(120, Color.White))

	Enum eAdjWhat
		FocalScale
		Center
		None
	End Enum
	Public Property AdjWhat As eAdjWhat

#End Region

#Region "New"

	Public Sub New(
		ByVal behaviorService As System.Windows.Forms.Design.Behavior.BehaviorService,
		ByVal control As CButton,
		ByVal selectionService As ISelectionService, _
		ByVal relatedDesigner As IDesigner, _
		ByVal myAdorner As Adorner,
		ByVal adjWhat As eAdjWhat)

		MyBase.New(New FocalPtBehavior(relatedDesigner, adjWhat))
		' Cache references for convenience. 
		Me.behaviorSvc = behaviorService
		Me.selectionSvc = selectionService
		Me.relatedDesigner = relatedDesigner
		Me.FocalPtAdorner = myAdorner
		Me.AdjWhat = adjWhat

		' Cache a reference to the control being designed. 
		Me.relatedControl = CType(Me.relatedDesigner.Component, CButton)

	End Sub

#End Region

#Region "Overrides"

	Public Overrides ReadOnly Property Bounds() As Rectangle
		Get

			Dim edge As Point = behaviorSvc.ControlToAdornerWindow(relatedControl)
			If relatedControl.FillType = CButton.eFillType.GradientPath Then
				If AdjWhat = eAdjWhat.Center Then
					Return Rectangle.Round(New RectangleF((edge.X + relatedControl.Padding.Left + relatedControl.FocalPoints.CenterPoint.X * relatedControl.ButtonArea.Width) - 5,
														 (edge.Y + relatedControl.Padding.Top + relatedControl.FocalPoints.CenterPoint.Y * relatedControl.ButtonArea.Height) - 5, 10, 10))
				ElseIf AdjWhat = eAdjWhat.FocalScale Then
					Return Rectangle.Round(New RectangleF((edge.X + relatedControl.Padding.Left + relatedControl.FocalPoints.FocusScales.X * relatedControl.ButtonArea.Width) - 5,
														 (edge.Y + relatedControl.Padding.Top + relatedControl.FocalPoints.FocusScales.Y * relatedControl.ButtonArea.Height) - 5, 10, 10))
				End If
			End If

			Return New Rectangle(edge.X, edge.Y, relatedControl.Width, relatedControl.Height)
		End Get

	End Property

	Public Overrides Function GetHitTest(ByVal p As Point) As Cursor

		If Object.ReferenceEquals(Me.selectionSvc.PrimarySelection, Me.relatedControl) AndAlso
			DirectCast(DirectCast(relatedDesigner, CButtonDesigner).ChooseAdorner.Glyphs(0), ChooseGlyph).chooseWhat = ChooseGlyph.eChooseWhat.FocalPt Then

			If DirectCast(Me.Behavior, FocalPtBehavior)._dragging Then Return Cursors.Cross
			If Bounds.Contains(p) Then
				Return Cursors.Cross
			End If
		End If

		Return Nothing

	End Function

	Public Overrides Sub Paint(ByVal pe As PaintEventArgs)

		If Object.ReferenceEquals(Me.selectionSvc.PrimarySelection, Me.relatedControl) AndAlso
			DirectCast(DirectCast(relatedDesigner, CButtonDesigner).ChooseAdorner.Glyphs(0), ChooseGlyph).chooseWhat = ChooseGlyph.eChooseWhat.FocalPt Then

			Dim edge As Point = behaviorSvc.ControlToAdornerWindow(relatedControl)

			If relatedControl.FillType = CButton.eFillType.GradientPath Then
				'Dim fRect As RectangleF = New RectangleF((edge.X + relatedControl.Padding.Left + relatedControl.FocalPoints.CenterPoint.X * relatedControl.ButtonArea.Width) - 5,
				'										 (edge.Y + relatedControl.Padding.Top + relatedControl.FocalPoints.CenterPoint.Y * relatedControl.ButtonArea.Height) - 5, 10, 10)
				'Dim cRect As RectangleF = New RectangleF((edge.X + relatedControl.Padding.Left + relatedControl.FocalPoints.FocusScales.X * relatedControl.ButtonArea.Width) - 5,
				'										 (edge.Y + relatedControl.Padding.Top + relatedControl.FocalPoints.FocusScales.Y * relatedControl.ButtonArea.Height) - 5, 10, 10)

				Using pn As Pen = New Pen(Color.Gray, 1)
					pn.DashStyle = DashStyle.Dot

					If AdjWhat = eAdjWhat.Center Then
						pe.Graphics.FillEllipse(boxFillColor, Bounds)
						pe.Graphics.DrawEllipse(pn, Bounds)

					ElseIf AdjWhat = eAdjWhat.FocalScale Then
						pe.Graphics.FillRectangle(boxFillColor, Bounds)
						pe.Graphics.DrawRectangle(pn, Rectangle.Round(Bounds))

					End If



					'pe.Graphics.DrawRectangle(New Pen(), Rectangle.Round(cRect))

				End Using
			End If

		End If

	End Sub

#End Region

	Class FocalPtBehavior
		Inherits Behavior

#Region "Declarations"

		Private relatedDesigner As IDesigner = Nothing
		Private relatedControl As CButton = Nothing

		Private adjWhat As eAdjWhat
		Private _dragStart As Point
		Public _dragging As Boolean

#End Region

#Region "New"

		Friend Sub New(ByVal relatedDesigner As IDesigner, ByVal adjWhat As eAdjWhat)
			Me.relatedDesigner = relatedDesigner
			Me.relatedControl = CType(relatedDesigner.Component, CButton)
			Me.adjWhat = adjWhat
		End Sub

#End Region

#Region "OnMouse Events"

		Public Overrides Function OnMouseDown(g As Glyph, button As MouseButtons, mouseLoc As Point) As Boolean
			If button = MouseButtons.Left Then
				If Control.ModifierKeys = Keys.Shift Then

					If adjWhat = eAdjWhat.FocalScale Then
						relatedControl.FocalPoints.SetFocusScales(New PointF(0.0, 0.0))
					ElseIf adjWhat = eAdjWhat.Center Then
						relatedControl.FocalPoints.SetCenterPoint(New PointF(0.5, 0.5))
					End If
					relatedControl.Refresh()

				Else
					_dragStart = mouseLoc
					_dragging = True
				End If
			End If
			Return True

		End Function

		Public Overrides Function OnMouseMove(g As Glyph, button As MouseButtons, mouseLoc As Point) As Boolean

			If button <> MouseButtons.Left Then _dragging = False

			If _dragging Then
				Dim pGlyph As FocalPtGlyph = DirectCast(g, FocalPtGlyph)
				Dim edge As Point = pGlyph.behaviorSvc.ControlToAdornerWindow(pGlyph.relatedControl)
				Dim xDiff As Integer = (mouseLoc.X - _dragStart.X)
				Dim yDiff As Integer = (mouseLoc.Y - _dragStart.Y)

				If ((xDiff = 0) AndAlso (yDiff = 0)) Then
					Return True
				End If
				_dragStart = mouseLoc

				Dim newPos As New SizeF(CSng(Math.Max(Math.Min(xDiff / relatedControl.ButtonArea.Width, 1.0), 0.0)),
										CSng(Math.Max(Math.Min(yDiff / relatedControl.ButtonArea.Height, 1.0), 0.0)))

				If pGlyph.AdjWhat = eAdjWhat.FocalScale Then
					relatedControl.FocalPoints.SetFocusScales(PointF.Add(relatedControl.FocalPoints.FocusScales,
																		New SizeF(CSng(xDiff / relatedControl.ButtonArea.Width),
																				  CSng(yDiff / relatedControl.ButtonArea.Height))))
				ElseIf pGlyph.AdjWhat = eAdjWhat.Center Then
					relatedControl.FocalPoints.SetCenterPoint(PointF.Add(relatedControl.FocalPoints.CenterPoint,
																		New SizeF(CSng(xDiff / relatedControl.ButtonArea.Width),
																				  CSng(yDiff / relatedControl.ButtonArea.Height))))
				End If

				pGlyph.FocalPtAdorner.Invalidate()
			End If

			Return True

		End Function

		Public Overrides Function OnMouseUp(ByVal g As Glyph, _
			ByVal button As MouseButtons) As Boolean

			_dragging = False
			Return True

		End Function

#End Region

	End Class


End Class

