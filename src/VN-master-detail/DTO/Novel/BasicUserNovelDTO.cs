﻿using DTO.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Novel
{
    public class BasicUserNovelDTO : BaseNovelDTO
    {
        /// <summary>
        /// When was the novel added to the list.
        /// NOTE : This is an Unix Timestamp.
        /// </summary>
        public int added { get; set; }

        /// <summary>
        /// When the user voted.
        /// Null if not.
        /// </summary>
        public int? voted { get; set; }

        /// <summary>
        /// Between 10-100
        /// </summary>
        public int? vote { get; set; }

        public BasicUserNovelDTO(string id, ImageDTO? image, string description, string title, float? average, SimpleProducerDTO[] developpers, int added, int? voted, int? vote)
            : base(id, image, description, title, average, developpers)
        {
            this.added = added;
            this.voted = voted;
            this.vote = vote;
        }
    }
}
