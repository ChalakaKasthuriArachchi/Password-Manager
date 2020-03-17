using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _33_PasswordManager
{
    public class Data
    {
        // Message Boxes
        public static void Msgbx_E(string msg)
        {
            MessageBox.Show(msg, "Error [Password Manager]", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool Msgbx_W_YN(string msg)
        {
            if (MessageBox.Show(msg, "Warning [Password Manager]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                return true;
            return false;
        }
        public static bool LoadDatabse(string Key)
        {
            Database.Key = Key;
            Database.KeyLength = Key.Length;
            if ((DB = Database.DeSerialize()) != null)
                return true;
            else
                return false;
        }
        public static bool SaveDatabase()
        {
            return DB.Serialize();
        }
        public static Record GetRecord(int id)
        {
            foreach (Record r in DB.Records)
                if (r.ID == id)
                    return r;
            return null;
        }
        public static int ToInt(object value)
        {
            return int.Parse(value.ToString());
        }
        public static Record GetRecord(string aName,string anURL)
        {
            aName = aName.Trim().ToLower();
            anURL = anURL.Trim().ToLower();
            foreach (Record r in DB.Records)
                if (r.Name.ToLower() == aName || r.URL.ToLower() == anURL)
                    return r;
            return null;
        }
        public static Database DB = null;
    }
}
