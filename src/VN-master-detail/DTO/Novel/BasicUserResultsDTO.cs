using System.Text;

namespace DTO.Novel
{
    public class BasicUserResultsDTO
    {
        public List<BasicUserNovelDTO> results { get; set; }

        public bool more { get; set; }

        public BasicUserResultsDTO(List<BasicUserNovelDTO> results, bool more)
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
