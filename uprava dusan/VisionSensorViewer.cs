using System;
using System.Windows.Forms;
using Keyence.IV.Sdk.Sample_CSharp.Parts;
using System.Net;
using System.Threading;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    public partial class VisionSensorViewer : UserControl
    {
        
        private IVisionSensor sensor; //klucova premenna, neviem vsak jej skutocny typ! Poznam len skutocnos, ze prislusna trieda implementuje rozhranie IVisionSensor 
        private VisionSensorStore store;
        public  IPAddress IP_Add; 

        public VisionSensorViewer(){
            InitializeComponent();
        }

        public void Initialize(VisionSensorStore visionSensorStore, IPAddress IP, int pNum)
        {
            lbCisloKam.Text = pNum.ToString();
            CheckForIllegalCrossThreadCalls = false;
            store = visionSensorStore;
            this.IP_Add = IP;
            UpdateControls();
            // Notify ActiveToolChanged event to imageDisplayControl to draw active tool window.
            resultDisplayControl.ActiveToolChanged += ResultDisplayControlActiveToolChanged;
            
        }

        //TOTO sa vola pri zmene vyberu algoritmu na rozpoznavanie obrazu
        private void ResultDisplayControlActiveToolChanged(object sender, ToolSelectedEventArgs e)
        {
            //##########################################################################################    
            imageDisplayControl.ChangeActiveTool(e.ToolNo); //e.ToolNo - obsahuje cislo "progresbaru ktory je aktualne vybrany
            //##########################################################################################
        }

        public void CleanUp()
        {
            if (sensor == null)
            {
                return;
            }
            Disconnect(this, EventArgs.Empty);
            //resultDisplayControl = sucast GUI (UserControl) obsahujuca vypisy "Total", "TrigerCount", "Time"
            resultDisplayControl.ActiveToolChanged -= ResultDisplayControlActiveToolChanged;
			//resultDisplayControl.Dispose();
        }

        private void UpdateControls()
        {
            bool sensorEnable = sensor != null;
            //panelOperation.Enabled = sensorEnable;
            //panelConnection.Enabled = !panelOperation.Enabled;
            checkBoxEvent.Checked = sensorEnable && sensor.EventEnable;
			buttonConnect.Enabled = !checkBoxEvent.Checked;
			buttonDisconnect.Enabled = checkBoxEvent.Checked;
			timer.Enabled = sensorEnable;
            //######################################
            //######################################
            //######################################
            if (sensorEnable) imageDisplayControl.ChangeActiveTool(1); //toto zabezpeci ze sa po spusteni vyberie prvy algoritmus na rozpoznavanie obrazu
            //######################################
            //######################################
            //######################################
        }


        public void pripoj() {

            UpdateVisionSensorObject(); //vytvoorene objektu typu IVisionSensor na pracu s kamerou  
            //sucastou je aj nadviazanie spojenia s kamerou, kt. IP adrea bola zadana v GUI 
            SetupVisionSensorViewer(); //predanie objektu na pracu s kamerov jednotlivym sucastiam (triedam) programu
            UpdateControls(); //aktivacia vysualnych komponentov qGUI
        }
        
        
        
        private void ButtonConnectClick(object sender, EventArgs e){
            pripoj();

			
            //POKUS o pripojenie pomocou vlákien
            /*
            Control.CheckForIllegalCrossThreadCalls = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(delegate()
            {
                CheckForIllegalCrossThreadCalls = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                pripoj();
            });
            thread.Start();*/
        }

        private void UpdateVisionSensorObject(){
            try{ 
               //############################################################################
                //az tu sa objektu VisionSensorStore (sensor) prideluje adresa
                sensor = store.Create(this.IP_Add , 63000);
               //############################################################################
            }
            catch (InvalidOperationException e){
                // You may have tried to create same VisionSensor object before disposing it.
                MessageBox.Show(e.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ConnectionLostException e){
                MessageBox.Show(e.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //###############################################################################
            if (tmrReCon.Enabled == true) tmrReCon.Enabled = false; //hned ako sa podari reconnect vypinam reconnectovy casovac
            //###############################################################################

        }

        private void SetupVisionSensorViewer(){
            if (sensor == null){
                return;
            }
            //predanie zdielaneho objektu  "sensor" jednotlivym sucastiam (triedam) programu, ktoré ho vyžadujú
            //niektore z jednotlivych sucasti priradia pri inicializacia sensoru aj potrebnu metodu ktrou bude sensor dalej vyuzivat  
            //####################################################
            imageDisplayControl.Initialize(sensor); //sensor.ImageAcquired += SensorImageAcquired;
            //zobrazi technicke udaje o snimacom senzore kmery na GUI 
            //sensorIdentificationDisplayControl.Initialize(sensor); 
            resultDisplayControl.Initialize(sensor); //sensor.ResultUpdated += SensorResultUpdated; sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            programSettingsDisplayControl.Initialize(sensor); //sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            //programListDisplayControl.Initialize(sensor);  //sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            errorStatusDisplayControl.Initialize(sensor);  //sensor.ErrorStatusUpdated += SensorErrorStatusUpdated;
            //###################################################

            //#####################################################
            //#####################################################
            //programListDisplayControl.ConnectionLost += Disconnect; //iba jednoduche predanie metody Disconect objektu typu  programListDisplayControl
            errorStatusDisplayControl.ConnectionLost += Disconnect; //iba jednoduche predanie metody Disconect objektu typu  errorStatusDisplayControl
            //#####################################################
            //#####################################################
        }

        private void TearDownVisionSensorViewer(){
			//programListDisplayControl.ConnectionLost -= Disconnect;
			errorStatusDisplayControl.ConnectionLost -= Disconnect;
			//errorStatusDisplayControl.Dispose();
			//store.Dispose();
            imageDisplayControl.CleanUp();
			//imageDisplayControl.Dispose();
            //sensorIdentificationDisplayControl.CleanUp();
            resultDisplayControl.CleanUp();
			//resultDisplayControl.Dispose();
			programSettingsDisplayControl.CleanUp();
			//programSettingsDisplayControl.Dispose();
			//programListDisplayControl.CleanUp();
			errorStatusDisplayControl.CleanUp();
			//errorStatusDisplayControl.Dispose();

        }

        
        
        //#############################################################################
        private void TimerTick(object sender, EventArgs e){
            if (sensor == null){
                return;
            }
            try{
                sensor.TickTack();
            }
            catch (ConnectionLostException){
                Disconnect(sender, e);
                //tmrReCon.Enabled = true;
            }
        }
            
            //INICIALIZACIA TIMERU  
            //this.timer.Interval = 20;
            //this.timer.Tick += new System.EventHandler(this.TimerTick);
        //############################################################################
        
        
        private void CheckBoxEventCheckedChanged(object sender, EventArgs e){
            if (sensor == null){
                return;
            }
            sensor.EventEnable = checkBoxEvent.Checked;
            if( sensor.EventEnable){
                imageDisplayControl.RefreshState();
                resultDisplayControl.RefreshState();
                programSettingsDisplayControl.RefreshState();
                //programListDisplayControl.RefreshState();
                errorStatusDisplayControl.RefreshState();
            }
        }

        private void Disconnect(object sender, EventArgs e){

            TearDownVisionSensorViewer();
            sensor.Dispose();
            sensor = null;
			UpdateControls();
        }


        private void Reconnect(object sender, EventArgs e)
        {
            pripoj();
        }


        private void VisionSensorViewer_Load(object sender, EventArgs e)
        {

        }

        private void panelDisconnection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void programSettingsDisplayControl_Load(object sender, EventArgs e)
        {

        }

        private void resultDisplayControl_Load(object sender, EventArgs e)
        {

        }

        private void errorStatusDisplayControl_Load(object sender, EventArgs e)
        {

        }
    }
}