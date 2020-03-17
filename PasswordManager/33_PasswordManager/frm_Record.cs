using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _33_PasswordManager
{
    public partial class frm_Record : Form
    {
        private enum RecordState { New , Edit};
        private RecordState State = RecordState.New;  
        public frm_Record()
        {
            InitializeComponent();
            SetCustomSource();
            txt_ID.Text = Data.DB.ID.ToString();
        }
        public void SetCustomSource()
        {
            foreach (Record r in Data.DB.Records)
                if (r.UserName != null)
                    txt_UserName.AutoCompleteCustomSource.Add(r.UserName);
        }
        public frm_Record(Record aRecord)
        {
            InitializeComponent();
            State = RecordState.Edit;
            /* Initializing Data */
            txt_ID.Text = aRecord.ID.ToString();
            txt_Name.Text = aRecord.Name;
            txt_Password.Text = aRecord.Password;
            txt_URl.Text = aRecord.URL;
            txt_UserName.Text = aRecord.UserName;
            SetCustomSource();
        }

        private void lbl_ShowPass_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '*')
                txt_Password.PasswordChar = '\0';
            else
                txt_Password.PasswordChar = '*';
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (State == RecordState.New)
            {
                if (!Contains())
                {
                    Data.DB.Records.Add(new Record(
                        txt_ID.Text,
                        txt_Name.Text,
                        txt_URl.Text,
                        txt_UserName.Text,
                        txt_Password.Text));
                    Data.DB.ID++;
                }
                else
                    return;
            }
            else
            {
                Record rec = Data.GetRecord(int.Parse(txt_ID.Text));
                if (rec != null)
                {
                    rec.Name = txt_Name.Text;
                    rec.Password = txt_Password.Text;
                    rec.URL = txt_URl.Text;
                    rec.UserName = txt_UserName.Text;
                }
                else
                { Data.Msgbx_E("Unable to Find Record"); return; }
            }
            /* Exit */
            if (Data.SaveDatabase())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool Contains()
        {
            Record R = Data.GetRecord(txt_Name.Text,txt_URl.Text);
            if (R == null)
                return false;
            else
            {
                string msg = "WebSite already Exists!\n" +
                    "\tID\t: " + R.ID +
                    "\n\tName\t: " + R.Name + 
                    "\n\tURL\t: " + R.URL +
                    "\n\nDo you want to Continue?";
                if (Data.Msgbx_W_YN(msg))
                    return false;
                return true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
