using DTO.Title;
using Model.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class TitleExtensions
    {
        public static SimpleTitle ToModel(this SimpleTitleDTO dto)
        {
            return new SimpleTitle(
                dto.latin,
                dto.title
            );
        }

        public static List<SimpleTitle> ToModels(this SimpleTitleDTO[] dtos)
        {
            var models = new List<SimpleTitle>(dtos.Length);
            foreach (var dto in dtos)
            {
                models.Add(dto.ToModel());
            }
            return models;
        }
    }
}
