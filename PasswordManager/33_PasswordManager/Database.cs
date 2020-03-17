using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _33_PasswordManager
{
    [Serializable]
    public sealed class Database
    {
        public Database()
        {
            Records = new List<Record>();
        }

        public bool Serialize()
        {
            try
            {
                //Definning Streams & Formatter
                MemoryStream memStream = new MemoryStream();
                FileStream fStream = new FileStream(PATH, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                /* Serialization */
                formatter.Serialize(memStream, this);
                /*Encrypting & Saving*/
                memStream.Seek(0, SeekOrigin.Begin);
                long length = memStream.Length;
                for (int x = 0; x < length; x++)
                    fStream.WriteByte(Encrypt(memStream.ReadByte(), x));
                fStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                Data.Msgbx_E("Unable to Save Database\n\n" +
                            "Additional Information:\n" + ex.Message);
                return false;
            }
        } 
        public static bool Exists
        {
            get
            {
                return File.Exists(PATH);
            }
        }
        public static Database DeSerialize()
        {
            FileStream fStream = null ;
            MemoryStream memStream = null;
            try
            {
                /* Declaration */
                fStream = new FileStream(PATH, FileMode.Open);
                memStream = new MemoryStream();
                IFormatter formatter = new BinaryFormatter();
                /* Reading & DeCrypting */
                for (int x = 0; x < fStream.Length; x++)
                    memStream.WriteByte(Decrypt(fStream.ReadByte(), x));
                /* Deserialization */
                memStream.Seek(0, SeekOrigin.Begin);
                return (Database)formatter.Deserialize(memStream);
            }
            catch(FileNotFoundException)
            {
                Database db = new Database();
                db.Serialize();
                return db;
            }
            catch (SerializationException)
            {
                Data.Msgbx_E("Invalid Password");
                return null;
            }
            catch(Exception ex)
            {
                Data.Msgbx_E("Unable to Load Database\n\n" +
                           "Additional Information:\n" + ex.Message);
                return null;
            }
            finally
            {
                if (fStream != null)
                    fStream.Close();
                if (memStream != null)
                    memStream.Close();
            }
        }
        public byte Encrypt(int aByte,int index)
        {
            return (byte)((aByte + (int)Key[index % KeyLength]));
        }
        public static byte Decrypt(int aByte, int index)
        {
            return (byte)((aByte - (int)Key[index % KeyLength]));
        }
        public int ID = 0;
        public List<Record> Records = null;
        [NonSerialized]
        public static string Key = "0";
        public static int KeyLength = 1;
        public const string PATH = "Database.db";
    }
}
