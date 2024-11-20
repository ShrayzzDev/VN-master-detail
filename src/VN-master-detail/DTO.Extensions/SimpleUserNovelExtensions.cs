using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class SimpleUserNovelExtensions
    {
        public static SimpleUserNovel ToModel(this SimpleUserNovelDTO dto)
        {
            return new SimpleUserNovel(
                dto.id,
                dto.image == null ? new Model.Image() : dto.image.ToModel(),
                dto.description,
                dto.title,
                dto.average,
                dto.developers.ToModels(),
                dto.added,
                dto.voted,
                dto.vote
            );
        }

        public static IEnumerable<SimpleUserNovel> ToModels(this IEnumerable<SimpleUserNovelDTO?> dtos)
        {
            var list = new List<SimpleUserNovel>(dtos.Count());
            foreach (var dto in dtos)
            {
                if (dto == null) list.Add(new SimpleUserNovel());
                else list.Add(dto.ToModel());
            }
            return list;
        }
    }
}
