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

        private readonly Dictionary<string, List<BasicUserNovelDTO>> _userNovels = [];

        private readonly Dictionary<string, List<BasicUserNovelDTO>> _tokenUserNovels = [];

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
            _basicNovels.Add(new BasicNovelDTO("v3",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Steins;Gate 0",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v4",
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
            _detailedNovels.Add(new DetailedNovelDTO("v2",
                new ImageDTO("imageid", "dotnet_bot.png", [400, 400], 0, 0, 11, "dotnet_bot.png", [50, 50]),
                "One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr.",
                "Steins;Gate",
                [new SimpleTitleDTO("steins;gate", "Steins;Gate"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One")],
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100,
                "ks",
                ["S;G"],
                "Japanese",
                0,
                "04/01/12",
                ["english", "french", "italian", "spanish", "japanese"],
                ["PC", "PSP Vita", "Xbox 360", "PS3", "IOS", "Android"],
                2,
                30 * 60,
                2000000,
                500000
            ));
            _detailedNovels.Add(new DetailedNovelDTO("v3",
                new ImageDTO("imageid", "dotnet_bot.png", [400, 400], 0, 0, 11, "dotnet_bot.png", [50, 50]),
                "One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr.",
                "Steins;Gate 0",
                [new SimpleTitleDTO("steins;gate 0", "Steins;Gate 0"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One")],
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100,
                "ks",
                ["S;G 0"],
                "Japanese",
                0,
                "04/01/12",
                ["english", "french", "italian", "spanish", "japanese"],
                ["PC", "PSP Vita", "Xbox 360", "PS3", "IOS", "Android"],
                2,
                30 * 60,
                2000000,
                500000
            ));
            _detailedNovels.Add(new DetailedNovelDTO("v4",
                new ImageDTO("imageid", "dotnet_bot.png", [400, 400], 0, 0, 11, "dotnet_bot.png", [50, 50]),
                "One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr. One of the greatest VN out there, you should play it fr.",
                "Danganronpa: Trigger Happy Havoc",
                [new SimpleTitleDTO("danganronpa", "Danganronpa"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One"), new SimpleTitleDTO("idk", "Another One")],
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100,
                "ks",
                ["Danganronpa 1"],
                "English",
                0,
                "04/01/12",
                ["english", "french", "italian", "spanish", "japanese"],
                ["PC", "PSP Vita", "Nintendo Switch"],
                2,
                30 * 60,
                2000000,
                500000
            ));
            List<BasicUserNovelDTO> userList = [
                new BasicUserNovelDTO("v1",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Katawa Shoujo",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                )
            ];
            _userNovels.Add("u1", userList);
            _tokenUserNovels.Add("jean-jean-jean-jean", userList);
        }

        public Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
            => Task.Run(() =>_detailedNovels
                .Find(n => n.id.Equals(id)));

        public Task<BasicResultsDTO> GetNovelByOrder(int index, int count, Criteria criteria)
            => Task.Run(() => new BasicResultsDTO(_basicNovels
                .SortByCriteria(criteria).ToList(), false));

        public Task<BasicResultsDTO> GetNovelByOrder(int index, int count, Criteria criteria, string name)
            => Task.Run(() => new BasicResultsDTO(_basicNovels
                .Where(n => n.title.Contains(name) || n.titles.Where(t => t.title.Contains(name) || t.latin.Contains(name)).Any())
                .SortByCriteria(criteria).ToList(),
                (_basicNovels.Count / count) + 1 <= index));

        public Task<BasicNovelDTO?> GetNovelById(string id)
            => Task.Run(() => _basicNovels
                .Find(n => n.id.Equals(id)));

        public Task<BasicResultsDTO> GetNovelByCriteria(int index, int count, string which, string value)
        {
            throw new NotImplementedException();
        }

        public Task<BasicUserResultsDTO> GetNovelForUser(int index, int count, string userId)
            => Task.Run(() =>
            {
                if (_userNovels.TryGetValue(userId, out var novels))
                    return new BasicUserResultsDTO(
                        novels.Skip(index * count).Take(count).ToList(),
                        (novels.Count / count) + 1 <= index
                    );
                return new BasicUserResultsDTO(new List<BasicUserNovelDTO>(), false);
            });

        public Task<bool> AddNovelToUserList(string novelId, string apiToken)
        {
            return Task.Run(() =>
            {
                var userExists = _tokenUserNovels.TryGetValue(apiToken, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return false;
                var isIn = novels.Exists(n => n.id.Equals(novelId));
                if (isIn) return false;
                novels.Add(_basicNovels.First((n) => n.id.Equals(novelId)).AsUserNovel());
                return true;
            });
        }

        public Task<bool> DeleteNovelFromUser(string novelId, string apiToken)
        {
            return Task.Run(() =>
            {
                var userExists = _tokenUserNovels.TryGetValue(apiToken, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return false;
                var isIn = novels.Exists(n => n.id.Equals(novelId));
                if (!isIn) return false;
                novels.Remove(novels.First((n) => n.id.Equals(novelId)));
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

        public Task<bool> ChangeUserGradeToNovel(string novelId, string userId, int newGrade)
        {
            return Task.Run(() =>
            {
                var userExists = _userNovels.TryGetValue(userId, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return false;
                var isIn = novels.Exists(n => n.id.Equals(novelId));
                if (!isIn) return false;
                novels.First((n) => n.id.Equals(novelId)).vote = newGrade;
                return true;
            });
        }

        public Task<int> GetUserGradeToNovel(string novelId, string userId)
        {
            return Task.Run(() =>
            {
                var userExists = _userNovels.TryGetValue(userId, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return 0;
                var isIn = novels.Exists(n => n.id.Equals(novelId));
                if (!isIn) return 0;
                var novel = novels.First((n) => n.id.Equals(novelId));
                return novel.vote == null ? 0 : novel.vote.Value;
            });
        }
    }
}
