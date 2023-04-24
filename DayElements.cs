using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarList
{
    public class DayElements
    {
        public DateTime date { get; set; }
        public List<Element> elements { get; set; }
        public DayElements(DateTime date, List<Element> elements)
        {
            this.date = date;
            this.elements = elements;
        }
    }
}
