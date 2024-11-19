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
        private static string STUB_URL = "https://secure.gravatar.com/avatar/a9383e7f1c8be8a5ce99fb826f26fdce013a344e96e22f8b379cd02cd33f44d2?s=80&d=identicon";

        private readonly List<DetailedNovelDTO> _DetailedNovels = new List<DetailedNovelDTO>();

        private readonly List<BasicNovelDTO> _BasicNovels = new List<BasicNovelDTO>();

        public NovelStub()
        {
            _BasicNovels.Add(new BasicNovelDTO("v1",
                new ImageDTO("1", STUB_URL, [50, 50], 0, 0, 11, "url.fr", [400, 400]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Katawa Shoujo",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _DetailedNovels.Add(new DetailedNovelDTO("v1",
                new ImageDTO("imageid", "dotnet_bot.png", [50, 50], 0, 0, 11, "url.fr", [400, 400]),
                "One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr.",
                "Katawa Shoujo",
                [new SimpleTitleDTO("katawa shoujo", "Katawa Shoujo"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One")],
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100,
                "ks",
                ["ks", "Disabilty Girl"],
                "English",
                0,
                "04/01/12",
                ["english", "french", "italian", "spanish", "japanese"],
                ["PC"],
                2,
                30 * 60,
                2000000,
                500000
            ));
        }

        public Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
        {
            return Task.Run(() =>_DetailedNovels
                .Find(n => n.id.Equals(id)));
        }

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelByOrder(int index, int count, Criteria criteria)
        {
            return Task.Run(() => _BasicNovels
                .SortByCriteria(criteria));
        }

        public Task<BasicNovelDTO?> GetNovelById(string id)
        {
            return Task.Run(() => _BasicNovels
                .Find(n => n.id.Equals(id)));
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
