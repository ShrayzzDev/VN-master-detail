﻿using Model.Producer;
using Model.Title;

namespace Model.Novel
{
    public class BasicNovel : BaseNovel
    {
        /// <summary>
        /// Other titles. Always contains
        /// at least the main one.
        /// </summary>
        public List<SimpleTitle> Titles { get; set; }

        public BasicNovel(string id, Image? image, List<SimpleTitle> titles, string description, string title, SimpleProducer[] developpers, float? average)
            : base(id, image, description, title, average, developpers)
        {
            Titles = titles;
        }

        public BasicNovel(BasicNovel other)
            : base(other)
        {
            Titles = other.Titles;
        }

        public BasicNovel()
            : this("", new Image(), [], "", "", [], 0) { }

        public override string ToString()
        {
            return $"Id: {Id} \n" +
                   $"Title: {Title} \n" +
                   $"Image: {{ {Image} }}\n" +
                   $"Description: {Description} \n" +
                   $"Developpers: {{ {Developpers} }}";
        }
    }
}
