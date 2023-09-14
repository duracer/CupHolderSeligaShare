//#define DEBUG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Sharp7;
using System.Threading;
using System.IO;
using System.Collections;



namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class PlcResultDisplayControl : UserControl
    {

        //neuspesne za sebou iduce pokusy o pripojenie k PLC
        int ErrorsConn = 0;
        int ErrorRead = 0;
        int ErrorReadAll = 0;

        public PlcResultDisplayControl()
        {
            InitializeComponent();

            //inicializacia slovnikov s konstantami
            DICTIONARY.dictionary_inic();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                //MessageBox.Show("wtf?");
                return;
            }


            this.nacitajConfig();
            tmr1.Tick += new EventHandler(this.read);
            btnPlcDisconnect.Enabled = false;
            Client = new S7Client();
            if (IntPtr.Size == 4)
                this.Text = this.Text + " - Running 32 bit Code";
            else
                this.Text = this.Text + " - Running 64 bit Code";

            PripojKPLC();
        }

        private S7Client Client;
        private byte[] Buffer = new byte[65536];

        public class DB6 {
            public const int barcode = 0;
            public const int pn = 52;
            public const int recipe = 104;


            public const int jalBcr = 156;
            public const int operations = 208;
            public const int sensors = 232;
            public const int camResult = 256;
            public const int wpStatus = 280;
            public const int posStatus = 282;
            public const int camStatus = 284;
            public const int elevatorStatus = 286;
            public const int res0 = 288;

        }

        string IP;

        void nacitajConfig() {
            this.IP = Properties.Settings.Default.IPPLC;
            tmr1.Interval = Properties.Settings.Default.Interval;
            lbCisloKam.Text = "ODS" + (Properties.Settings.Default.ODSNr + 1).ToString();
            //lbBrzda.Visible = lbBrzdaText.Visible = false;



            if (lbCisloKam.Text == "ODS3")
            {
                lblCamClip1.Text = "SmerŽ";
                lblCamClip2.Text = "Farba";

                //lbSpravDielu.Visible = false;
                //lbSpravDieluText.Visible = false;

                //lbBrzdaText.Visible = true;
                //lbBrzda.Visible = true;

                lblCamClip7.Visible = false;
                lblCamCllblCamClip8ip8.Visible = false;
                lblCamDir.Text = "Lavá";
                lblCamTop.Text = "Pravá";

                lbSpravDielu.Visible = false;
                lbSpravDieluText.Visible = false;

            }

        }


        private void ReadArea()
        {
            // Declaration separated from the code for readability
            int Amount;
            int startAddress;
            int SizeRead = 0;
            int Result;

            lbBR.Text = "0";
            Amount = 300;
            startAddress = 0 + (Properties.Settings.Default.ODSNr * Amount);
            //public int ReadArea(int Area, int DBNumber, int Start, int Amount, int WordLen, byte[] Buffer, ref int BytesRead)
            //#################################################################################################################
            Result = Client.ReadArea(S7Consts.S7AreaDB, 6, startAddress, Amount, S7Consts.S7WLByte, Buffer, ref SizeRead);
            //#################################################################################################################

            ShowResult(Result);
            if (Result == 0)
            {
                Vypis(Buffer, SizeRead);
                lbBR.Text = SizeRead.ToString();
            }
            else
            {
                this.ErrorRead++;
                this.ErrorReadAll++;
                if (ErrorRead == 3)
                {
                    ErrorRead = 0;
                    odpojiť();
                    Application.DoEvents();
                    //Thread.Sleep(1000);
                    PripojKPLC();
                }

            }


        }

        private void ShowResult(int Result)
        {
            // This function returns a textual explaination of the error code
            TSSLabel.ForeColor = Color.Red;
            TSSLabel.Text = Client.ErrorText(Result);
            if (Result == 0) {
                TSSLabel.ForeColor = Color.Black;
                TSSLabel.Text = TSSLabel.Text + " (" + Client.ExecutionTime.ToString() + " ms)";
            }
        }

        private void read(Object myObject, EventArgs myEventArgs) {
            ReadArea();
        }

        private void PripojKPLC()
        {
            int Result;
            int Rack = 0;
            int Slot = 0;
            Result = Client.ConnectTo(IP, Rack, Slot);
            ShowResult(Result);
            if (Result == 0)
            {
                this.ErrorsConn = 0;
                TSSLabel.ForeColor = Color.Black;
                TSSLabel.Text = TSSLabel.Text + " PDU Negotiated : " + Client.PduSizeNegotiated.ToString();
                lbErrors.Text = ErrorReadAll.ToString();
                tmr1.Enabled = true;
                btnPlcConnect.Enabled = false;
                btnPlcDisconnect.Enabled = true;

            }
            else
            {
                //tmr1.Start();
                ErrorsConn++;
                if (ErrorsConn == 3)
                {
                    this.ErrorsConn = 3;
                    TSSLabel.Text += "chyba pripojenia ku plc(" + Result.ToString() + ")";
                    ErrorsConn = 0;

                }

                PripojKPLC();

            }
        }

        private void odpojiť()
        {
            Client.Disconnect();
            tmr1.Enabled = false;
            TSSLabel.ForeColor = Color.Black;
            TSSLabel.Text = "Disconnected";
        }

        //###########################################################################
        //###########################################################################
        void setValue(char c, ref System.Windows.Forms.Label l)
        {
            l.BackColor = c == 'O' ? Color.LimeGreen : Color.OrangeRed;
            if (l.Text == "OK" || l.Text == "NOK")
                l.Text = c == 'O' ? "OK" : "NOK";

            l.Visible = c == 'D' ? false : true;

        }
        //###########################################################################
        //###########################################################################

        private void Vypis(byte[] bytes, int Size)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm");

            string barcode = S7.GetStringAt(Buffer, DB6.barcode);
            string pn = S7.GetStringAt(Buffer, DB6.pn);
            string recipe = S7.GetStringAt(Buffer, DB6.recipe);
            string jalBcr = S7.GetStringAt(Buffer, DB6.jalBcr);

            List<char> operation = new List<char>();
            List<char> sensor = new List<char>();
            List<char> camResult = new List<char>();
            for (int i = 0; i < 24; i++)
            {
                operation.Add((char)S7.GetByteAt(Buffer, DB6.operations + i));
                sensor.Add((char)S7.GetByteAt(Buffer, DB6.sensors + i));
                camResult.Add((char)S7.GetByteAt(Buffer, DB6.camResult + i));
            }

            int wpState = S7.GetIntAt(Buffer, DB6.wpStatus);
            int posState = S7.GetIntAt(Buffer, DB6.posStatus);
            int camState = S7.GetIntAt(Buffer, DB6.camStatus);
            int elevatorState = S7.GetIntAt(Buffer, DB6.elevatorStatus);

            lblBcr.Text = barcode;
            lblPn.Text = pn;
            lblRecipe.Text = recipe;
            lblJalRecipe.Text = recipe == "" ? "" : recipe.Remove(0, 6);
            lblJal.Text = jalBcr;

            //################################################################################################
            //################################################################################################
//#if DEBUG
/*
            if (String.IsNullOrEmpty(recipe))
                MessageBox.Show("recepie je NULL olebo EMPTY ","Chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);

            if (recipe.Length < 6)
                MessageBox.Show("recepie NIE JE ocakavanej dlzky 6 (alebo vacsej) \n HODNOTA: \"" + recipe+ "\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (DICTIONARY.STRANA[recipe[0]] != null)
                MessageBox.Show("Dodane necakane IDcko STRANY: \n HODNOTA: \"" + recipe[0] + "\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (DICTIONARY.SVETLO[recipe[1]] != null)
                MessageBox.Show("Dodane necakane IDcko SVETLA: \n HODNOTA: \"" + recipe[1] + "\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (DICTIONARY.VERZIA[recipe[2]] != null)
                MessageBox.Show("Dodane necakane IDcko VERZIE: \n HODNOTA: \"" + recipe[2] + "\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (DICTIONARY.VERZIA[recipe[3]] != null)
                MessageBox.Show("Dodane necakane IDcko PRITOMNOSTI KLUCKY: \n HODNOTA: \"" + recipe[3] + "\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (DICTIONARY.VERZIA[recipe[4]] != null)
                MessageBox.Show("Dodane necakane IDcko PRITOMNOSTI BARKODU: \n HODNOTA: \"" + recipe[4] + "\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
//#endif

            if (!(String.IsNullOrEmpty(recipe) || recipe.Length < 6))
            {
                lbStrana.Text = DICTIONARY.STRANA[recipe[0]] != null ? DICTIONARY.STRANA[recipe[0]] : "N/A";
                lbSvetlo.Text = DICTIONARY.SVETLO[recipe[1]] != null ? DICTIONARY.SVETLO[recipe[1]] : "N/A";
                lbVerzia.Text = DICTIONARY.VERZIA[recipe[2]] != null ? DICTIONARY.VERZIA[recipe[2]] : "N/A";
                lbKluckaNaRolete.Text = DICTIONARY.PRITOMNOST_KLUCKY[recipe[3]] != null ? DICTIONARY.PRITOMNOST_KLUCKY[recipe[3]] : "N/A";
                lbBarkodNaRolate.Text = DICTIONARY.PRITOMNOST_BARKODU[recipe[4]] != null ? DICTIONARY.PRITOMNOST_BARKODU[recipe[4]] : "N/A";

                if (recipe[5] == '-') lbFarbaZaluzie.Text = DICTIONARY.FARBA[recipe[5]];
                else
                    lbFarbaZaluzie.Text = recipe.Substring(5);
                
            }
            else
            {
                lbStrana.Text =  "N/A";
                lbSvetlo.Text =  "N/A";
                lbVerzia.Text =  "N/A";
                lbKluckaNaRolete.Text =  "N/A";
                lbBarkodNaRolate.Text =  "N/A";
                lbFarbaZaluzie.Text = "N/A";                
            }

            //################################################################################################
            //################################################################################################


            if (lblJal.Text == "D")
            {
                lblJal.Visible = false;
                label8.Visible = false;
            }
            else
            {
                lblJal.Visible = true;
                label8.Visible = true;
            }

            label20.Visible = lblInsertOK.Visible;
            label35.Visible = lblACOK.Visible;
            label37.Visible = lblETestOK.Visible;
            label39.Visible = lblJalOK.Visible;
            lbBrzdaText.Visible = lbBrzda.Visible;
            lbSpravDieluText.Visible = lbSpravDielu.Visible;

            label10.Visible = lblCenteredOK.Visible;

            setValue(sensor[0], ref lblVacOK);
            setValue(sensor[1], ref lblInsertOK);
            setValue(sensor[2], ref lblRecipeOK);
            setValue(sensor[3], ref lblCamOK);
            setValue(sensor[4], ref lblACOK);
            setValue(sensor[5], ref lblETestOK);
            setValue(sensor[6], ref lblJalOK);
            setValue(sensor[7], ref lblCenteredOK);
            setValue(sensor[8], ref lblNOKBtn);

            setValue(sensor[17], ref lbSpravDielu);
            setValue(sensor[18], ref lbBrzda);


            //cam data
            setValue(camResult[0], ref lblCamDir);
            setValue(camResult[1], ref lblCamTop);
            setValue(camResult[2], ref lblCamClip1);
            setValue(camResult[3], ref lblCamClip2);
            setValue(camResult[4], ref lblCamClip3);
            setValue(camResult[5], ref lblCamClip4);
            setValue(camResult[6], ref lblCamClip5);
            setValue(camResult[7], ref lblCamClip6);
            setValue(camResult[8], ref lblCamClip7);
            setValue(camResult[9], ref lblCamCllblCamClip8ip8);

            // inserts

            setValue(sensor[9], ref lblInsert1);
            setValue(sensor[10], ref lblInsert2);
            setValue(sensor[11], ref lblInsert3);
            setValue(sensor[12], ref lblInsert4);
            setValue(sensor[13], ref lblInsert5);
            setValue(sensor[14], ref lblInsert6);
            setValue(sensor[15], ref lblInsert7);
            setValue(sensor[16], ref lblInsert8);




            setValue(sensor[23], ref lblState);

            lblStCam.Visible = camState == 65535 ? false : true;
            label11.Visible = camState == 65535 ? false : true;
            lblStE.Visible = elevatorState == 65535 ? false : true;
            label17.Visible = elevatorState == 65535 ? false : true;

            lblStCam.Text = getCamStateText(camState);
            lblStE.Text = getElevatorStateText(elevatorState);
            lblStWp.Text = getWorkplaceStateText(wpState);
            lblStPos.Text = getpositionStateText(posState);



        }

        string getpositionStateText(int state)
        {
            switch (state)
            {
                case 0:
                    return "nečinný";
                case 10:
                    return "čakám na vákuum, skontrolujte inserty";                
                case 30:
                    return "kontrolujem inserty";
                case 40:
                    return "čakám načítanie kódu";
                case 45:
                    return "diel už bol na pracovisku alebo mu chýba predchádzajúca operácia";
                case 50:
                    return "čiarový kód nenájdený";
                case 60:
                    return "kód odoslaný čakám na recept";
                case 70:
                    return "čakám na elektrický test";
                case 75:
                    return "kontrolujem V520";
                case 76:
                    return "vlozte diel s brzdou";
                case 80:
                    return "založte žalúziu do držiaka";
                case 90:
                    return "kontrolujem brzdy žalúzie";
                case 100:
                    return "skenujem kód žalúzie";
                case 105:
                    return "kontrola brzdy";
                case 110:
                    return "uvoľňujem žalúziu";
                case 120:
                    return "čakám na výsledok kamery";
                case 130:
                    return "čakám na výsledok skrutkovačky";
                case 140:
                    return "držiak nie je v strede";
                case 150:
                    return "kontrolujem vazelínu";
                case 160:
                    return "koniec procesu";
                case 888:
                    return "operácia zrušená";
                case 999:
                    return "inicializácia";
                default:
                    return "neznámy stav + (" + state + ")";

            }
        }

        string getWorkplaceStateText(int state)
        {
            switch (state)
            {
                case 0:
                    return "nečinný";
                case 10:
                    return "paleta na pozícii";
                case 20:
                    return "transfer stúpa";
                case 30:
                    return "stúpanie transferu prerušené";
                case 40:
                    return "transfer v pracovnej pozícii";
                case 50:
                    return "operácie dokončené";
                case 60:
                    return "transfer klesá";
                case 70:
                    return "klesanie transferu prerušené";
                case 80:
                    return "čakám na uvoľnenie palety";
                case 90:
                    return "uvoľnujem paletu";
                case 999:
                    return "inicializácia";
                default:
                    return "neznámy stav + (" + state + ")";

            }
        }

        string getElevatorStateText(int state)
        {
            switch (state)
            {
                case 0:
                    return "nečinný";
                case 10:
                    return "paleta čaká";
                case 20:
                    return "naberám paletu";
                case 30:
                    return "paleta nabratá";
                case 40:
                    return "idem hore";
                case 50:
                    return "čakám signál uvoľnenia";
                case 60:
                    return "vykladám paletu";
                case 70:
                    return "idem dole";
                case 999:
                    return "inicializácia";
                default:
                    return "neznámy stav + (" + state + ")";

            }
        }

        string getCamStateText(int state)
        {
            switch(state)
            {
                case 0:
                    return "nečinný";
                case 10:
                    return "odosielam scénu";
                case 20:
                    return "odosielam trigger";
                case 30:
                    return "čakám na dáta";
                case 40:
                    return "čakám na výsledky";
                case 999:
                    return "inicializácia";
                default:
                    return "neznámy stav + (" + state + ")";
                    
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            //Thread.Sleep(100);
            //System.Windows.Forms.DoEvent();
            Application.DoEvents();
            PripojKPLC();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.odpojiť();
			Application.Exit();
        }

        private void btnPlcConnect_Click(object sender, EventArgs e)
        {
            PripojKPLC();
        }

		private void btnPlcDisconnect_Click(object sender, EventArgs e)
		{
			odpojiť();
		}
#region unused functions
		private void btnTrigger_Click(object sender, EventArgs e)
		{
			//Client.WriteArea(S7Consts.S7AreaDB, 1, DB1.manualTrigger, 1, S7Consts.S7WLByte, new byte[] { 1 });	
		}

		private void prgControl(int increment)
		{
			/*int prgNr = Convert.ToInt32(lblPrgNum.Text);

			//modify increment to count 0-31
			if (prgNr < 10 && increment < -1)
				increment = -prgNr;

			if (prgNr > 21 && increment > 1)
				increment = 31-prgNr;
			
			prgNr = prgNr + increment;

			lblPrgNum.Text = prgNr.ToString();
			//disable buttons when <0 or >31
			if (prgNr > 0)
			{
				btnPminus.Enabled = true;
				btnPminus2.Enabled = true;

			}
			else
			{
				btnPminus.Enabled = false;
				btnPminus2.Enabled = false;

			}
			
			if (prgNr < 31)
			{
				btnPplus.Enabled = true;
				btnPplus2.Enabled = true;

			}
			else
			{
				btnPplus.Enabled = false;
				btnPplus2.Enabled = false;

			}
			// center program number label
			int pMinusEnd = btnPminus.Left + btnPminus.Width;
			lblPrgNum.Left = pMinusEnd + ((btnPplus.Left - pMinusEnd)/2) - (lblPrgNum.Width / 2);
			*/
		}

		private void btnPminus_Click(object sender, EventArgs e)
		{
			//prgControl(-1);

		}

		private void btnPplus_Click(object sender, EventArgs e)
		{
			//prgControl(1);

		}

		private void btnSetPrg_Click(object sender, EventArgs e)
		{
			/*int prgNr = Convert.ToInt32(lblPrgNum.Text);
			//S7.SetByteAt(Buffer, 0, (byte)prgNr);
			//S7.SetByteAt(Buffer, 1, 1);
			Client.WriteArea(S7Consts.S7AreaDB, 1, DB1.pcPrgNr, 2, S7Consts.S7WLByte, new byte[] { (byte)prgNr, 1 });
			*/	
		}

		private void btnPminus2_Click(object sender, EventArgs e)
		{
			//prgControl(-10);
		}

		private void btnPplus2_Click(object sender, EventArgs e)
		{
			//prgControl(10);
		}

		private void btnForceOK_Click(object sender, EventArgs e)
		{
			//Client.WriteArea(S7Consts.S7AreaDB, 1, DB1.forceOK, 1, S7Consts.S7WLByte, new byte[] { 1 });
		}

		private void btnForceNOK_Click(object sender, EventArgs e)
		{
			//Client.WriteArea(S7Consts.S7AreaDB, 1, DB1.forceNOK, 1, S7Consts.S7WLByte, new byte[] { 1 });
		}
#endregion

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void PlcResultDisplayControl_Load(object sender, EventArgs e)
        {

        }
    }
}
