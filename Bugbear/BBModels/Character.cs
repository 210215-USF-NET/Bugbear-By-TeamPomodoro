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
        public List<Item> ItemList { get; set; }
        public int Money { get; set; }
        public int UserID { get; set; }

        //========================================
        public int HP { get; set; }
        public int XPLevel { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

    }
}
