using Model.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Novel
{
    public class BaseNovel
    {
        public string Id { get; set; }
        public SimpleProducer[] Developpers { get; set; }

        public Image? Image { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Main title of the novel
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Average note given by the users
        /// Between 10 and 100 
        /// </summary>
        public float Average { get; set; }

        public BaseNovel(string id, Image? image, string description, string title, float? average, SimpleProducer[] developpers)
        {
            Id = id;
            Image = image;
            Description = description;
            Title = title;
            if (average != null && average > 100) throw new ArgumentException("Average can't be over 100");
            if (average != null && average < 10) throw new ArgumentException("Average can't be under 10");
            Average = average == null ? 10 : average.Value;
            Developpers = developpers;
        }

        public BaseNovel(BaseNovel other)
        {
            Id = other.Id;
            Image = other.Image;
            Description = other.Description;
            Title = other.Title;
            Average = other.Average;
            Developpers = other.Developpers;
        }
    }
}
