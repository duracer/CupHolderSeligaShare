using System;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    internal static class Program
    {
        [STAThread]
        private static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //pred spustenim aplikacie vytvori objekt typu VisionSensorStore 
            using (VisionSensorStore store = GetVisionSensorStore()){
                Application.Run(new SampleForm(store));
            }
        }

        private static VisionSensorStore GetVisionSensorStore(){
            VisionSensorStore store = null;
            try{
                store = new VisionSensorStore();
            }
            catch (ApplicationException e){
                // You may have tried multiple activations.
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            ChooseNicInCaseMultiplyClientNicsAreAvailable();
            return store;
        }

        private static void ChooseNicInCaseMultiplyClientNicsAreAvailable(){
            // Select client(PC-side) Nic. You can change this settings later also.
            if (1 >= AvailableNicExplorer.GetClients().Count){
                return;
            }
            new NicSelectForm().ShowDialog();
        }
    }
}