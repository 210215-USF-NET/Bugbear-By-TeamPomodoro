using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Story
    {
        public int StoryID { get; set; }
        public DateTime DateCreated { get; set; }
        public string StoryTitle { get; set; }
        public string StoryDescription { get; set; }
        public Campaign Campaign { get; set; }
    }
}
