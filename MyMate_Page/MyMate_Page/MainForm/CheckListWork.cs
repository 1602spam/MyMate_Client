using ClientModules.Models.CheckList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class CheckListWork
    {
        private string work = "";
        private string workCode;
        /*
        private string CodetoString;
        private int workCode;
        public int WorkCode
        {
            get { return workCode; }
            set
            {
                workCode = value;
                CodetoString = workCode.ToString();
            }
        }

        */
        private bool isChecked = false;
        public MdlProject item { get; set; }
        public CheckListWork(MdlProject item)
        {
            this.item = item;
        }
        //public MdlProjectItem item { get; set; }

        /*
         * public CheckListWork(MdlProjectItem item) 
        {
            this.item = item;
        }
        */
        public string Work
        {
            get { return work; }
            set { work = value; }
        }

        public string WorkCode
        {
            get { return workCode; }
            set { workCode = value; }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; }
        }

        public CheckListWork(string work, int workCode)
        {
            this.Work = work;
            this.WorkCode = Convert.ToString(workCode);
        }
    }
}
