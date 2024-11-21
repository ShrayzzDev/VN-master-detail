using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class DetailedNovelExtensions
    {
        public static DetailedNovel ToModel(this DetailedNovelDTO dto)
        {
            return new DetailedNovel(
                dto.id,
                dto.image?.ToModel(),
                dto.titles.ToModels(),
                dto.description,
                dto.title,
                dto.developers.ToModels(),
                dto.average,
                dto.alttitle,
                dto.aliases,
                dto.olang,
                dto.devstatus,
                dto.released,
                dto.languages,
                dto.platforms,
                dto.length,
                dto.length_minutes,
                dto.length_votes,
                dto.votecount
            );
        }
    }
}
