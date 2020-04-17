using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Salsana
{
    class DB
    {
        string folder = "Salsana";
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        

        public DB()
        { }
        public void WriteTo(PassWord pass)
        {
            mydocpath = Path.Combine(mydocpath, folder);
            BinaryWriter write = new BinaryWriter(File.Open(mydocpath, FileMode.OpenOrCreate));
            string p = pass.Pass;
            string s = pass.Service;
            write.Write(p);
            write.Write(s);
            
        }
        public void ReadFrom()
        {
            StreamReader read = new StreamReader();
        }

        public bool CheckPass(string pass)
        {
            bool login = false;
            string refrence = "kissa";

            if (pass == refrence)
            {
                login = true;
                MessageBox.Show("Tervetuloa");
                return login;
            }
            else {
                MessageBox.Show("Antamasi salasana oli väärä");
                return login;
            }          

        }

    }
}
