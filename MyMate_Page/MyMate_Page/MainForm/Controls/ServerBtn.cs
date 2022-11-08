using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
	public partial class ServerBtn : UserControl
	{
		
		
		string sName;

		public ServerBtn(string SName)
		{
			InitializeComponent();
			sName = SName;
			string name;
			if(SName.Length>4)
			{
				name = SName.Substring(0, 4);
			}
			else
			{
				name = SName;
			}
			
			SBtn.Text = name;
            ServerPage SPage = new ServerPage(sName);
            MainPage.serverPages.Add(SPage);

            SBtn.Click += new EventHandler(SBtn_Click);
		}

		void SBtn_Click(object sender, EventArgs e)
		{
			

		}
	}
}
