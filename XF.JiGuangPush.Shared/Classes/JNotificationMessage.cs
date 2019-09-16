using System;
using System.Collections.Generic;
using System.Text;

namespace XF.JiGuangPush.Shared.Classes
{
    public class JNotificationMessage
    {
        public string Category { get; set; }
        public string ChannelId { get; set; }
        public string Extras { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int NotifcationId { get; set; }
    }
}
