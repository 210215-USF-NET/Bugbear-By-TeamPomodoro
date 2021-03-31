using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Chat
    {
        public int ChatID { get; set; }
        public User User { get; set; }
        public string ChatMessage { get; set; }
    }
}
