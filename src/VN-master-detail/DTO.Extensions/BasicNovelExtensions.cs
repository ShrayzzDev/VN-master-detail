using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class BasicNovelExtensions
    {
        public static BasicUserNovelDTO AsUserNovel(this BasicNovelDTO basic)
        {
            return new BasicUserNovelDTO(
                basic.id,
                basic.image,
                basic.description,
                basic.title,
                basic.average,
                basic.developers,
                0,
                0,
                0
            );
        }

        public static BasicNovel ToModel(this BasicNovelDTO dto)
        {
            return new BasicNovel(
                dto.id,
                dto.image?.ToModel(),
                dto.titles.ToModels(),
                dto.description,
                dto.title,
                dto.developers.ToModels(),
                dto.average
            );
        }

        public static IEnumerable<BasicNovel> ToModels(this IEnumerable<BasicNovelDTO?>? dtos)
        {
            var list = new List<BasicNovel>();
            if (dtos is null) return list;
            foreach (var item in dtos)
            {
                if (item is null) list.Add(new BasicNovel());
                else list.Add(item.ToModel());
            }
            return list;
        }
    }
}
