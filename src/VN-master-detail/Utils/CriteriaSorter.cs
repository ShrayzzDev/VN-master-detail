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
            IEnumerable<BasicNovelDTO> list;
            switch (criteria)
            {
                case Criteria.Name:
                    list = toSort.OrderBy(n => n.title);
                    break;

                case Criteria.Stars:
                    list = toSort.OrderBy(n => n.average);
                    break;

                default:
                    throw new NotImplementedException("This sorting criteria is not implemented yet");
            }
            return toSort;
        }
    }
}
