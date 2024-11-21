using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Title
{
    public class DetailedTitle
    {
        public string lang;

        public string title;

        public string latin;

        public bool official;

        public bool main;

        public DetailedTitle(string lang, string title, string latin, bool official, bool main)
        {
            this.lang = lang;
            this.title = title;
            this.latin = latin;
            this.official = official;
            this.main = main;
        }

        public override string ToString()
        {
            return $"Lang: {lang} \n" +
                   $"Title: {title} \n" +
                   $"Latin: {latin} \n" +
                   $"Official: {official} \n" +
                   $"Main : {main} \n";
        }
    }
}
