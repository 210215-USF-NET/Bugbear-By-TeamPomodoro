using System;
using System.Collections.Generic;

namespace BBModels
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public List<Character> Characters { get; set; }
    }
}
