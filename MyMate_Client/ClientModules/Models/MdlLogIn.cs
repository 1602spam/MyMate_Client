using ClientModules.Services;
using Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_to_Server;

namespace ClientModules.Classes
{
    public class MdlLogIn
    {
        public string ID { get; set; }
        public string PW { get; set; }

        public MdlLogIn()
        {
            this.ID = "";
            this.PW = "";
        }
        public MdlLogIn(string ID, string PW)
        {
            this.ID = ID;
            this.PW = PW;
        }
    }
}