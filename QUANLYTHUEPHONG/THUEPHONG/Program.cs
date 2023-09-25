using DataLayer;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace THUEPHONG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            //if(File.Exists("connectdb.dba"))
            //{
            //    string conStr = "";
            //    BinaryFormatter bf = new BinaryFormatter();
            //    FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            //    connect cp = (connect)bf.Deserialize(fs);
            //    string servername = Encryptor.Decrypt(cp.servername,"qwertyuiop", true);
            //    string user = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            //    string pass = Encryptor.Decrypt(cp.password, "qwertyuiop", true);
            //    string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);
            //    conStr += "Data Source=" + servername + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + pass + ";";
            //    connoi = conStr;
            //}
        }
    }
}
