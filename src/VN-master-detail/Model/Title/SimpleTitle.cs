using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Title
{
    public class SimpleTitle
    {
        public string latin { get; set; }

        public string title { get; set; }

        public SimpleTitle(string latin, string title)
        {
            this.latin = latin;
            this.title = title;
        }
    }
}
