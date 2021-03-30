using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Map
    {
        public int MapID { get; set; }
        public string MapTitle { get; set; }
        public byte[] MapImage { get; set; }
        public Campaign Campaign { get; set; }
    }
}
