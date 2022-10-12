using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jin.Classes
{
    public class MdlChatroom
    {
        public int? ChatroomCode { get; set; }
        public int? ServerCode { get; set; }
        public string? Message { get; set; }
        public string? Date { get; set; }
        public int? MessageType { get; set; }
    }
}
