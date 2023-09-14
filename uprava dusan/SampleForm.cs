using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Threading;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    public partial class SampleForm : Form
    {
        IP_Add_Control IP_Add;
        VisionSensorStore store;
        List<VisionSensorViewer> VSVL;
        
        //jediny kostruktor hlavneho formularu s dolezitym parametrom store
        public SampleForm(VisionSensorStore store)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();            

            this.store = store;
            this.NaplnVSVList();
            IP_Add = new IP_Add_Control(this, dajIPAdresy());
            if (!IP_Add.kontrolujIPs()) Environment.Exit(0);
            //store - jednduchy objekt s jednou klucovov metodov Create, ktora pre kazdu IP adresu (parameter funkcie) vytvori objekt na pracu s prislusny videosenzorom kamery
            this.inicializujVSVL();
            //visionSensorViewer1.Initialize(store, IP_Add.IP_Add_List[0]);
            //visionSensorViewer2.Initialize(store, IP_Add.IP_Add_List[3]);
            this.pripojVSVL();
            visionSensorViewer1.Visible = Properties.Settings.Default.IP1 == "0.0.0.0" ? false : true;
            this.WindowState = FormWindowState.Maximized;
            //visionSensorViewer2.pripoj();
            /*
            Thread thread = new Thread(delegate()
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                visionSensorViewer2.pripoj();

            });
            thread.Start();
            //visionSensorViewer2.pripoj();*/

        }
    
        
        private List<string> dajIPAdresy(){
            List<string> IP_List = new List<string>();
            IP_List.Add(Properties.Settings.Default.IP1);
            //IP_List.Add(Properties.Settings.Default.IP2);
            //IP_List.Add(Properties.Settings.Default.IP3);
            //IP_List.Add(Properties.Settings.Default.IP4);
            //IP_List.Add(Properties.Settings.Default.IP5);
            //IP_List.Add(Properties.Settings.Default.IP6);
            return(IP_List);
        }

        private void NaplnVSVList(){
            VSVL = new List<VisionSensorViewer>();
            VSVL.Add(visionSensorViewer1);
            //VSVL.Add(visionSensorViewer2);
            //VSVL.Add(visionSensorViewer3);
            //VSVL.Add(visionSensorViewer4);
            //VSVL.Add(visionSensorViewer5);
            //VSVL.Add(visionSensorViewer6);
        }

        void inicializujVSVL() {
            int i = 0;
            foreach (VisionSensorViewer VSV in VSVL){
				VSV.Initialize(store, IP_Add.IP_Add_List[i], VSVL.Count - i);
                //VSV.IP_Add.to == new System.Net.IPAddress(new byte[] {"0", "0", "0", "0" });
                i++;
            }
        }


        void pripojVSVL()
        {
            foreach (VisionSensorViewer VSV in VSVL)
            {
                if (VSV.IP_Add.ToString() == "0.0.0.0") 
                    continue;
                VSV.pripoj();
            }
        }

        




    
        private void inicializacia(){
             
            IP_Add = new IP_Add_Control(this,dajIPAdresy());

            if (!IP_Add.kontrolujIPs()) {
                //System.Windows.Forms.Application.Exit();
                //this.Close();
                //Application.ExitThread();
                //Application.Exit();
                Environment.Exit(0);
            }

           
        
        }

        private void visionSensorViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new InfoForm() { TopMost = true }.ShowDialog();
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {

        }

        private void visionSensorViewer5_Load(object sender, EventArgs e)
        {

        }

        private void VisionSensorViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
        }
    }
}