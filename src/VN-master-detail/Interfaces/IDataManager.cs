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
    public interface IDataManager
    {
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
        /// Retrieves a detailed novel from it's Id
        /// </summary>
        /// <param name="id">id of searched novel</param>
        /// <returns>The novel. Null if not found.</returns>
        public Task<DetailedNovel?> GetDetailedNovelById(string id);
    }
}
