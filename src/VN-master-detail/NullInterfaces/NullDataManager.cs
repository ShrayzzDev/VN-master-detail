using DTO;
using Interfaces;
using Model;
using Model.Novel;

namespace NullInterfaces
{
    /// <summary>
    /// Implements IDataManager but does nothing.
    /// Used for default initializations.
    /// </summary>
    public class NullDataManager : IDataManager<User>
    {
        /// <inheritdoc/>
        public User? ConnectedUser => null;

        /// <inheritdoc/>
        public Task<bool> AddNovelToUserList(string novelId)
            => Task.FromResult(false);

        /// <inheritdoc/>
        public Task<bool> ChangeUserNovel(string novelId, int newGrade, int labelId)
            => Task.FromResult(false);

        /// <inheritdoc/>
        public Task<bool> DeleteNovelFromUser(string novelId)
            => Task.FromResult(false);

        /// <inheritdoc/>
        public Task<bool> DoesUserHaveNovel(string novelId)
            => Task.FromResult(false);

        /// <inheritdoc/>
        public Task<DetailedNovel?> GetDetailedNovelById(string id)
            => Task.FromResult((DetailedNovel?)null);

        /// <inheritdoc/>
        public Task<IEnumerable<Label>> GetLabels()
            => Task.FromResult(Enumerable.Empty<Label>());

        /// <inheritdoc/>
        public Task<BasicNovel?> GetNovelById(string id)
            => Task.FromResult((BasicNovel?)null);

        /// <inheritdoc/>
        public Task<(IEnumerable<BasicNovel>, bool)> GetNovels(int index, int count, Criteria criteria)
            => Task.FromResult(((IEnumerable<BasicNovel>)[], false));

        /// <inheritdoc/>
        public Task<(IEnumerable<BasicNovel>, bool)> GetNovels(int index, int count, Criteria criteria, string name)
            => Task.FromResult(((IEnumerable<BasicNovel>)[], false));

        /// <inheritdoc/>
        public Task<(IEnumerable<BasicUserNovel>, bool)> GetNovelsForUser(int index, int count)
            => Task.FromResult(((IEnumerable<BasicUserNovel>)[], false));

        /// <inheritdoc/>
        public Task<(int, int)> GetUserNovelInfos(string novelId)
             => Task.FromResult((10, 0));

        /// <inheritdoc/>
        public Task<bool> IsLoggedIn()
            => Task.FromResult(false);

        /// <inheritdoc/>
        public Task<bool> Login(string apiKey)
            => Task.FromResult(false);

        /// <inheritdoc/>
        public Task Logout()
            => Task.FromResult(false);
    }
}
