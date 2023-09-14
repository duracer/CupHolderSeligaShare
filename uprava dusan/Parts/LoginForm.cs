using System.Windows.Forms;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public partial class LoginForm : Form
    {
        public LoginForm(){
            InitializeComponent();
        }

        public string InputPassword{
            get { return textBoxPassword.Text; }
        }
    }
}