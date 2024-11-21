using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITagRequestor
    {
        /// <summary>
        /// Gives the tag associated with given id
        /// </summary>
        /// <param name="id">Id of the tag</param>
        /// <returns>The Tag. Null if not found</returns>
        public TagDTO? GetTagById(string id);
    }
}
