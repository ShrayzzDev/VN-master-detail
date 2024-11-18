using DTO;
using DTO.Novel;

namespace Utils
{
    /// <summary>
    /// Class used to handle sorting
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class CriteriaSorter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toSort"></param>
        /// <param name="criteria"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static IEnumerable<BasicNovelDTO> SortByCriteria(this IEnumerable<BasicNovelDTO> toSort, Criteria criteria)
        {
            switch (criteria)
            {
                case Criteria.Name:
                    return toSort.OrderBy(n => n.title);

                case Criteria.Stars:
                    return toSort.OrderBy(n => n.average);

                default:
                    throw new NotImplementedException("This sorting criteria is not implemented yet");
            }
        }
    }
}
