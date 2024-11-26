using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class LabelExtensions
    {
        public static Model.Label ToModel(this LabelDTO dto)
        {
            return new Model.Label(
                dto.id,
                dto.label
            );
        }

        public static IEnumerable<Model.Label> ToModels(this IEnumerable<LabelDTO> dtos)
        {
            var list = new List<Model.Label>();
            foreach (var dto in dtos)
            {
                list.Add(dto.ToModel());
            }
            return list;
        }
    }
}
