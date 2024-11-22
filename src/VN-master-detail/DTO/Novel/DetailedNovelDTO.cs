using DTO.Producer;
using DTO.Title;
using System.ComponentModel.DataAnnotations;

namespace DTO.Novel
{
    /// <summary>
    /// Contains all infos on a visual novel
    /// Should be used only when looking at the detail
    /// of a novel.
    /// </summary>
    public class DetailedNovelDTO : BasicNovelDTO
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
        public int devstatus { get; set; }

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
        public int length { get; set; }

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

        public DetailedNovelDTO(string id,
                             ImageDTO? image, 
                             string description, 
                             string title,
                             SimpleTitleDTO[] titles,
                             SimpleProducerDTO[] producers,
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
            this.devstatus = devstatus;
            this.released = released;
            this.languages = languages;
            this.platforms = platforms;
            this.length = length;
            this.length_minutes = length_minutes;
            this.length_votes = length_votes;
            this.votecount = votecount;
        }

        public DetailedNovelDTO(BasicNovelDTO other,
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
            this.devstatus = devstatus;
            this.released = released;
            this.languages = languages;
            this.platforms = platforms;
            this.length = length;
            this.length_minutes = length_minutes;
            this.length_votes = length_votes;
            this.votecount = votecount;
        }

        public DetailedNovelDTO()
            : this("", new ImageDTO(), "", "", [], [], 0, "", [], "", 0, "", [], [], 0, 0, 0 ,0) { }
    }
}
