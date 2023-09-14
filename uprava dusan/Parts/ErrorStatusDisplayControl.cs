using System;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class ErrorStatusDisplayControl : UserControl
    {

        //senzor ktory dostava trieda zvonka prostrednictvom metodyz Initialize(IVisionSensor visionSensor)
        private IVisionSensor sensor;

        public ErrorStatusDisplayControl(){
            InitializeComponent();
        }

        public event EventHandler ConnectionLost;

        public void Initialize(IVisionSensor visionSensor){
            CleanUp();
            sensor = visionSensor;
            sensor.ErrorStatusUpdated += SensorErrorStatusUpdated;
        }

        //bezparametrova aktualizacia ErrorStatusu v GUI 
        public void RefreshState(){
            SensorErrorStatusUpdated(this, EventArgs.Empty);
        }

        //premaze cely listbox s chybami 
        public void CleanUp(){
            // objekt senzor existuje 
            if (sensor != null){
                //zabranenie tomu aby iny majitel objektu senzor volanim metody ErrorStatusUpdated aktualizoval zobrazenie ErrorStatusu objektu Snezor 
                sensor.ErrorStatusUpdated -= SensorErrorStatusUpdated;
            }
            listBoxClearableErrors.Items.Clear();
        }

        
        //zaobrazi aktualne chyby zaznamena v senzore do listboxu 
        private void SensorErrorStatusUpdated(object sender, EventArgs e){
            listBoxClearableErrors.Items.Clear();
            foreach (SensorError error in sensor.Errors){
                listBoxClearableErrors.Items.Add(error.Description);
            }
        }

        private void ButtonErrorClearClick(object sender, EventArgs e){
            if (listBoxClearableErrors.SelectedIndex == -1){
                return;
            }
            try{
                //vymaze chybu vybranu v ListBoxe zo Senzoru  
                sensor.ClearError(sensor.Errors[listBoxClearableErrors.SelectedIndex]);
                //da sa cakat, ze metoda ClearError zavola SensorErrorStatusUpdated predanu do sensora prostrednictvom delegatu, ktora nasledne premaze cely ErrorBox
            }
            catch (ConnectionLostException){
                ConnectionLost(this, EventArgs.Empty);
            }
        }
    }
}