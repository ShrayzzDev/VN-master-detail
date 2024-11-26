using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LabelDTO
    {
        public int id { get; set; } = -1;

        public string name { get; set; } = string.Empty;

        public LabelDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public LabelDTO() { }
    }
}
