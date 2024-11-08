using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Image
    {
        public string id { get; set; }

        public string url { get; set; }

        public int[] dims { get; set; }

        public short sexual { get; set; }

        public short violence { get; set; }

        public int votecount { get; set; }

        public string thumbnail { get; set; }

        public int[] thumbnail_dims { get; set; }

        public Image(string id, string url, int[] dims, short sexual, short violence, int votecount, string thumbnail, int[] thumbnail_dims)
        {
            this.id = id;
            this.url = url;
            this.dims = dims;
            this.sexual = sexual;
            this.violence = violence;
            this.votecount = votecount;
            this.thumbnail = thumbnail;
            this.thumbnail_dims = thumbnail_dims;
        }

        public override string ToString()
        {
            return $"Id: {id} \n" +
                   $"Url: {url} \n" +
                   $"Dims: {dims[0]} x {dims[1]} \n" +
                   $"Sexual: {sexual} \n" +
                   $"Violence: {violence} \n" +
                   $"VoteCount: {votecount} \n" +
                   $"Thumbnail: {thumbnail} \n" +
                   $"ThumbnilDims: {thumbnail_dims[0]} x {thumbnail_dims[1]}";
        }
    }
}
