using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO.Novel
{
    public class BasicResultsDTO
    {
        public List<BasicNovelDTO> results {  get; set; }

        public bool more;

        [JsonConstructor]
        public BasicResultsDTO(List<BasicNovelDTO> results, bool more)
        {
            this.results = results;
            this.more = more;
        }

        public override string ToString() 
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in results) 
            {
                stringBuilder.Append(item.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
