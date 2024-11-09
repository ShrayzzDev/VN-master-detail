using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum Criteria
    {
        Name,
        ReleaseDate,
        Stars,
    }

    public static class CriteriaExtensions
    {
        public static string AsString(this Criteria criteria)
        {
            switch (criteria)
            {
                case Criteria.Name:
                    return "title";
                case Criteria.ReleaseDate:
                    return "released";
                case Criteria.Stars:
                    return "rating";
                default:
                    throw new NotImplementedException("The criteria passed a parameter is not implemented (ToString)");
            }
        }
    }
}
