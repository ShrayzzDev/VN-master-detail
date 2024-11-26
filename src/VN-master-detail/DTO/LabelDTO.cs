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

        public string label { get; set; } = string.Empty;

        public LabelDTO(int id, string name)
        {
            this.id = id;
            this.label = name;
        }

        public LabelDTO() { }
    }
}
