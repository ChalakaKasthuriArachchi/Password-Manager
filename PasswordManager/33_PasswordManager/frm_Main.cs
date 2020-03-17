using MetroFramework.Forms;
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
    
    public partial class frm_Main : MetroForm
    {
        class SortRecords : IComparer<Record>
        {
            public int Compare(Record x, Record y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
        public frm_Main()
        {
            InitializeComponent();
            SetRecords();
        }
        public void SetRecords()
        {
            
            int x = 1;
            if (dgv_Password.Rows.Count > 0)
                dgv_Password.Rows.Clear();
            if(Data.DB.Records != null)
            {
                Data.DB.Records.Sort(new SortRecords());
            }
            foreach (Record rec in Data.DB.Records)
            {
                DataGridViewButtonCell btn = new DataGridViewButtonCell();
                btn.Value = "Copy Password";
                btn.ToolTipText = rec.Password;
                dgv_Password.Rows.Add(
                    x.ToString(),
                    rec.ID,
                    rec.Name,
                    rec.URL,
                    rec.UserName);
                dgv_Password[5, x - 1] = btn;
                x++;
            }
        }
        private void btn_CopyPassword_Click(object sender,EventArgs e)
        {
            Clipboard.SetText(((DataGridViewButtonCell)sender).ToolTipText);
        }
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_Record rec = new frm_Record();
            if (rec.ShowDialog() == DialogResult.OK)
                SetRecords();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_pass.PasswordWindow.Close();
        }

        private void dgv_Password_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               Clipboard.SetText(senderGrid[e.ColumnIndex, e.RowIndex].ToolTipText);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Password.SelectedRows.Count > 0)
            {
                int iD = Data.ToInt(dgv_Password.SelectedRows[0].Cells[1].Value);
                Record rec = Data.GetRecord(iD);
                frm_Record frm = new frm_Record(rec);
                if (frm.ShowDialog() == DialogResult.OK)
                    SetRecords();
            }
            else
                Data.Msgbx_E("No Records Selected");
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Record rec in Data.DB.Records)
            {
                sb.AppendLine(rec.ID + ")." + rec.Name);
                sb.AppendLine("URL : " + rec.URL);
                sb.AppendLine("USERNAME : " + rec.UserName);
                sb.AppendLine("PASSWORD : " + rec.Password);
                sb.AppendLine("-------------------------------------------------\n\n");
            }
            Clipboard.SetText(sb.ToString());
        }
    }
}
