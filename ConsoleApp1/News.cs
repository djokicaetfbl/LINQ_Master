using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    enum NewsPriority
    {
        Low = 1,
        Medium = 2,
        High = 3,
    }
    internal class News
    {
        public News(NewsPriority priority, DateTime newsDateTime, string newsTitle)
        {
            Priority = priority;
            NewsDateTime = newsDateTime;
            NewsTitle = newsTitle;
        }

        public NewsPriority Priority { get; set; }
        public DateTime NewsDateTime { get; set; }

        public string NewsTitle {get; set;}

        public override string? ToString()
        {
            return Priority + ", " + NewsDateTime + ", " + NewsTitle;
        }

    }
}
