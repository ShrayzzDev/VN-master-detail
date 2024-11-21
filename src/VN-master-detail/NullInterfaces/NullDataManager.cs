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
        public User? ConnectedUser => null;

        public Task<bool> AddNovelToUserList(string novelId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNovelFromUser(string novelId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesUserHaveNovel(string novelId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<DetailedNovel?> GetDetailedNovelById(string id)
        {
            return Task.FromResult((DetailedNovel?)null);
        }

        /// <inheritdoc/>
        public Task<BasicNovel?> GetNovelById(string id)
        {
            return Task.FromResult((BasicNovel?)null);
        }

        /// <inheritdoc/>
        public Task<IEnumerable<BasicNovel>> GetNovels(int index, int count, Criteria criteria)
        {
            return Task.FromResult((IEnumerable<BasicNovel>)[]);
        }

        public Task<IEnumerable<BasicNovel>> GetNovels(int index, int count, Criteria criteria, string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SimpleUserNovel>> GetNovelsForUser(int index, int count)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsLoggedIn()
        {
            return Task.FromResult(false);
        }

        public Task<bool> Login(string apiKey)
        {
            return Task.FromResult(false);
        }

        public Task Logout()
        {
            return Task.FromResult(false);
        }
    }
}
