using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.staff
{
    public class DetailedStaffDTO
    {
        public string id;

        public int aid;

        public string name;

        public string? original;

        public string lang;

        public string gender;

        public string description;

        public string[] extlinks;

        public AliasDTO[] aliases;

        public DetailedStaffDTO(string id,
                             int aid, 
                             string name,
                             string? original, 
                             string lang,
                             string gender,
                             string description,
                             string[] extlinks,
                             AliasDTO[] aliases)
        {
            this.id = id;
            this.aid = aid;
            this.name = name;
            this.original = original;
            this.lang = lang;
            this.gender = gender;
            this.description = description;
            this.extlinks = extlinks;
            this.aliases = aliases;
        }
    }
}
