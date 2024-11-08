using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Title
{
    public class SimpleTitleDTO
    {
        public string latin;

        public string title;

        public SimpleTitleDTO(string latin, string title)
        {
            this.latin = latin;
            this.title = title;
        }
    }
}
