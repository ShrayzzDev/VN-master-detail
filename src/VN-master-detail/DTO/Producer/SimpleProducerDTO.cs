
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Producer
{
    public class SimpleProducerDTO
    {
        public string id;

        public string name;

        public string type;

        public string description;

        public SimpleProducerDTO(string id, string name, string type, string description)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
        }

        public override string ToString()
        {
            return $"Id: {id}\n" +
                   $"Name: {name}\n" +
                   $"Type: {type}\n" +
                   $"Description: {description}\n";
        }
    }
}
