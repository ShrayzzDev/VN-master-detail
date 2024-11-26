using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Label(int id, string name)
    {
        public int Id = id;

        public string Name = name;

        public Label()
            :this(0, "") { }
    }
}
