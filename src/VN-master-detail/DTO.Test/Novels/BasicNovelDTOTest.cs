using DTO.Novel;
using DTO.Producer;
using DTO.Title;

namespace DTO.Test.Novels
{
    public static class BasicNovelDTOTest
    {
        private static readonly int[] dims = [1, 1];

        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] {
                "id",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                new SimpleTitleDTO[] { new("lating", "title") },
                "description",
                "title",
                Array.Empty<SimpleProducerDTO>(),
                1
            };
            yield return new object[] {
                "other",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                new SimpleTitleDTO[] { new("lating", "title") },
                "other",
                "title",
                Array.Empty<SimpleProducerDTO>(),
                1
            };
            yield return new object[] {
                "id",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                new SimpleTitleDTO[] { new("lating", "title") },
                "descriptions",
                "other",
                Array.Empty<SimpleProducerDTO>(),
                112
            };

        }

        [Theory]
        [MemberData(nameof(CtorTestData))]
        public static void TestCtor(string id, ImageDTO? image, SimpleTitleDTO[] titles, string description, string title, SimpleProducerDTO[] developpers, int? average)
        {
            var novel = new BasicNovelDTO(id, image, titles, description, title, developpers, average);

            Assert.Equal(id, novel.id);
            Assert.Equal(description, novel.description);
            Assert.Equal(title, novel.title);
            Assert.Equal(average, novel.average);
        }

        [Fact]
        public static void TestDefaultCtor()
        {
            var novel = new BasicNovelDTO();

            Assert.Equal(string.Empty, novel.id);
            Assert.Equal(string.Empty, novel.title);
            Assert.Equal(string.Empty, novel.description);
            Assert.Equal(0, novel.average);
        }
    }
}