using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Title
{
    public class SimpleTitleDTO
    {
        public string? latin { get; set; } = null;

        public string? title { get; set; } = null;

        public SimpleTitleDTO() { }

        public SimpleTitleDTO(string? latin, string? title)
        {
            this.latin = latin;
            this.title = title;
        }
    }
}
