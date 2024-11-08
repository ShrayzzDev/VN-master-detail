using Model.Producer;
using Model.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Novel
{
    public class DetailedNovel : BasicNovel
    {
        /// <summary>
        /// Other title.
        /// </summary>
        public string? alttitle { get; set; }

        /// <summary>
        /// Other known names for the novel.
        /// </summary>
        public string[] aliases { get; set; }

        /// <summary>
        /// Langage the novel was originaly writen in
        /// </summary>
        public string olang { get; set; }

        /// <summary>
        /// Status of the developpement
        /// 0: Finished
        /// 1: In Dev
        /// 2: Canceled
        /// </summary>
        public DevStatusEnum devstatus { get; set; }

        /// <summary>
        /// When was it released
        /// </summary>
        public string released { get; set; }

        /// <summary>
        /// Which langages are supported
        /// </summary>
        public string[] languages { get; set; }

        /// <summary>
        /// Where is the game available
        /// </summary>
        public string[] platforms { get; set; }

        /// <summary>
        /// Between 1 to 5
        /// 1 being very short
        /// 5 being very long
        /// </summary>
        public LengthEnum length { get; set; }

        /// <summary>
        /// Average submitted play time in minutes
        /// </summary>
        public int? length_minutes { get; set; }

        /// <summary>
        /// Number of submitted play times
        /// </summary>
        public int length_votes { get; set; }

        /// <summary>
        /// Number of votes
        /// </summary>
        public int votecount { get; set; }

        public DetailedNovel(string id,
                             Image? image,
                             List<SimpleTitle> titles,
                             string description,
                             string title,
                             SimpleProducer[] producers,
                             int? average,
                             string? alttitle,
                             string[] aliases,
                             string olang,
                             int devstatus,
                             string released,
                             string[] languages,
                             string[] platforms,
                             int length,
                             int? length_minutes,
                             int length_votes,
                             int votecount)
            : base(id, image, titles, description, title, producers, average)
        {
            this.alttitle = alttitle;
            this.aliases = aliases;
            this.olang = olang;
            this.devstatus = (DevStatusEnum)devstatus;
            this.released = released;
            this.languages = languages;
            this.platforms = platforms;
            this.length = (LengthEnum)length;
            this.length_minutes = length_minutes;
            this.length_votes = length_votes;
            this.votecount = votecount;
        }

        public DetailedNovel(BasicNovel other,
                             string? alttitle,
                             string[] aliases,
                             string olang,
                             int devstatus,
                             string released,
                             string[] languages,
                             string[] platforms,
                             int length,
                             int? length_minutes,
                             int length_votes,
                             int votecount)
            : base(other)
        {
            this.alttitle = alttitle;
            this.aliases = aliases;
            this.olang = olang;
            this.devstatus = (DevStatusEnum)devstatus;
            this.released = released;
            this.languages = languages;
            this.platforms = platforms;
            this.length = (LengthEnum)length;
            this.length_minutes = length_minutes;
            this.length_votes = length_votes;
            this.votecount = votecount;
        }

        public DetailedNovel()
            :base("",new Image("","",Array.Empty<int>(),0,0,0,"", Array.Empty<int>()), new List<SimpleTitle>(),"","", Array.Empty<SimpleProducer>(),0)
        {
            this.alttitle = "";
            this.aliases = Array.Empty<string>();
            this.olang = "";
            this.devstatus = DevStatusEnum.Canceled;
            this.released = "";
            this.languages = Array.Empty<string>();
            this.platforms = Array.Empty<string>();
            this.length = 0;
            this.length_minutes = 0;
            this.length_votes = 0;
            this.votecount = 0;
        }
    }
}
