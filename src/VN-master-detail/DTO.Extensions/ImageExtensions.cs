using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class ImageExtensions
    {
        public static Image ToModel(this ImageDTO dto)
        {
            return new Image(
                dto.id,
                dto.url,
                dto.dims,
                dto.sexual,
                dto.violence,
                dto.votecount,
                dto.thumbnail,
                dto.thumbnail_dims
            );
        }
    }
}
