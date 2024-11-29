using DTO.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test.Novels
{
    public static class UserNovelInfosTest
    {
        [Fact]
        public static void CtorDefaultTest()
        {
            var infos = new UserNovelInfos();

            Assert.Equal(string.Empty, infos.id);
            Assert.Equal(0, infos.vote);
            Assert.Equal([], infos.labels);
        }
    }
}
