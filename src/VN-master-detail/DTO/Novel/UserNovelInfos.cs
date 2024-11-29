using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Novel
{
    public class UserNovelInfos
    {
        public string id { get; set; } = "";

        public int vote { get; set; }

        public List<LabelDTO> labels { get; set; } = [];
    }
}
