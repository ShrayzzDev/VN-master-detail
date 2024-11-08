using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AliasDTO
    {
        public string aid;

        public string name;

        public string latin;

        public bool isMain;

        public AliasDTO(string aid, string name, string latin, bool isMain)
        {
            this.aid = aid;
            this.name = name;
            this.latin = latin;
            this.isMain = isMain;
        }
    }
}
