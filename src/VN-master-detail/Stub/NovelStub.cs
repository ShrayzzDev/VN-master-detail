using DTO;
using DTO.Extensions;
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

        private readonly List<DetailedNovelDTO> _detailedNovels = [];

        private readonly List<BasicNovelDTO> _basicNovels = [];

        private readonly Dictionary<string, List<SimpleUserNovelDTO>> _userNovels = [];

        private readonly Dictionary<string, List<SimpleUserNovelDTO>> _tokenUserNovels = [];

        public NovelStub()
        {
            _basicNovels.Add(new BasicNovelDTO("v1",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Katawa Shoujo",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v2",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Steins;Gate",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v2",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Steins;Gate 0",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v3",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Danganronpa",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _detailedNovels.Add(new DetailedNovelDTO("v1",
                new ImageDTO("imageid", "dotnet_bot.png", [400, 400], 0, 0, 11, "dotnet_bot.png", [50, 50]),
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
            _userNovels.Add("u1", [
                new SimpleUserNovelDTO("v1",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Katawa Shoujo",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                )
            ]);
            _tokenUserNovels.Add("u1", [
                new SimpleUserNovelDTO("v1",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Katawa Shoujo",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                )
            ]);
        }

        public Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
            => Task.Run(() =>_detailedNovels
                .Find(n => n.id.Equals(id)));

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelByOrder(int index, int count, Criteria criteria)
            => Task.Run(() => _basicNovels
                .SortByCriteria(criteria));

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelByOrder(int index, int count, Criteria criteria, string name)
            => Task.Run(() => _basicNovels
                .Where(n => n.title.Contains(name) || n.titles.Where(t => t.title.Contains(name) || t.latin.Contains(name)).Any())
                .SortByCriteria(criteria));

        public Task<BasicNovelDTO?> GetNovelById(string id)
            => Task.Run(() => _basicNovels
                .Find(n => n.id.Equals(id)));

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelByCriteria(int index, int count, string which, string value)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SimpleUserNovelDTO?>?> GetNovelForUser(int index, int count, string userId)
            => Task.Run(() =>
            {
                if (_userNovels.TryGetValue(userId, out var novels))
                    return novels.Skip(index * count).Take(count);
                return (IEnumerable<SimpleUserNovelDTO?>?)null;
            });

        public Task<bool> AddNovelToUserList(string novelId, string apiToken)
        {
            return Task.Run(() =>
            {
                var userExists = _tokenUserNovels.TryGetValue(apiToken, out List<SimpleUserNovelDTO> novels);
                if (!userExists) return false;
                var isIn = novels.Exists(n => n.id.Equals(novelId));
                if (isIn) return false;
                novels.Add(_basicNovels.First((n) => n.id.Equals(novels)).AsUserNovel());
                return true;
            });
        }

        public Task<bool> DoesUserHaveNovel(string novelId, string userid)
        {
            return Task.Run(() =>
            {
                if (!_userNovels.TryGetValue(userid, out var novels)) return false;
                return novels.Exists((n) => n.id.Equals(novelId));
            });
        }
    }
}
