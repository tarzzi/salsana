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
            StreamWriter write = new StreamWriter(File.Open(mydocpath, FileMode.OpenOrCreate));
            List<PassWord> passes = new List<PassWord>();
            
        }
        public void ReadFrom()
        {
            List<PassWord> pwlist = new List<PassWord>();
            PassWord pw = new PassWord();
            StreamReader read = null;
            read = new StreamReader(File.Open(mydocpath, FileMode.Open));
            try
            {
                while (!read.EndOfStream)
                {
                    pw.Pass = read.ReadLine();
                    pw.Service = read.ReadLine();
                    pwlist.Add(pw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                read.Close();
            }
            


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
