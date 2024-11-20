using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Producer
{
    public class SimpleProducer
    {
        public string id { get; set; }

        public string name { get; set; }

        public string type { get; set; }

        public string description { get; set; }

        public SimpleProducer(string id, string name, string type, string description)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
        }

        public SimpleProducer() 
            : this("", "", "", "") { }

        public override string ToString()
        {
            return $"Id: {id}\n" +
                   $"Name: {name}\n" +
                   $"Type: {type}\n" +
                   $"Description: {description}\n";
        }
    }
}
