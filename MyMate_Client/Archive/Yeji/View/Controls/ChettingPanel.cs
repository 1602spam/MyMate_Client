using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeji.View.Controls
{
    public class ChettingPanel : Panel
    {
        public ChettingPanel()
        {
            this.BackColor = Color.FromArgb(242, 242, 242);
            this.Dock = DockStyle.Fill;
            Location = new Point(150, 0);

        }
    }
}
