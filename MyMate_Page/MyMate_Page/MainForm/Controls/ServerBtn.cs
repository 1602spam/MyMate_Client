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
		//MainPage mainPage;
		public ServerBtn(string SName)
        {
			InitializeComponent();
			this.Name = SName;

			string name;
			if (Name.Length > 2)
			{
				name = Name.Substring(0, 2);
			}
			else
			{
				name = Name;
			}

			SBtn.Text = name;
			//ServerPage SPage = new ServerPage(SName);
			//MainPage.serverPages.Add(SPage);


			SBtn.Click += new EventHandler(SBtn_Click);
			
			//this.mainPage = mainPage;
		}

		void SBtn_Click(object sender, EventArgs e)
		{
			if(MainPage.mainPage != null)
				MainPage.mainPage.ServerPageChange(this.Name);
			/*
            for (int i= 0; i < MainPage.serverPages.Count; i++)
			{
                if (this.Name == MainPage.serverPages[i].Name)
                {
					MainPage.ServerPageIndex = i;
					
					//MainPage.ControlCollection.ReferenceEquals
					
                }
            }
			*/
		}
	}
}
