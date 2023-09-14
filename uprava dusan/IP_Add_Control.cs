using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    class IP_Add_Control
    {
        Form owner;
        List<string> IP_List;
        public List<IPAddress> IP_Add_List;

        public IP_Add_Control(Form owner, List<string> pIP_List)
        {
            
            this.owner = owner;
            this.IP_List = pIP_List; 
            IP_Add_List = new List<IPAddress>();
        }
        
        
        static IPAddress isOK(string pIP_ADD) {

            const int ipAddressPartsCount = 4;
            
            MatchCollection match = Regex.Matches(pIP_ADD, "[0-9]+");
            if (match.Count != ipAddressPartsCount)
            {
                return null;
            }
            var ipParts = new byte[ipAddressPartsCount];
            for (int i = 0; i < ipAddressPartsCount; i++)
            {
                //kontrola ci je mozne jednotlive oktety previest na byte [0..256]
                bool successParse = byte.TryParse(match[i].ToString(), out ipParts[i]);
                if (successParse) continue;
                return null;
            }
            //errorProvider.Clear();
            return new IPAddress(ipParts);
        }

        


        public bool kontrolujIPs() 
        {
            int index = 0;
            IPAddress IP_pom;
            foreach (string IP in IP_List) {
                if ((IP_pom = isOK(IP)) == null) {
                    MessageBox.Show(owner, "Chyba vo formáte IP adresy v konfiguračnomm súbore (IP"+(index+1).ToString()+")","Chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
                IP_Add_List.Add(IP_pom);
                index++;
            }
            return true;
        }


    }
}
