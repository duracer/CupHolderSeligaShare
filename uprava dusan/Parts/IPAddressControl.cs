using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class IPAddressControl : UserControl
    {
        private bool enableIPAddress;
        private bool enablePortNo;

        public IPAddressControl(){
            InitializeComponent();
            MaskedTextBoxIpAddressValidating(this, null); //funkcia je volana manualne v konstruktore komponentu IPAddressControl
                                                          //ale aj automaticky pri strate zamerania textboxu maskedTextBoxIpAddress (vlastnosť Validating)   
            TextBoxPortNoValidating(this, null);
        }

        public IPAddress IpAddress { private set; get; }
        public ushort PortNo { private set; get; }

        public bool EnableAddress{
            get { return enableIPAddress && enablePortNo; }
        }

        private void MaskedTextBoxIpAddressValidating(object sender, CancelEventArgs e){
            const int ipAddressPartsCount = 4;
            MatchCollection match = Regex.Matches(maskedTextBoxIpAddress.Text, "[0-9]+");
            if (match.Count != ipAddressPartsCount){
                SetIPAddressDisable();
                return;
            }
            var ipParts = new byte[ipAddressPartsCount];
            for (int i = 0; i < ipAddressPartsCount; i++){
                //kontrola ci je mozne jednotlive oktety reviest na byte [0..256]
                bool successParse = byte.TryParse(match[i].ToString(), out ipParts[i]);
                if (successParse) continue;
                SetIPAddressDisable();
                return;
            }
            errorProvider.Clear();
            IpAddress = new IPAddress(ipParts);
            enableIPAddress = true;
            return;
        }

        private void SetIPAddressDisable(){
            errorProvider.SetError(maskedTextBoxIpAddress, "Error");
            enableIPAddress = false;
        }

        private void TextBoxPortNoValidating(object sender, CancelEventArgs e){
            ushort portNo;
            enablePortNo = ushort.TryParse(textBoxPortNo.Text, out portNo);
            if (enablePortNo){
                errorProvider.Clear();
                PortNo = portNo;
            }
            else{
                errorProvider.SetError(textBoxPortNo, "Error");
            }
        }
    }
}