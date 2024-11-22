using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class BasicResultsExtensions
    {
        public static (IEnumerable<BasicNovel>, bool) ToTuple(this BasicResultsDTO? dto)
            => dto == null ? (new List<BasicNovel>(), false) : (dto.results.ToModels(), dto.more);

        public static (IEnumerable<BasicUserNovel>, bool) ToTuple(this BasicUserResultsDTO? dto)
            => dto == null ? (new List<BasicUserNovel>(), false) : (dto.results.ToModels(), dto.more);
    }
}
