using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class BasicNovelExtensions
    {
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
    }
}
