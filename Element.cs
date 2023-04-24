using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarList
{
    public class Element
    {
        public string name {get; set;}
        public string img { get; set;}
        public bool select { get; set;}
        public Element(string name, string img, bool select = false) 
        {
            this.name = name;
            this.img = img;
            this.select = select;
        }
    }
}
