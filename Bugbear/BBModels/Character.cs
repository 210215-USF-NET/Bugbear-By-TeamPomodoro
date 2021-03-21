using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Character
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
        //public string CharacterStrats { get; set; }
        public List<Item> ItemList { get; set; }
        public int Money { get; set; }
        public int UserID { get; set; }

    }
}
