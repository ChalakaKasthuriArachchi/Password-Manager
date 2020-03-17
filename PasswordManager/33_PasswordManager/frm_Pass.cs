using MetroFramework.Forms;
using System.Windows.Forms;

namespace _33_PasswordManager
{
    public partial class frm_pass : MetroForm
    {
        public static frm_pass PasswordWindow = null;
        string Previous = "";
        public frm_pass()
        {
            InitializeComponent();
            PasswordWindow = this;
            if (!Database.Exists)
                Text = "Enter A New Password";
            Focus();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Return)
            {
                if (!Database.Exists)
                {
                    if(Previous.Length == 0)
                    {
                        Previous = txt_Password.Text;
                        txt_Password.Clear();
                        Text = "Confirm Password";
                        return;
                    }
                    else
                    {
                        if(txt_Password.Text != Previous)
                        {
                            Data.Msgbx_E("Confirm Password Doesn't Match");
                            Previous = "";
                            txt_Password.Clear();
                            Text = "Enter A New Password";
                            return;
                        }
                    }
                }
                if (Data.LoadDatabse(txt_Password.Text))
                {
                    frm_Main frm = new frm_Main();
                    frm.Show();
                    Hide();
                }
            }
        }
    }
}
