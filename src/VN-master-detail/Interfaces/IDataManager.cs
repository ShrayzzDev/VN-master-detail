using DTO.Novel;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //
    public interface IDataManager
    {
        public Task<BasicNovel?> GetNovelById(string id);

        public Task<DetailedNovel?> GetDetailedNovelById(string id);
    }
}
