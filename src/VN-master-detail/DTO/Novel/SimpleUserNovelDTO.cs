using DTO.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Novel
{
    public class SimpleUserNovelDTO
    {
        /// <summary>
        /// When was the novel added to the list.
        /// NOTE : This is an Unix Timestamp.
        /// </summary>
        public int added;

        /// <summary>
        /// When the user voted.
        /// Null if not.
        /// </summary>
        public int? voted;

        /// <summary>
        /// Between 10-100
        /// </summary>
        public int? vote;

        public BaseNovelDTO vn;

        public SimpleUserNovelDTO(string id, ImageDTO? image, string description, string title, float? average, SimpleProducerDTO[] developpers, int added, int? voted, int? vote)
        {
            this.added = added;
            this.voted = voted;
            this.vote = vote;
            vn = new BaseNovelDTO(id, image, description, title, average, developpers);
        }
    }
}
