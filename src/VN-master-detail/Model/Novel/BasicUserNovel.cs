using Model.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Novel
{
    public class BasicUserNovel : BaseNovel
    {
        /// <summary>
        /// When was the novel added to the list.
        /// NOTE : This is an Unix Timestamp.
        /// </summary>
        public int Added { get; set; }

        /// <summary>
        /// When the user voted.
        /// Null if not.
        /// </summary>
        public int? Voted { get; private set; }

        /// <summary>
        /// Between 10-100
        /// </summary>
        public int? Vote { get; private set; }

        public BasicUserNovel(string id, Image? image, string description, string title, float? average, SimpleProducer[] developpers, int added, int? voted, int? vote)
            : base(id, image, description, title, average, developpers)
        {
            Added = added;
            Voted = voted;
            Vote = vote;
        }

        public BasicUserNovel()
            : this("", new Image(), "", "", 0, [], 0, 0, 0) { }
    }
}
