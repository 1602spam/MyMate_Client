using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Calendar
{
    public class MdlScheduleItem
    {
        public int Code { get; set; }
        public int ScheduleCode { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Content { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsDone { get; set; }
    }
}
