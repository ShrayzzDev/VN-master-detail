using DTO.Extensions;
using Interfaces;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    /// <summary>
    /// Serves as a layer to simplify
    /// access to requestor.
    /// For more details on each work, 
    /// see each requestor definition.
    /// </summary>
    public class DataManager : IDataManager
    {
        private readonly INovelRequestor _novelRequestor;

        public DataManager(INovelRequestor novelRequestor)
        {
            _novelRequestor = novelRequestor;
        }

        public async Task<DetailedNovel?> GetDetailedNovelById(string id)
            => (await _novelRequestor.GetDetailedNovelById(id))?.ToModel();

        public async Task<BasicNovel?> GetNovelById(string id)
            => (await _novelRequestor.GetNovelById(id))?.ToModel();
    }
}
