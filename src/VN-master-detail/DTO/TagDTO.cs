using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TagDTO
    {
        public uint rating;

        /// <summary>
        /// Spoiler level
        /// 0, 1 or 2
        /// </summary>
        public int spoiler;

        public bool lie;
    }
}
