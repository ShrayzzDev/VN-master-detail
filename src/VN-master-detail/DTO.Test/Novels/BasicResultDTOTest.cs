using DTO.Novel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test.Novels
{
    public static class BasicResultDTOTest
    {
        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] { new List<BasicNovelDTO>(), true };
            yield return new object[] { new List<BasicNovelDTO>(), false };
            yield return new object[] { new List<BasicNovelDTO>() { new() }, true };
            yield return new object[] { new List<BasicNovelDTO>() { new() }, false };
            yield return new object[] { new List<BasicNovelDTO>() { new(), new() }, true };
            yield return new object[] { new List<BasicNovelDTO>() { new(), new() }, false };
        }

        [Theory]
        [MemberData(nameof(CtorTestData))]
        public static void CtorTest(List<BasicNovelDTO> novels, bool more)
        {
            var result = new BasicResultsDTO(novels, more);

            Assert.Equal(novels.Count, result.results.Count);
            Assert.Equal(more, result.more);
        }
    }
}
