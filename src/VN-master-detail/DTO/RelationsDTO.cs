using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Novel;

namespace DTO
{
    internal class RelationsDTO
    {
        /// <summary>
        /// Type of the relation
        /// </summary>
        public string relation;

        /// <summary>
        /// If the relation is official
        /// </summary>
        public bool relation_official;

        /// <summary>
        /// Concerned novel;
        /// </summary>
        public BasicNovelDTO[] novels;

        public RelationsDTO(string relation, bool relation_official, BasicNovelDTO[] novels)
        {
            this.relation = relation;
            this.relation_official = relation_official;
            this.novels = novels;
        }
    }
}
