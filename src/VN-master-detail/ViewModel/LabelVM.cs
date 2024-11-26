using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LabelVM
    {
        internal Label label = new();

        public string Name
        {
            get => label.Name;
        }

        internal int Id
        {
            get => label.Id;
        }

        public override string ToString()
        {
            return $"[{Id}] : {Name}";
        }
    }
}
