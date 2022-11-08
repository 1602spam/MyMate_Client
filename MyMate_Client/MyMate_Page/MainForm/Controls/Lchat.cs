using ClientModules.Containers;
using ClientModules.Models.Chat;
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
                ChatLocation();
            }
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

        public Lchat(int chatPanelSize, MdlMessage? m)
        {
            InitializeComponent();
            ChatPanelSize = chatPanelSize;
            this.Initialize(m);
        }

        public void Initialize(MdlMessage? m)
        {
            this.mdlMessage = m;
            if (mdlMessage == null)
                return;
            this.Message = mdlMessage.Context;
            this.dateLabel.Text = mdlMessage.Time.ToString("yyyy-MM-dd");
            this.nameLabel.Text = UserContainer.Instance.Items.Values.First(MdlUser => MdlUser.Code == mdlMessage.Creator).Name;
        }

        private void ChatLocation()
        {
            chatLabel.MaximumSize = new Size(ChatPanelSize / 3 * 2, 0);

            chatLabel.Height = GetTextHeight(chatLabel);
            chatLabel.Width = GetTextWidth(chatLabel);

            chatBtn.Height = chatLabel.Height + 17;
            chatBtn.Width = chatLabel.Width + 17;

            this.Height = chatBtn.Bottom + 10;
            
            nameLabel.Location = new Point(chatBtn.Location.X + chatBtn.Width - nameLabel.Width, dateLabel.Location.Y);
        }
    }
}
