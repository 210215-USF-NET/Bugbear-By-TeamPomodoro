using System;

namespace BBModels
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }
        public string Phone { get; set; }//is string best for this? maybe there's a diff type that is better?

    }
}
