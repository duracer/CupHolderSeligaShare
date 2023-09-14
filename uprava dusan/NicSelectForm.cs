using System;
using System.Net;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    public partial class NicSelectForm : Form
    {
        public NicSelectForm(){
            InitializeComponent();
            UpdateControls();
        }

        private void UpdateControls(){
            comboBoxEnableIPAddress.Items.Clear();
            foreach (IPAddress item in AvailableNicExplorer.GetClients()){
                comboBoxEnableIPAddress.Items.Add(item);
                comboBoxEnableIPAddress.SelectedIndex = 0;
            }
            labelClientIPAddress.Text = VisionSensorStore.StartPoint.ToString();
        }

        private void ButtonChangeClick(object sender, EventArgs e){
            if (comboBoxEnableIPAddress.SelectedIndex == -1){
                return;
            }
            VisionSensorStore.StartPoint = AvailableNicExplorer.GetClients()[comboBoxEnableIPAddress.SelectedIndex];
            UpdateControls();
        }
    }
}