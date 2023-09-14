using System;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class ProgramListDisplayControl : UserControl
    {
        private IVisionSensor sensor;

        public ProgramListDisplayControl(){
            InitializeComponent();
        }

        public event EventHandler ConnectionLost;

        public void Initialize(IVisionSensor visionSensor){
            CleanUp();
            sensor = visionSensor;
            sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            // Display Initial Program List.
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void RefreshState(){
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void CleanUp(){
            if (sensor != null){
                sensor.ProgramSettingsUpdated -= SensorProgramSettingsUpdated;
            }
            listBoxPrograms.Items.Clear();
            labelLockState.Text = "--";
        }

        private void SensorProgramSettingsUpdated(object sender, EventArgs e){
            listBoxPrograms.Items.Clear();
            foreach (ProgramHeader program in sensor.Programs){
                listBoxPrograms.Items.Add(program.ToString());
            }
            UpdateLoginState();
        }

        private void ButtonSwitchProgramClick(object sender, EventArgs e){
            if (listBoxPrograms.SelectedIndex == -1){
                return;
            }
            try{
                sensor.SwitchProgramTo(sensor.Programs[listBoxPrograms.SelectedIndex]);
            }
            catch (ConnectionLostException){
                ConnectionLost(this, EventArgs.Empty);
            }
        }

        private void ButtonTriggerClick(object sender, EventArgs e){
            try{
                sensor.Trigger();
            }
            catch (ConnectionLostException){
                ConnectionLost(this, EventArgs.Empty);
            }
        }

        private void ButtonLoginClick(object sender, EventArgs e){
            var form = new LoginForm{StartPosition = FormStartPosition.CenterScreen};
            if (DialogResult.OK != form.ShowDialog()){
                return;
            }
            bool loginSucceeded = sensor.Unlock(form.InputPassword);
            UpdateLoginState();
            MessageBox.Show(loginSucceeded ? "Unlock Succeeded" : "Incorrect password.", "Unlock",
                            MessageBoxButtons.OK, loginSucceeded ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void ButtonLogoutClick(object sender, EventArgs e){
            sensor.Lock();
            UpdateLoginState();
        }

        private void UpdateLoginState(){
            buttonSwitchProgram.Enabled = (!sensor.PasswordRequired || (sensor.PasswordRequired && sensor.Unlocked)) &&
                                          !sensor.ExternalProgramSwitch;
            buttonTrigger.Enabled = sensor.ActiveProgram.ExternalTrigger &&
                                    (!sensor.PasswordRequired || (sensor.PasswordRequired && sensor.Unlocked));
            buttonUnLock.Enabled = sensor.PasswordRequired && !sensor.Unlocked;
            buttonLock.Enabled = sensor.PasswordRequired && sensor.Unlocked;
            labelLockState.Text = sensor.PasswordRequired ? (sensor.Unlocked ? "Unlocked" : "locked") : "--";
        }
    }
}