using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    class DICTIONARY
    {
        public static Dictionary<char, String> STRANA = new Dictionary<char, string>();
        public static Dictionary<char, String> SVETLO = new Dictionary<char, string>();
        public static Dictionary<char, String> VERZIA = new Dictionary<char, string>();
        public static Dictionary<char, String> PRITOMNOST_KLUCKY = new Dictionary<char, string>();
        public static Dictionary<char, String> PRITOMNOST_BARKODU = new Dictionary<char, string>();
        public static Dictionary<char, String> FARBA = new Dictionary<char, string>();

        //"UVEX 8543"
        public static void dictionary_inic() {

            STRANA.Add('L', "Ľavá");
            STRANA.Add('R', "Pravá");
            STRANA.Add('l', "Ľavá");
            STRANA.Add('r', "Pravá");

            SVETLO.Add('E', "Elektrická");
            SVETLO.Add('N', "Neelektrická");
            SVETLO.Add('e', "Elektrická");
            SVETLO.Add('n', "Neelektrická");

            VERZIA.Add('V', "V526/V54x");
            VERZIA.Add('A', "520A");
            VERZIA.Add('v', "V526/V54x");
            VERZIA.Add('a', "520A");

            PRITOMNOST_KLUCKY.Add('N',"neprítomná");
            PRITOMNOST_KLUCKY.Add('P', "prítomná");
            PRITOMNOST_KLUCKY.Add('n', "neprítomná");
            PRITOMNOST_KLUCKY.Add('p', "prítomná");

            PRITOMNOST_BARKODU.Add('N', "neskenujem");
            PRITOMNOST_BARKODU.Add('S', "skenujem");
            PRITOMNOST_BARKODU.Add('n', "neskenujem");
            PRITOMNOST_BARKODU.Add('s', "skenujem");


            FARBA.Add('-',"Bez žalúzie");
        }





    }
}
