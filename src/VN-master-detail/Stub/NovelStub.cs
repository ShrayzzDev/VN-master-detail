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

        private readonly Dictionary<string, Dictionary<string, int>> _userNovelLabels = [];

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
                "Danganronpa: Trigger Happy Havoc",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v5",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Danganronpa 2: Goodbye Despair",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v6",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "Danganronpa V3: Killing Harmony",
                [new SimpleProducerDTO("prodid", "name", "type", "description")],
                100
            ));
            _basicNovels.Add(new BasicNovelDTO("v4",
                new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                [new SimpleTitleDTO("latin", "title")],
                "One of the greatest VN out there, you should play it fr.",
                "The Fruit of Grisaia",
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
                ),
                new BasicUserNovelDTO("v2",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Steins;Gate",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v3",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Steins;Gate 0",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v4",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Danganronpa: Trigger Happy Havoc",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v5",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Danganronpa 2 : Goodbye Despair",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v6",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "Danganronpa V3 : Killing Harmony",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v7",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "The Fruit of Grisaia",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v8",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "The Labyrinth of Grisaia",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                ),
                new BasicUserNovelDTO("v9",
                    new ImageDTO("1", STUB_URL, [400, 400], 0, 0, 11, STUB_URL, [50, 50]),
                    "One of the greatest VN out there, you should play it fr.",
                    "The Eden of Grisaia",
                    100,
                    [new SimpleProducerDTO("prodid", "name", "type", "description")],
                    100,
                    1,
                    99
                )
            ];
            _userNovels.Add("u1", userList);
            _tokenUserNovels.Add("jean-jean-jean-jean", userList);
            var dict = new Dictionary<string, int>()
            {
                { "v1", 0 },
                { "v2", 1 },
                { "v3", 0 },
                { "v4", 1 },
                { "v5", 0 },
                { "v6", 1 },
            };
            _userNovelLabels.Add("u1", dict);
        }

        /// <inheritdoc/>
        public Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
            => Task.Run(() =>_detailedNovels
                .Find(n => n.id.Equals(id)));

        /// <inheritdoc/>
        public Task<BasicResultsDTO> GetNovelByOrder(int index, int count, Criteria criteria)
            => Task.Run(() => new BasicResultsDTO(_basicNovels
                .SortByCriteria(criteria).ToList(), false));

        /// <inheritdoc/>
        public Task<BasicResultsDTO> GetNovelByOrder(int index, int count, Criteria criteria, string name)
            => Task.Run(() => new BasicResultsDTO(_basicNovels
                .Where(n => n.title.Contains(name) || n.titles.Where(t => t.title.Contains(name) || t.latin.Contains(name)).Any())
                .SortByCriteria(criteria)
                .Skip(count * index)
                .Take(count).ToList(),
                (_basicNovels.Count / count) <= index));

        /// <inheritdoc/>
        public Task<BasicNovelDTO?> GetNovelById(string id)
            => Task.Run(() => _basicNovels
                .Find(n => n.id.Equals(id)));

        /// <inheritdoc/>
        public Task<BasicResultsDTO> GetNovelByCriteria(int index, int count, string which, string value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<BasicUserResultsDTO> GetNovelForUser(int index, int count, string userId)
            => Task.Run(() =>
            {
                if (_userNovels.TryGetValue(userId, out var novels))
                {
                    return new BasicUserResultsDTO(
                        novels.Skip(index * count).Take(count).ToList(),
                        ((novels.Count - 1) / count) <= index
                    );
                }
                return new BasicUserResultsDTO([], true);
            });

        /// <inheritdoc/>
        public Task<bool> AddNovelToUserList(string novelId, string apiToken)
        {
            return Task.Run(() =>
            {
                var userExists = _tokenUserNovels.TryGetValue(apiToken, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return false;
                var isIn = novels.Exists(n => n.vn.id.Equals(novelId));
                if (isIn) return false;
                novels.Add(_basicNovels.First((n) => n.id.Equals(novelId)).AsUserNovel());
                return true;
            });
        }

        /// <inheritdoc/>
        public Task<bool> DeleteNovelFromUser(string novelId, string apiToken)
        {
            return Task.Run(() =>
            {
                var userExists = _tokenUserNovels.TryGetValue(apiToken, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return false;
                var isIn = novels.Exists(n => n.vn.id.Equals(novelId));
                if (!isIn) return false;
                novels.Remove(novels.First((n) => n.vn.id.Equals(novelId)));
                return true;
            });
        }

        /// <inheritdoc/>
        public Task<bool> DoesUserHaveNovel(string novelId, string userid)
        {
            return Task.Run(() =>
            {
                if (!_userNovels.TryGetValue(userid, out var novels)) return false;
                return novels.Exists((n) => n.vn.id.Equals(novelId));
            });
        }

        /// <inheritdoc/>
        public Task<bool> ChangeUserNovel(string novelId, string userId, int newGrade, int label)
        {
            return Task.Run(() =>
            {
                var userExists = _userNovels.TryGetValue(userId, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return false;
                var isIn = novels.Exists(n => n.vn.id.Equals(novelId));
                if (!isIn) return false;
                novels.First((n) => n.vn.id.Equals(novelId)).vote = newGrade;
                if (_userNovelLabels.TryGetValue(userId, out var dict) && dict != null && dict.TryGetValue(novelId, out _))
                {
                    _userNovelLabels[userId][novelId] = label;
                }
                return true;
            });
        }

        /// <inheritdoc/>
        public Task<(int, int)> GetUserNovelInfos(string novelId, string userId)
        {
            return Task.Run(() =>
            {
                var userExists = _userNovels.TryGetValue(userId, out List<BasicUserNovelDTO>? novels);
                if (!userExists || novels is null) return (0, 0);
                var isIn = novels.Exists(n => n.vn.id.Equals(novelId));
                if (!isIn) return (0, 0);
                var novel = novels.First((n) => n.vn.id.Equals(novelId));
                int labelId = 0;
                if (_userNovelLabels.TryGetValue(userId, out var dict) && dict != null && dict.TryGetValue(novelId, out var value))
                {
                    labelId = value;
                }
                return novel.vote == null ? (0, 0) : (novel.vote.Value, labelId);
            });
        }
    }
}
