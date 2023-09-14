using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class ToolResultDisplayControl : UserControl
    {
        private readonly Bitmap panelImage;
        private readonly byte toolNo;
        private readonly ToolSettingBase toolSetting;
        private ToolResultBase toolResult;

        public ToolResultDisplayControl(byte toolNo, ToolSettingBase setting){
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.toolNo = toolNo;
            toolSetting = setting;
            labelToolNo.Text = toolNo.ToString();
            labelToolName.Text = setting.ToolName;
            labelToolType.Text = setting.ToolType;
            labelMinValue.Text = setting.MinValue.ToString();
            labelMaxValue.Text = setting.MaxValue.ToString();
            panelImage = new Bitmap(panelValueGauge.Width, panelValueGauge.Height);
        }

        public event EventHandler<ToolSelectedEventArgs> Selected = delegate { };

        public void UpdateResult(ToolResultBase result){
            toolResult = result;
            labelMatchPercent.Text = result.Value.ToString();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e){
            base.OnPaint(e);
            if (toolResult != null){
                UpdateGauge(toolResult);
            }
        }

        private void UpdateGauge(ToolResultBase result){
            Color startColor = result.Ok ? Color.Green : Color.Red;
            Color endColor = result.Ok ? Color.Lime : Color.Orange;
            using (Brush fillBrush = new LinearGradientBrush(Point.Empty, new Point(0, panelValueGauge.Height),
                                                             startColor, endColor))
            using (Graphics bufferGraphics = Graphics.FromImage(panelImage)){
                DrawGauge(result, bufferGraphics, fillBrush);
                DrawThresholdLine(bufferGraphics);
            }
            using (Graphics panelGraphics = panelValueGauge.CreateGraphics()){
                panelGraphics.DrawImage(panelImage, new Rectangle(Point.Empty, panelValueGauge.Size));
            }
        }

        private void DrawThresholdLine(Graphics graphics){
            int lowThreshold = panelValueGauge.Width*toolSetting.OkMinValue/toolSetting.MaxValue;
            graphics.DrawLine(Pens.Black, new Point(lowThreshold, 0), new Point(lowThreshold, panelValueGauge.Height));

            int highThreshold = panelValueGauge.Width*toolSetting.OkMaxValue/toolSetting.MaxValue;
            graphics.DrawLine(Pens.Black, new Point(highThreshold, 0), new Point(highThreshold, panelValueGauge.Height));
        }

        private void DrawGauge(ToolResultBase result, Graphics graphics, Brush fillBrush){
            var gaugeSize = new Size(panelValueGauge.Width*result.Value/toolSetting.MaxValue,
                                     panelValueGauge.Size.Height);
            graphics.FillRectangle(fillBrush, new Rectangle(Point.Empty, gaugeSize));
            graphics.FillRectangle(Brushes.White, new Rectangle(new Point(gaugeSize.Width, 0),
                                                                new Size(panelValueGauge.Width - gaugeSize.Width,
                                                                         panelValueGauge.Height)));
        }

        //#####################################################################
        private void ToolResultDisplayControlClick(object sender, EventArgs e){
            Selected(sender, new ToolSelectedEventArgs(toolNo));
        }
        //#####################################################################
    }
}