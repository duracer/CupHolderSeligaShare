using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class ResultDisplayControl : UserControl
    {
        private readonly Dictionary<byte, ToolResultDisplayControl> toolResults =
            new Dictionary<byte, ToolResultDisplayControl>();

        private ToolResultDisplayControl posAdjustResult;
        private IVisionSensor sensor;

        public ResultDisplayControl(){
            InitializeComponent();
            
        }

        public event EventHandler<ToolSelectedEventArgs> ActiveToolChanged = delegate { };

        public void Initialize(IVisionSensor visionSensor){
            CleanUp();
            sensor = visionSensor;
            //#########################################
            sensor.ResultUpdated += SensorResultUpdated; //predanie vykonavaccej metody prostredictvom atributu triedy IVisionSensor
            //#########################################
            sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            // Display Initial Tool Settiings.
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void RefreshState(){
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void CleanUp(){
            if (sensor != null){
                sensor.ResultUpdated -= SensorResultUpdated;
                sensor.ProgramSettingsUpdated -= SensorProgramSettingsUpdated;
            }
            labelTotal.Text = "--";
            labelTotal.ForeColor = Color.Black;
            labelTime.Text = "--";
            labelTrigger.Text = "--";
            toolResults.Clear();
            flowLayoutPanel.Controls.Clear();
            posAdjustResult = null;
        }

        private void SensorProgramSettingsUpdated(object sender, EventArgs e){
            


            toolResults.Clear();
            flowLayoutPanel.Controls.Clear();
            posAdjustResult = null;
            if (sensor.ActiveProgram.PositionAdjustSetting.ToolType != "")
            {
                posAdjustResult = new ToolResultDisplayControl(0, sensor.ActiveProgram.PositionAdjustSetting);
                posAdjustResult.Selected += ActiveToolChanged;
                flowLayoutPanel.Controls.Add(posAdjustResult);
            }
            for (byte i = 1; i <= 16; i++)
            {
                ToolSettingBase toolSetting = sensor.ActiveProgram[i];
                if (toolSetting.ToolType == "") continue;
                var control = new ToolResultDisplayControl(i, toolSetting);
                //###################################
                control.Selected += ActiveToolChanged;
                //###################################
                toolResults.Add(i, control);
                CheckForIllegalCrossThreadCalls = false;
                flowLayoutPanel.Controls.Add(control);
                
                //this.Invoke(new MethodInvoker(delegate() {flowLayoutPanel.Controls.Add(control); }));
            }
        }

        //volana funkcia vola vykonnu funkciu nepriamo prostrednictvom delegatu, pricom pre vykoknu fukciu zabezpecuje príslušné reálne parametre.
        //vykonna funkcia s urcentou daklaraciou, ktora bude predana prostrednictvom delegatu 
        //do volanej funkcia sa dostane dany delegat bud ako jej  formalny parameter alebo ako atribud triedy v ktorej sa volana funkcia nachadza
        private void SensorResultUpdated(object sender, ToolResultUpdatedEventArgs e){
            labelTotal.Text = e.TotalStatusResult ? "OK" : "NOK";
            labelTotal.ForeColor = e.TotalStatusResult ? Color.Green : Color.Red;
            labelTrigger.Text = e.TriggerCount.ToString();
            labelTime.Text = ((float) e.ProcessingTimeMicroSec/1000).ToString("0.00") + "ms";
            if (posAdjustResult != null){
                posAdjustResult.UpdateResult(e.PositionAdjust);
            }
            foreach (byte sensorIndex in toolResults.Keys){
                toolResults[sensorIndex].UpdateResult(e[sensorIndex]);
            }
        }

        private void labelTriggerCountTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelTimeTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void labelTrigger_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}