using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test
{
    public static class LabelDTOTest
    {
        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] { 0, "name" };
            yield return new object[] { int.MaxValue, "name" };
            yield return new object[] { 0, "other" };
        }

        [Theory]
        [MemberData(nameof(CtorTestData))]
        public static void CtorTest(int id, string name)
        {
            var label = new LabelDTO(id, name);

            Assert.Equal(id, label.id);
            Assert.Equal(name, label.label);
        }

        [Fact]
        public static void DefaultCtorTest()
        {
            var label = new LabelDTO();

            Assert.Equal(-1, label.id);
            Assert.Equal(string.Empty, label.label);
        }
    }
}
