using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeji.View.Controls
{
    public class MsgListBtn :Button
    {
      
        public MsgListBtn(string name,int index)
        {
            this.Name = name;
            this.BackColor = Color.FromArgb(191, 191, 191);
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(150, 40);
            this.Location = new Point();
            this.Click += MsgListBtn_Click;
        }

        private void MsgListBtn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
