using DTO;
using DTO.Novel;
using DTO.Producer;
using DTO.Title;
using Interfaces;
using Utils;

namespace Stub
{
    public class NovelStub : INovelRequestor
    {
        private List<DetailedNovelDTO> _DetailedNovels = new List<DetailedNovelDTO>();

        private List<BasicNovelDTO> _BasicNovels = new List<BasicNovelDTO>();

        public NovelStub()
        {
            _BasicNovels.Add(new BasicNovelDTO("v1",
                new ImageDTO("1", "https://secure.gravatar.com/avatar/a9383e7f1c8be8a5ce99fb826f26fdce013a344e96e22f8b379cd02cd33f44d2?s=80&d=identicon", new int[] { 50, 50 }, 0, 0, 11, "url.fr", new int[] { 400, 400 }),
                new SimpleTitleDTO[] { new SimpleTitleDTO("latin", "title") },
                "One of the greatest VN out there, you should play it fr.",
                "Katawa Shoujo",
                new SimpleProducerDTO[] { new SimpleProducerDTO("prodid", "name", "type", "description") },
                100
            ));
            _DetailedNovels.Add(new DetailedNovelDTO("v1",
                new ImageDTO("imageid", "dotnet_bot.png", new int[] { 50, 50 }, 0, 0, 11, "url.fr", new int[] { 400, 400 }),
                "One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr.",
                "Katawa Shoujo",
                new SimpleTitleDTO[] { new SimpleTitleDTO("katawa shoujo", "Katawa Shoujo"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One") },
                new SimpleProducerDTO[] { new SimpleProducerDTO("prodid", "name", "type", "description") },
                100,
                "ks",
                new string[] { "ks", "Disabilty Girl" },
                "English",
                0,
                "04/01/12",
                new string[] { "english", "french", "italian", "spanish", "japanese" },
                new string[] { "PC" },
                2,
                30 * 60,
                2000000,
                500000
            ));
        }

        public async Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
        {
            return _DetailedNovels
                .Where(n => n.id.Equals(id))
                .FirstOrDefault();
        }

        public async Task<IEnumerable<BasicNovelDTO?>?> GetNovelByOrder(int index, int count, Criteria criteria)
        {
            return _BasicNovels.SortByCriteria(criteria);
        }

        public async Task<BasicNovelDTO?> GetNovelById(string id)
        {
            return _BasicNovels.Where(n => n.id.Equals(id)).FirstOrDefault();
        }

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelByCriteria(int index, int count, string which, string value)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelForUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
