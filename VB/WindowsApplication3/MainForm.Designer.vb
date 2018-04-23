Imports Microsoft.VisualBasic
Imports System
Namespace DxSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim arcScaleRange1 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange2 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange3 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim scaleIndicatorState1 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
			Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
			Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.linearScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
			Me.linearScaleLevelComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
			Me.linearScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
			Me.linearScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
			Me.linearScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
			Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleLevelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1, Me.linearGauge1, Me.circularGauge2})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(609, 254)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 242, 242)
			Me.circularGauge1.Name = "circularGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg1"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style17
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceScale.Brush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#058897")
			Me.arcScaleComponent1.AppearanceScale.Width = 3F
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00E1F3")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -11F
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style17_1
			Me.arcScaleComponent1.MajorTickmark.TextOffset = -20F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -4F
			Me.arcScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style17_2
			Me.arcScaleComponent1.Name = "scale1"
			Me.arcScaleComponent1.RadiusX = 96F
			Me.arcScaleComponent1.RadiusY = 96F
			arcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#09AC86")
			arcScaleRange1.EndValue = 33F
			arcScaleRange1.Name = "Range0"
			arcScaleRange1.ShapeOffset = 0F
			arcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#CAB46E")
			arcScaleRange2.EndValue = 66F
			arcScaleRange2.Name = "Range1"
			arcScaleRange2.ShapeOffset = 0F
			arcScaleRange2.StartValue = 33F
			arcScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C16268")
			arcScaleRange3.EndValue = 100F
			arcScaleRange3.Name = "Range2"
			arcScaleRange3.ShapeOffset = 0F
			arcScaleRange3.StartValue = 66F
			Me.arcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { arcScaleRange1, arcScaleRange2, arcScaleRange3})
			Me.arcScaleComponent1.StartAngle = -240F
			Me.arcScaleComponent1.Value = 31F
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = 4F
			Me.arcScaleNeedleComponent1.Name = "needle1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style17
			Me.arcScaleNeedleComponent1.StartOffset = -27F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' linearGauge1
			' 
			Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() { Me.linearScaleBackgroundLayerComponent1})
			Me.linearGauge1.Bounds = New System.Drawing.Rectangle(503, 6, 100, 242)
			Me.linearGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() { Me.linearScaleStateIndicatorComponent1})
			Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() { Me.linearScaleLevelComponent1, Me.linearScaleLevelComponent2})
			Me.linearGauge1.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent() { Me.linearScaleMarkerComponent1})
			Me.linearGauge1.Name = "linearGauge1"
			Me.linearGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() { Me.linearScaleRangeBarComponent1})
			Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1, Me.linearScaleComponent2})
			' 
			' linearScaleBackgroundLayerComponent1
			' 
			Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleBackgroundLayerComponent1.Name = "Gauge0_BackgroundLayer1"
			Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F)
			Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style19
			Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' linearScaleComponent1
			' 
			Me.linearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 9F)
			Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A4D6F7")
			Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F)
			Me.linearScaleComponent1.MajorTickCount = 6
			Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -23F
			Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_1
			Me.linearScaleComponent1.MajorTickmark.TextOffset = -35F
			Me.linearScaleComponent1.MaxValue = 100F
			Me.linearScaleComponent1.MinorTickCount = 4
			Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -23F
			Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_2
			Me.linearScaleComponent1.Name = "Gauge0_Scale1"
			Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F)
			' 
			' linearScaleStateIndicatorComponent1
			' 
			Me.linearScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
			Me.linearScaleStateIndicatorComponent1.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent1.Name = "Gauge0_Indicator1"
			Me.linearScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(25F, 25F)
			scaleIndicatorState1.IntervalLength = 100F
			scaleIndicatorState1.Name = "Default"
			Me.linearScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState1})
			Me.linearScaleStateIndicatorComponent1.ZOrder = -100
			' 
			' linearScaleLevelComponent1
			' 
			Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleLevelComponent1.Name = "Gauge0_Level1"
			Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style19
			Me.linearScaleLevelComponent1.ZOrder = -50
			' 
			' linearScaleLevelComponent2
			' 
			Me.linearScaleLevelComponent2.LinearScale = Me.linearScaleComponent1
			Me.linearScaleLevelComponent2.Name = "Gauge0_Level2"
			Me.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style19
			Me.linearScaleLevelComponent2.ZOrder = -50
			' 
			' linearScaleMarkerComponent1
			' 
			Me.linearScaleMarkerComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleMarkerComponent1.Name = "Gauge0_Marker1"
			Me.linearScaleMarkerComponent1.ZOrder = -150
			' 
			' linearScaleRangeBarComponent1
			' 
			Me.linearScaleRangeBarComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleRangeBarComponent1.Name = "Gauge0_RangeBar1"
			Me.linearScaleRangeBarComponent1.ZOrder = -100
			' 
			' linearScaleComponent2
			' 
			Me.linearScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 9F)
			Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A4D6F7")
			Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F)
			Me.linearScaleComponent2.MajorTickCount = 6
			Me.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent2.MajorTickmark.ShapeOffset = -23F
			Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_1
			Me.linearScaleComponent2.MajorTickmark.TextOffset = -35F
			Me.linearScaleComponent2.MaxValue = 100F
			Me.linearScaleComponent2.MinorTickCount = 4
			Me.linearScaleComponent2.MinorTickmark.ShapeOffset = -23F
			Me.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_2
			Me.linearScaleComponent2.Name = "Gauge0_Scale2"
			Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F)
			' 
			' circularGauge2
			' 
			Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent2, Me.arcScaleBackgroundLayerComponent3})
			Me.circularGauge2.Bounds = New System.Drawing.Rectangle(254, 6, 242, 242)
			Me.circularGauge2.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() { Me.arcScaleEffectLayerComponent1})
			Me.circularGauge2.Name = "circularGauge2"
			Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
			Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent2, Me.arcScaleComponent3})
			Me.circularGauge2.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() { Me.arcScaleSpindleCapComponent1})
			' 
			' arcScaleBackgroundLayerComponent2
			' 
			Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleBackgroundLayerComponent2.Name = "Gauge1_BackgroundLayer1"
			Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.496F)
			Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style22
			Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8F)
			Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#393939")
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent2.EndAngle = 60F
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -6F
			Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_1
			Me.arcScaleComponent2.MajorTickmark.TextOffset = 13F
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 100F
			Me.arcScaleComponent2.MinorTickCount = 4
			Me.arcScaleComponent2.MinorTickmark.ShapeOffset = -6F
			Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2
			Me.arcScaleComponent2.Name = "Gauge1_Scale1"
			Me.arcScaleComponent2.RadiusX = 70F
			Me.arcScaleComponent2.RadiusY = 70F
			Me.arcScaleComponent2.StartAngle = -240F
			Me.arcScaleComponent2.Value = 50F
			' 
			' arcScaleBackgroundLayerComponent3
			' 
			Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent2
			Me.arcScaleBackgroundLayerComponent3.Name = "Gauge1_BackgroundLayer2"
			Me.arcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.496F)
			Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style22
			Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
			' 
			' arcScaleEffectLayerComponent1
			' 
			Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent2
			Me.arcScaleEffectLayerComponent1.Name = "Gauge1_EffectLayer1"
			Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.Empty
			Me.arcScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' arcScaleNeedleComponent2
			' 
			Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleNeedleComponent2.EndOffset = 3F
			Me.arcScaleNeedleComponent2.Name = "Gauge1_Needle1"
			Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style22
			Me.arcScaleNeedleComponent2.ZOrder = -50
			' 
			' arcScaleNeedleComponent3
			' 
			Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent2
			Me.arcScaleNeedleComponent3.EndOffset = 3F
			Me.arcScaleNeedleComponent3.Name = "Gauge1_Needle2"
			Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style22
			Me.arcScaleNeedleComponent3.ZOrder = -50
			' 
			' arcScaleComponent3
			' 
			Me.arcScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8F)
			Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#393939")
			Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent3.EndAngle = 60F
			Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -6F
			Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_1
			Me.arcScaleComponent3.MajorTickmark.TextOffset = 13F
			Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent3.MaxValue = 100F
			Me.arcScaleComponent3.MinorTickCount = 4
			Me.arcScaleComponent3.MinorTickmark.ShapeOffset = -6F
			Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2
			Me.arcScaleComponent3.Name = "Gauge1_Scale2"
			Me.arcScaleComponent3.RadiusX = 70F
			Me.arcScaleComponent3.RadiusY = 70F
			Me.arcScaleComponent3.StartAngle = -240F
			Me.arcScaleComponent3.Value = 50F
			' 
			' arcScaleSpindleCapComponent1
			' 
			Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent2
			Me.arcScaleSpindleCapComponent1.Name = "Gauge1_SpindleCap1"
			Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style22
			Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(28F, 28F)
			Me.arcScaleSpindleCapComponent1.ZOrder = -100
			' 
			' timer1
			' 
			Me.timer1.Interval = 1000
'			Me.timer1.Tick += New System.EventHandler(Me.OnTimerTick);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(609, 254)
			Me.Controls.Add(Me.gaugeControl1)
			Me.LookAndFeel.SkinName = "DevExpress Dark Style"
			Me.LookAndFeel.UseDefaultLookAndFeel = False
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.MaximumSize = New System.Drawing.Size(625, 292)
			Me.MinimumSize = New System.Drawing.Size(625, 292)
			Me.Name = "MainForm"
			Me.Text = "Animate Indicator"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleLevelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
		Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
		Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
		Private linearScaleLevelComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
		Private linearScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent
		Private linearScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent
		Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
		Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
	End Class
End Namespace

