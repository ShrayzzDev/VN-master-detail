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
        /// <inheritdoc/>
        private User? _user = null;

        public User? ConnectedUser => _user;

        private readonly INovelRequestor _novelRequestor;

        private readonly IUserRequestor _userRequestor;

        private readonly IUserPreferences _userPreferences;

        public DataManager(INovelRequestor novelRequestor,
                           IUserRequestor userRequestor,
                           IUserPreferences userPreferences)
        {
            _novelRequestor = novelRequestor;
            _userRequestor = userRequestor;
            _userPreferences = userPreferences;
        }

        /// <inheritdoc/>
        public async Task<DetailedNovel?> GetDetailedNovelById(string id)
            => (await _novelRequestor.GetDetailedNovelById(id))?.ToModel();

        /// <inheritdoc/>
        public async Task<BasicNovel?> GetNovelById(string id)
            => (await _novelRequestor.GetNovelById(id))?.ToModel();

        /// <inheritdoc/>
        public async Task<(IEnumerable<BasicNovel>, bool)> GetNovels(int index, int count, Criteria criteria)
            => (await _novelRequestor.GetNovelByOrder(index, count, criteria)).ToTuple();

        /// <inheritdoc/>
        public async Task<(IEnumerable<BasicNovel>, bool)> GetNovels(int index, int count, Criteria criteria, string name)
            => (await _novelRequestor.GetNovelByOrder(index, count, criteria, name)).ToTuple();

        /// <inheritdoc/>
        public async Task<bool> Login(string apiKey)
        {
            _user = (await _userRequestor.Login(apiKey))?.ToModel();
            if (_user != null) _user.ApiKey = apiKey;
            return _user != null;
        }

        /// <inheritdoc/>
        public Task Logout()
            => Task.Run(() => _user = null);

        /// <inheritdoc/>
        public Task<bool> IsLoggedIn()
            => Task.Run(() => _user != null);

        /// <inheritdoc/>
        public async Task<(IEnumerable<BasicUserNovel>, bool)> GetNovelsForUser(int index, int count)
        {
            if (_user == null)
            {
                var api = _userPreferences.GetLoggedUser();
                if (api == string.Empty || !await Login(api))
                    return ([], true);
            }
            return (await _novelRequestor.GetNovelForUser(index, count, _user.UserId)).ToTuple();
        }

        /// <inheritdoc/>
        public async Task<bool> AddNovelToUserList(string novelId)
        {
            if (ConnectedUser == null) return false;
            return await _novelRequestor.AddNovelToUserList(novelId, ConnectedUser.ApiKey);
        }

        /// <inheritdoc/>
        public Task<bool> DoesUserHaveNovel(string novelId)
        {
            if (ConnectedUser == null) return Task.FromResult(false);
            return _novelRequestor.DoesUserHaveNovel(novelId, ConnectedUser.UserId);
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteNovelFromUser(string novelId)
        {
            if (ConnectedUser == null) return false;
            return await _novelRequestor.DeleteNovelFromUser(novelId, ConnectedUser.ApiKey);
        }

        /// <inheritdoc/>
        public Task<bool> ChangeUserNovel(string novelId, int newGrade, int labelId)
        {
            if (ConnectedUser == null) return Task.FromResult(false);
            return _novelRequestor.ChangeUserNovel(novelId, ConnectedUser.UserId, newGrade, labelId);
        }

        /// <inheritdoc/>
        public Task<(int, int)> GetUserNovelInfos(string novelId)
        {
            if (ConnectedUser == null) return Task.FromResult((0,0));
            return _novelRequestor.GetUserNovelInfos(novelId, ConnectedUser.UserId);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Label>> GetLabels()
        {
            if (_user == null) return Enumerable.Empty<Label>();
            return (await _userRequestor.GetLabels(_user.ApiKey)).ToModels();
        }
    }
}
