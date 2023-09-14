using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class SensorIdentificationDisplayControl : UserControl
    {
        private IVisionSensor sensor;

        public SensorIdentificationDisplayControl(){
            InitializeComponent();
        }

        public void Initialize(IVisionSensor visionSensor){
            CleanUp();
            sensor = visionSensor;
            Reset();
        }

        public void CleanUp(){
            labelModelName.Text = "--";
            labelVersion.Text = "--";
            labelSerialNo.Text = "--";
            labelMachineName.Text = "--";
        }

        private void Reset(){
            labelModelName.Text = sensor.ModelName;
            labelVersion.Text = sensor.SensorVersion;
            labelSerialNo.Text = sensor.SerialNo;
            labelMachineName.Text = sensor.DeviceName;
        }
    }
}