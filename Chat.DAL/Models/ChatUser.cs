using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DAL.Models
{
    public class ChatUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartPing { get; set; }
        public DateTime LastPing { get; set; }
    }
}
