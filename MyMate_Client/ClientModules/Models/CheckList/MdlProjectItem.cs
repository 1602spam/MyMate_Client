using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.CheckList
{
    public class MdlProjectItem
    {
        public int Code { get; set; }
        public int ProjectCode { get; set; }
        public int ManagerCode { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
