using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraEditors;


namespace DxSample {
    public partial class MainForm : XtraForm
    {
        public MainForm() {
            InitializeComponent();
        }
      

        private void OnFormLoad(object sender, EventArgs e) {
            timer1.Start();
            SetUpAnimation();
        }

        private void SetUpAnimation()
        {
            arcScaleComponent1.EnableAnimation = true;
            arcScaleComponent1.EasingFunction = new BackEase();
            arcScaleComponent1.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;

            arcScaleComponent2.EnableAnimation = true;
            arcScaleComponent2.EasingFunction = new CircleEase();
            arcScaleComponent2.EasingMode = EasingMode.EaseIn;

            linearScaleComponent1.EnableAnimation = true;
            linearScaleComponent1.EasingFunction = new QuadraticEase();
            linearScaleComponent1.EasingMode = EasingMode.EaseOut;
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            DoAnimation(gaugeControl1);
        }

        void DoAnimation(GaugeControl gauge)
        {
            foreach (IGauge gb in gauge.Gauges)
            {
                ICircularGauge cGauge = gb as ICircularGauge;
                if (cGauge != null)
                {
                    foreach (IScale scale in cGauge.Scales) scale.Value = AnimateScaleValue(scale);
                }
                ILinearGauge lGauge = gb as ILinearGauge;
                if (lGauge != null)
                {
                    foreach (IScale scale in lGauge.Scales) scale.Value = AnimateScaleValue(scale);
                }
            }
        }

        float AnimateScaleValue(IScale scale)
        {
            Random r = new Random();
            return r.Next(0, 100);
        }
    }
}
