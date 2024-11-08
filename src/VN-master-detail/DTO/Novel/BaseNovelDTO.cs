using DTO.Producer;
using DTO.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO.Novel
{
    public class BaseNovelDTO
    {
        public string id { get; set; }
        public SimpleProducerDTO[] developers { get; set; }

        public ImageDTO? image { get; set; }

        public string description { get; set; }

        /// <summary>
        /// Main title of the novel
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Average note given by the users
        /// Between 10 and 100 
        /// </summary>
        public int? average;

        [JsonConstructor]
        public BaseNovelDTO(string id, ImageDTO? image, string description, string title, int? average, SimpleProducerDTO[] developpers)
        {
            this.id = id;
            this.image = image;
            this.description = description;
            this.title = title;
            this.average = average;
            developers = developpers;
        }

        public BaseNovelDTO(BaseNovelDTO other)
        {
            id = other.id;
            image = other.image;
            description = other.description;
            title = other.title;
            average = other.average;
            developers = other.developers;
        }
    }
}
