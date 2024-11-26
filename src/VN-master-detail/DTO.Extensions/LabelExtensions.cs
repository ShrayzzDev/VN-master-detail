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
                dto.name
            );
        }
    }
}
