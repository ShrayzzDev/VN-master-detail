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
        public int average { get; set; }

        public BaseNovel(string id, Image? image, string description, string title, int? average, SimpleProducer[] developpers)
        {
            Id = id;
            Image = image;
            Description = description;
            Title = title;
            this.average = average == null ? 0 : average.Value;
            Developpers = developpers;
        }

        public BaseNovel(BaseNovel other)
        {
            Id = other.Id;
            Image = other.Image;
            Description = other.Description;
            Title = other.Title;
            average = other.average;
            Developpers = other.Developpers;
        }
    }
}
