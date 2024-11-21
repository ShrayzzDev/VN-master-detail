using DTO;
using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Defines methods on how to access data.
    /// Return Model classes
    /// </summary>
    public interface IDataManager<TUser> where TUser : class
    {
        /// <summary>
        /// Currently connected user
        /// </summary>
        TUser? ConnectedUser { get; }

        /// <summary>
        /// Retrieves a basic novel from it's Id
        /// </summary>
        /// <param name="id">Id of searched novel</param>
        /// <returns>The novel. Null if not found</returns>
        public Task<BasicNovel?> GetNovelById(string id);

        /// <summary>
        /// Retrieves a list of novel following given criteria.
        /// </summary>
        /// <param name="index">Page number</param>
        /// <param name="count">Amount of novel in the page</param>
        /// <param name="criteria">How to sort</param>
        /// <returns>Enumerable of novels. May be empty.</returns>
        public Task<IEnumerable<BasicNovel>> GetNovels(int index, int count, Criteria criteria);

        /// <summary>
        /// Retrieves a list of novel following given criteria.
        /// </summary>
        /// <param name="index">Page number</param>
        /// <param name="count">Amount of novel in the page</param>
        /// <param name="criteria">How to sort</param>
        /// <param name="name">What the name have to contain (not the EXACT name)</param>
        /// <returns>Enumerable of novels. May be empty.</returns>
        public Task<IEnumerable<BasicNovel>> GetNovels(int index, int count, Criteria criteria, string name);

        /// <summary>
        /// Retrieves a list of novels in the user's personal list.
        /// </summary>
        /// <param name="index">Page number</param>
        /// <param name="count">Amount of novel in the page</param>
        /// <returns>The list. May be empty.</returns>
        public Task<IEnumerable<SimpleUserNovel>> GetNovelsForUser(int index, int count);

        /// <summary>
        /// Retrieves a detailed novel from it's Id
        /// </summary>
        /// <param name="id">id of searched novel</param>
        /// <returns>The novel. Null if not found.</returns>
        public Task<DetailedNovel?> GetDetailedNovelById(string id);

        /// <summary>
        /// Logs the user.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns>If successfull.</returns>
        public Task<bool> Login(string apiKey);

        /// <summary>
        /// Checks if an user is currently logged in
        /// </summary>
        /// <returns>If logged.</returns>
        public Task<bool> IsLoggedIn();

        /// <summary>
        /// Logs the user out
        /// </summary>
        /// <returns>Nothing</returns>
        public Task Logout();

        /// <summary>
        /// Adds a novel to a user's personal list
        /// </summary>
        /// <param name="novelId">Id of the novel</param>
        /// <returns>If sucessfully added</returns>
        public Task<bool> AddNovelToUserList(string novelId);

        /// <summary>
        /// Deletes a novel from a user list.
        /// </summary>
        /// <param name="novelId"></param>
        /// <returns>If successfully removed</returns>
        public Task<bool> DeleteNovelFromUser(string novelId);

        /// <summary>
        /// Checks if the given user has the given novel
        /// in his list.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="novelId"></param>
        /// <returns></returns>
        public Task<bool> DoesUserHaveNovel(string novelId);

    }
}
