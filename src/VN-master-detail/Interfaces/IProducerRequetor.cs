using DTO.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProducerRequetor
    {
        /// <summary>
        /// Retrieves a produver via his id.
        /// </summary>
        /// <param name="id">Id of the producer.</param>
        /// <returns>The producer. Null if not found</returns>
        public DetailedProducerDTO? GetProducerById(string id);
    }
}
