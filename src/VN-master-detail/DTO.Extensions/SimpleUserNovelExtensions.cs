﻿using DTO.Novel;
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
        public static BasicUserNovel ToModel(this BasicUserNovelDTO dto)
        {
            return new BasicUserNovel(
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

        public static IEnumerable<BasicUserNovel> ToModels(this IEnumerable<BasicUserNovelDTO?> dtos)
        {
            var list = new List<BasicUserNovel>(dtos.Count());
            foreach (var dto in dtos)
            {
                if (dto == null) list.Add(new BasicUserNovel());
                else list.Add(dto.ToModel());
            }
            return list;
        }
    }
}
