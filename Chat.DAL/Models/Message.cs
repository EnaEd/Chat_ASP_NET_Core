using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DAL.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ChatUser User { get; set; }
        public string MessageText { get; set; }
    }
}
