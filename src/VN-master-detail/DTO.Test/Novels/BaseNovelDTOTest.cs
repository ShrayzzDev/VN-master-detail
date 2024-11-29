using DTO.Novel;
using DTO.Producer;
using DTO.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test.Novels
{
    public class BaseNovelDTOTest
    {
        private static readonly int[] dims = [1, 1];

        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] {
                "id",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                "description",
                "title",
                Array.Empty<SimpleProducerDTO>(),
                10
            };
            yield return new object[] {
                "other",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                "other",
                "title",
                Array.Empty<SimpleProducerDTO>(),
                10
            };
            yield return new object[] {
                "id",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                "descriptions",
                "other",
                Array.Empty<SimpleProducerDTO>(),
                100
            };

        }

        [Theory]
        [MemberData(nameof(CtorTestData))]
        public static void TestCtor(string id, ImageDTO? image, string description, string title, SimpleProducerDTO[] developpers, int? average)
        {
            var novel = new BaseNovelDTO(id, image, description, title, average, developpers);

            Assert.Equal(id, novel.id);
            Assert.Equal(description, novel.description);
            Assert.Equal(title, novel.title);
            Assert.Equal(average, novel.average);
        }

        [Fact]
        public static void TestDefaultCtor()
        {
            var novel = new BaseNovelDTO();

            Assert.Equal(string.Empty, novel.id);
            Assert.Equal(string.Empty, novel.title);
            Assert.Equal(string.Empty, novel.description);
        }

        [Theory]
        [InlineData(9)]
        [InlineData(101)]
        [InlineData(float.MinValue)]
        [InlineData(float.MaxValue)]
        public static void TestAverageThrows(float average)
            => Assert.Throws<ArgumentException>(() =>
                new BaseNovelDTO("", new ImageDTO(), "", "", average, []));
    }
}
