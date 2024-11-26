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

        public async Task<(IEnumerable<BasicNovel>, bool)> GetNovels(int index, int count, Criteria criteria)
            => (await _novelRequestor.GetNovelByOrder(index, count, criteria)).ToTuple();

        public async Task<(IEnumerable<BasicNovel>, bool)> GetNovels(int index, int count, Criteria criteria, string name)
            => (await _novelRequestor.GetNovelByOrder(index, count, criteria, name)).ToTuple();

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

        public async Task<(IEnumerable<BasicUserNovel>, bool)> GetNovelsForUser(int index, int count)
        {
            if (_user == null) return ([], true);
            return (await _novelRequestor.GetNovelForUser(index, count, _user.UserId)).ToTuple();
        }

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

        public async Task<bool> DeleteNovelFromUser(string novelId)
        {
            if (ConnectedUser == null) return false;
            return await _novelRequestor.DeleteNovelFromUser(novelId, ConnectedUser.ApiKey);
        }

        public Task<bool> ChangeUserNovel(string novelId, int newGrade, int labelId)
        {
            if (ConnectedUser == null) return Task.FromResult(false);
            return _novelRequestor.ChangeUserNovel(novelId, ConnectedUser.ApiKey, newGrade, labelId);
        }

        public Task<(int, int)> GetUserNovelInfos(string novelId)
        {
            if (ConnectedUser == null) return Task.FromResult((0,0));
            return _novelRequestor.GetUserNovelInfos(novelId, ConnectedUser.ApiKey);
        }

        public async Task<IEnumerable<Label>> GetLabels()
        {
            if (_user == null) return Enumerable.Empty<Label>();
            return (await _userRequestor.GetLabels(_user.ApiKey)).ToModels();
        }
    }
}
