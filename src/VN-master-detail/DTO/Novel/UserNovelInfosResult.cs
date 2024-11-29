using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Novel
{
    public class UserNovelInfosResult
    {
        public bool more { get; set; }
        public List<UserNovelInfos> results { get; set; }

        public UserNovelInfosResult() { }
    }
}
