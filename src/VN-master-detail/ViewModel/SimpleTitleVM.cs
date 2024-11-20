using Model.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SimpleTitleVM
    {
        internal SimpleTitle simpleTitle = new();

        public string Title
        {
            get => simpleTitle.title;
        }

        public string Latin
        {
            get => simpleTitle.latin;
        }
    }
}
