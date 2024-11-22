using DTO;
using DTO.Novel;

namespace Interfaces
{
    /// <summary>
    /// Interface defining how to request VN data
    /// NOTE : Detailed novels should only be accessible
    /// via the Id. Getting a list of detailed novel would
    /// be heavy, as the informations are probably needed
    /// only when getting the detail of the novel, not when
    /// searching.
    /// </summary>
    public interface INovelRequestor
    {
        /// <summary>
        /// Returns the novel with given Id
        /// </summary>
        /// <param name="id">Id of the Novel</param>
        /// <returns>The novel. Null is not found</returns>
        public Task<BasicNovelDTO?> GetNovelById(string id);

        /// <summary>
        /// Returns all informations about the novel
        /// passed.
        /// </summary>
        /// <param name="id">Id of the novel.</param>
        /// <returns>The Novel. Null if not found</returns>
        public Task<DetailedNovelDTO?> GetDetailedNovelById(string id);

        /// <summary>
        /// Get a list of Novels based on the criteria
        /// in the parameter
        /// </summary>
        /// <param name="index">Page</param>
        /// <param name="count">Number of element per pages</param>
        /// <param name="criteria">Chosen criteria</param>
        /// <returns>A List of novel. May be empty</returns>
        public Task<BasicResultsDTO?> GetNovelByOrder(int index, int count, Criteria criteria);

        /// <summary>
        /// Get a list of Novels based on the criteria
        /// in the parameter
        /// </summary>
        /// <param name="index">Page</param>
        /// <param name="count">Number of element per pages</param>
        /// <param name="criteria">Chosen criteria</param>
        /// <param name="name">What the name have to contain (not the EXACT name)</param>
        /// <returns>A List of novel. May be empty</returns>
        public Task<BasicResultsDTO?> GetNovelByOrder(int index, int count, Criteria criteria, string name);

        /// <summary>
        /// Get a list of Novels where a certain attributes
        /// equals a certain value
        /// </summary>
        /// <param name="index">Page</param>
        /// <param name="count">Number of element per pages</param>
        /// <param name="which">Name of attribute to compare</param>
        /// <param name="value">Value to compare</param>
        /// <returns></returns>
        public Task<BasicResultsDTO?> GetNovelByCriteria(int index, int count, string which, string value);

        /// <summary>
        /// Retrieves the list of VN on an user 
        /// </summary>
        /// <param name="index">Page</param>
        /// <param name="count">Number of element per pages</param>
        /// <param name="userId">Id of the user</param>
        /// <returns></returns>
        public Task<BasicUserResultsDTO?> GetNovelForUser(int index, int count, string userId);

        /// <summary>
        /// Adds a novel to a user's personal list
        /// </summary>
        /// <param name="novelId">Id of the novel</param>
        /// <param name="novelId">Api token of the user</param>
        /// <returns>If sucessfully added</returns>
        public Task<bool> AddNovelToUserList(string novelId, string apiToken);

        /// <summary>
        /// Removes a novel from a user's personal list
        /// </summary>
        /// <param name="novelId">Id of the novel</param>
        /// <param name="apiToken">Api token of the user</param>
        /// <returns>If sucessfully removed.</returns>
        public Task<bool> DeleteNovelFromUser(string novelId, string apiToken);

        /// <summary>
        /// Checks if the user has a novel
        /// </summary>
        /// <param name="novelId">Id of the novel</param>
        /// <param name="userid">Id of the user</param>
        /// <returns></returns>
        public Task<bool> DoesUserHaveNovel(string novelId, string userid);

        /// <summary>
        /// Changes the grade a user gave to a Novel.
        /// </summary>
        /// <param name="novelId">Id of the novel</param>
        /// <param name="userId">Id of the user</param>
        /// <param name="newGrade"></param>
        /// <returns></returns>
        public Task<bool> ChangeUserGradeToNovel(string novelId, string userId, int newGrade);

        /// <summary>
        /// Gets the grade a User has set to a novel.
        /// </summary>
        /// <param name="novelId">Id of the novel</param>
        /// <param name="userId">Id of the user</param>
        /// <returns></returns>
        public Task<int> GetUserGradeToNovel(string novelId, string userId);
    }
}
