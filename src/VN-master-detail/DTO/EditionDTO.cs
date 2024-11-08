using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EditionDTO
    {
        /// <summary>
        /// Edition Id
        /// NOTE : This only unique relative
        /// to the VN it is linked to.
        /// </summary>
        public string eid;

        public string langage;

        public string name;

        public bool official;

        public EditionDTO(string eid, string langage, string name, bool official)
        {
            this.eid = eid;
            this.langage = langage;
            this.name = name;
            this.official = official;
        }
    }
}
