using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class Rchat : UserControl
    {
        public int ChatPanelSize { get; set; }

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

        public MdlMessage? mdlMessage { get; set; }

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

        public Rchat(int chatPanelSize, MdlMessage? m)
        {
            ChatPanelSize = chatPanelSize;
            InitializeComponent();
            this.mdlMessage = m;            
        }

        public void Initialize(MdlMessage? m)
        {
            this.mdlMessage = m;
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
            this.Message = mdlMessage.Context;
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            this.dateLabel.Text = mdlMessage.Time.ToString("yyyy-MM-dd");
            this.nameLabel.Text = MdlMyself.Instance.Name;
        }

        private void ChatLocation()
        {
            chatLabel.MaximumSize = new Size(ChatPanelSize / 3 * 2, 0);

            chatLabel.Height = GetTextHeight(chatLabel);
            chatLabel.Width = GetTextWidth(chatLabel);

            chatBtn.Height = chatLabel.Height + 17;
            chatBtn.Width = chatLabel.Width + 17;

            this.Height = chatBtn.Bottom + 10;
            chatBtn.Location = new Point(ChatPanelSize - chatBtn.Width - 27, chatBtn.Location.Y);
            chatLabel.Location = new Point(ChatPanelSize - chatLabel.Width - 35, chatLabel.Location.Y);
            dateLabel.Location = new Point(chatBtn.Location.X - GetTextWidth(dateLabel) - 5, chatBtn.Location.Y + chatBtn.Height - GetTextHeight(dateLabel));
            nameLabel.Location = new Point(ChatPanelSize - GetTextWidth(nameLabel) - 37, nameLabel.Location.Y);
        }

        private void Rchat_Load(object sender, EventArgs e)
        {
            this.Initialize(mdlMessage);
        }
    }
}
