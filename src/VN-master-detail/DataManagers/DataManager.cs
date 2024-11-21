using DTO;
using DTO.Extensions;
using Interfaces;
using Model;
using Model.Novel;
using System.Diagnostics;

namespace DataManagers
{
    /// <summary>
    /// Serves as a layer to simplify
    /// access to requestor.
    /// For more details on each work, 
    /// see each requestor definition.
    /// </summary>
    public class DataManager : IDataManager<User>
    {
        private User? _user = null;

        public User? ConnectedUser => _user;

        private readonly INovelRequestor _novelRequestor;

        private readonly IUserRequestor _userRequestor;

        public DataManager(INovelRequestor novelRequestor,
            IUserRequestor userRequestor)
        {
            _novelRequestor = novelRequestor;
            _userRequestor = userRequestor;
        }

        public async Task<DetailedNovel?> GetDetailedNovelById(string id)
            => (await _novelRequestor.GetDetailedNovelById(id))?.ToModel();

        public async Task<BasicNovel?> GetNovelById(string id)
            => (await _novelRequestor.GetNovelById(id))?.ToModel();

        public async Task<IEnumerable<BasicNovel>> GetNovels(int index, int count, Criteria criteria)
            => (await _novelRequestor.GetNovelByOrder(index, count, criteria)).ToModels();

        public async Task<bool> Login(string apiKey)
        {
            _user = (await _userRequestor.Login(apiKey))?.ToModel();
            if (_user != null) _user.ApiKey = apiKey;
            return _user != null;
        }

        public Task Logout()
            => Task.Run(() => _user = null);

        public Task<bool> IsLoggedIn()
            => Task.Run(() => _user != null);

        public async Task<IEnumerable<SimpleUserNovel>> GetNovelsForUser(int index, int count)
        {
            if (_user == null) return [];
            var retrieved = await _novelRequestor.GetNovelForUser(index, count, _user.UserId);
            return retrieved == null ? [] : retrieved.ToModels();
        }

        public async Task<IEnumerable<BasicNovel>> GetNovels(int index, int count, Criteria criteria, string name)
            => (await _novelRequestor.GetNovelByOrder(index, count, criteria, name)).ToModels();

        public async Task<bool> AddNovelToUserList(string novelId)
        {
            if (ConnectedUser == null) return false;
            return await _novelRequestor.AddNovelToUserList(novelId, ConnectedUser.ApiKey);
        }

        public Task<bool> DoesUserHaveNovel(string novelId)
        {
            if (ConnectedUser == null) return Task.FromResult(false);
            return _novelRequestor.DoesUserHaveNovel(novelId, ConnectedUser.UserId);
        }
    }
}
