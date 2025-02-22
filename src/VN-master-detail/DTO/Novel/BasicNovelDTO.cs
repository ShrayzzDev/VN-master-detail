﻿using DTO.Producer;
using DTO.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO.Novel
{
    /// <summary>
    /// Contains basic informations about a novel.
    /// Should be used when 
    /// </summary>
    public class BasicNovelDTO : BaseNovelDTO
    {

        /// <summary>
        /// Other titles. Always contains
        /// at least the main one.
        /// </summary>
        public SimpleTitleDTO[] titles { get; set; } = [];

        public BasicNovelDTO(string id, ImageDTO? image, SimpleTitleDTO[] titles, string description, string title, SimpleProducerDTO[] developpers, float? average)
            : base(id, image, description, title, average, developpers)
        {
            this.titles = titles;
        }

        public BasicNovelDTO(BasicNovelDTO other)
            : base(other)
        {
            titles = other.titles;
        }
        public BasicNovelDTO() { }

        public override string ToString()
        {
            return $"Id: {id} \n" +
                   $"Title: {title} \n" +
                   $"Image: {{ {image} }}\n" +
                   $"Description: {description} \n" +
                   $"Developpers: {{ {developers} }}";
        }
    }
}
