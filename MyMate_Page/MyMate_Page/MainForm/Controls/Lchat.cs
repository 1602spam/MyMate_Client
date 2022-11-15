using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class Lchat : UserControl
	{
		public int ChatPanelSize { get; set; }

		public MdlMessage? mdlMessage { get; set; }

		public string? Message
		{
			get
			{
				return chatLabel.Text;
			}
			set
			{
				chatLabel.Text = value;
				SetChatLocation();
			}
		}

		public Lchat(int chatPanelSize, MdlMessage? m)
		{
			ChatPanelSize = chatPanelSize;
			InitializeComponent();
            this.mdlMessage = m;
		}

		// 값을 넣어주는 메소드
        public void Initialize(MdlMessage? m)
        {
            if (mdlMessage == null)
                return;
			this.mdlMessage = m;
			DateTime d = DateTime.Now;

			/*
			if ()
			{
				if (mdlMessage.Time.Hour > 12) { this.dateLabel.Text = mdlMessage.Time.ToString("오늘 오후 h:mm"); }
				else { this.dateLabel.Text = mdlMessage.Time.ToString("오늘 오전 h:mm"); }
			}
			else if (d.Day == mdlMessage.Time.Day - 1 && d.Month == mdlMessage.Time.Month && d.Year == mdlMessage.Time.Year)
            {
                if (mdlMessage.Time.Hour > 12) { this.dateLabel.Text = mdlMessage.Time.ToString("어제 오후 h:mm"); }
                else { this.dateLabel.Text = mdlMessage.Time.ToString("어제 오전 h:mm"); }
            }
			else*/
			{
				this.dateLabel.Text = mdlMessage.Time.ToString("yyyy-MM-dd");
			}
            this.nameLabel.Text = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == mdlMessage.Creator).Name;
            this.Message = mdlMessage.Context;
            
            //ChatLocation();
        }

        public static int GetTextHeight(Label lbl)
		{
			using (Graphics g = lbl.CreateGraphics())
			{
				SizeF size = g.MeasureString(lbl.Text, lbl.Font);
				return (int)Math.Ceiling(size.Height);
			}
		}

		public static int GetTextWidth(Label lbl)
		{
			using (Graphics g = lbl.CreateGraphics())
			{
				SizeF size = g.MeasureString(lbl.Text, lbl.Font);
				return (int)Math.Ceiling(size.Width);
			}
		}

		

		private void SetChatLocation()
		{
			// 패널의 최대크기
			chatLabel.MaximumSize = new Size(ChatPanelSize / 3 * 2, 0);

			// 텍스트의 높이, 넓이 지정
			chatLabel.Height = GetTextHeight(chatLabel);
			chatLabel.Width = GetTextWidth(chatLabel);

			// 패널의 높이, 넓이 지정
			chatBtn.Height = chatLabel.Height + 17;
			chatBtn.Width = chatLabel.Width + 17;

			// 배경패널의 높이 지정
			//this.Height = chatBtn.Bottom + 10;

			// 이름의 위치 지정
			dateLabel.Location = new Point(chatBtn.Location.X + chatBtn.Width, chatBtn.Location.Y + chatBtn.Height- GetTextHeight(dateLabel) + 2);
            this.Height = dateLabel.Bottom + 10;

        }

		private void Lchat_Load(object sender, EventArgs e)
		{
            this.Initialize(mdlMessage);
        }

		private void roundButton2_Click(object sender, EventArgs e)
		{
			MdlUser? user = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == mdlMessage.Creator);
			if (user != null)
			{
				UserProfilePopup profile = new UserProfilePopup(user);
				profile.ShowDialog();
			}
        }
	}
}
