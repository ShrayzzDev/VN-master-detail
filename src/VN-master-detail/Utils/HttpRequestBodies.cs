using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    /// <summary>
    /// The VNDB Api uses the body of an HTTP request
    /// to select which values to select. This, regroup 
    /// the different types of bodies used, to centralize them.
    /// </summary>
    public static class HttpRequestBodies
    {
        public static readonly string BasicNovelFields = "\"fields\" : \"" +
                                                                       "title, " +
                                                                       "titles.title, " +
                                                                       "titles.latin, " +
                                                                       "description, " +
                                                                       "average, " +
                                                                       "developers.id, " +
                                                                       "developers.name, developers.type, " +
                                                                       "developers.description, " +
                                                                       "image.id, image.url, " +
                                                                       "image.dims, " +
                                                                       "image.sexual, " +
                                                                       "image.violence, " +
                                                                       "image.votecount, " +
                                                                       "image.thumbnail, " +
                                                                       "image.thumbnail_dims\"";

        public static readonly string DetailedNovelFields = "\"fields\" : \"" +
                                                                       "alttile, " +
                                                                       "aliases, " +
                                                                       "olang, " +
                                                                       "devstatus, " +
                                                                       "released, " +
                                                                       "languages, " +
                                                                       "platforms, " +
                                                                       "length, " +
                                                                       "length_minutes, " +
                                                                       "length_votes, " +
                                                                       "votecount, " +
                                                                       "title, " +
                                                                       "titles.title, " +
                                                                       "titles.latin, " +
                                                                       "description, " +
                                                                       "average, " +
                                                                       "developpers.id, " +
                                                                       "developpers.name, developpers.type, " +
                                                                       "developpers.description, " +
                                                                       "image.id, image.url, " +
                                                                       "image.dims, " +
                                                                       "image.sexual, " +
                                                                       "image.violence, " +
                                                                       "image.votecount, " +
                                                                       "image.thumbnail, " +
                                                                       "image.thumbnail_dims\"";

        public static readonly string SimpleUserNovel = "\"fields\" : \"" +
                                                                       "added, " +
                                                                       "voted, " +
                                                                       "vote, " +
                                                                       "vn.title, " +
                                                                       "vn.titles.title, " +
                                                                       "vn.titles.latin, " +
                                                                       "vn.description, " +
                                                                       "vn.average, " +
                                                                       "vn.developpers.id, " +
                                                                       "vn.developpers.name, developpers.type, " +
                                                                       "vn.developpers.description, " +
                                                                       "vn.image.id, image.url, " +
                                                                       "vn.image.dims, " +
                                                                       "vn.image.sexual, " +
                                                                       "vn.image.violence, " +
                                                                       "vn.image.votecount, " +
                                                                       "vn.image.thumbnail, " +
                                                                       "vn.image.thumbnail_dims\"";
    }
}
