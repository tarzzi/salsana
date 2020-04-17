using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salsana
{
    class PassWord
    {
        public PassWord() { }

        public PassWord(string service, string pass)
        {
            Service = service;
            Pass = pass;
        }

        public string Service { get; set; }
        public string Pass { get; set; }


    }
}
