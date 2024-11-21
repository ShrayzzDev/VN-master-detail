using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Producer
{
    public class DetailedProducerDTO
    {
        public string id;

        public string name;

        public string? original;

        public string[] aliases;

        public string lang;

        /// <summary>
        /// type of producer :
        /// co = company
        /// in = individual
        /// ng = amateur group
        /// </summary>
        public string type;

        public string description;

        public DetailedProducerDTO(string id, string name, string? original, string[] aliases, string lang, string type, string description)
        {
            this.id = id;
            this.name = name;
            this.original = original;
            this.aliases = aliases;
            this.lang = lang;
            this.type = type;
            this.description = description;
        }
    }
}
