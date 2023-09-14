using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class ProgramSettingsDisplayControl : UserControl
    {
        private IVisionSensor sensor;

        public ProgramSettingsDisplayControl(){
            InitializeComponent();
        }

        public void Initialize(IVisionSensor visionSensor){
            CleanUp();
            sensor = visionSensor;
            sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            // Display Initial Program Settings.
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void RefreshState(){
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void CleanUp(){
            if (sensor != null){
                sensor.ProgramSettingsUpdated -= SensorProgramSettingsUpdated;
            }
            labelProgramNo.Text = "--";
            labelActiveProgram.Text = "--";
            labelExternalTrigger.Text = "--";
            labelTriggerCycle.Text = "--";
            pictureBoxMasterImage.Image = null;
        }

        private void SensorProgramSettingsUpdated(object sender, EventArgs e){
            labelProgramNo.Text = sensor.ActiveProgram.ProgramNo.ToString();
            labelActiveProgram.Text = sensor.ActiveProgram.ProgramName;
            labelExternalTrigger.Text = sensor.ActiveProgram.ExternalTrigger.ToString();
            labelTriggerCycle.Text = sensor.ActiveProgram.TriggerCycleMilliSec.ToString();

            var masterBitmap = new Bitmap(320, 240, PixelFormat.Format24bppRgb);
            BitmapData masterData = masterBitmap.LockBits(new Rectangle(Point.Empty, new Size(320, 240)),
                                                          ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(sensor.ActiveProgram.MasterImage.ByteData, 0, masterData.Scan0,
                         sensor.ActiveProgram.MasterImage.ByteData.Length);
            masterBitmap.UnlockBits(masterData);

            if (pictureBoxMasterImage.Image != null){
                pictureBoxMasterImage.Image.Dispose();
            }
            pictureBoxMasterImage.Image = masterBitmap;
        }

        private void labelActiveProgramTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelProgramSettings_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}