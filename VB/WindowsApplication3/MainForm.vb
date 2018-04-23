Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraEditors


Namespace DxSample
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			timer1.Start()
			SetUpAnimation()
		End Sub

		Private Sub SetUpAnimation()
			arcScaleComponent1.EnableAnimation = True
			arcScaleComponent1.EasingFunction = New BackEase()
			arcScaleComponent1.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut

			arcScaleComponent2.EnableAnimation = True
			arcScaleComponent2.EasingFunction = New CircleEase()
			arcScaleComponent2.EasingMode = EasingMode.EaseIn

			linearScaleComponent1.EnableAnimation = True
			linearScaleComponent1.EasingFunction = New QuadraticEase()
			linearScaleComponent1.EasingMode = EasingMode.EaseOut
		End Sub

		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			DoAnimation(gaugeControl1)
		End Sub

		Private Sub DoAnimation(ByVal gauge As GaugeControl)
			For Each gb As IGauge In gauge.Gauges
				Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
				If cGauge IsNot Nothing Then
					For Each scale As IScale In cGauge.Scales
						scale.Value = AnimateScaleValue(scale)
					Next scale
				End If
				Dim lGauge As ILinearGauge = TryCast(gb, ILinearGauge)
				If lGauge IsNot Nothing Then
					For Each scale As IScale In lGauge.Scales
						scale.Value = AnimateScaleValue(scale)
					Next scale
				End If
			Next gb
		End Sub

		Private Function AnimateScaleValue(ByVal scale As IScale) As Single
			Dim r As New Random()
			Return r.Next(0, 100)
		End Function
	End Class
End Namespace
