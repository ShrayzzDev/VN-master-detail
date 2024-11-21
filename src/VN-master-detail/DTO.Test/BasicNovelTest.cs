using DTO.Novel;
using DTO.Producer;
using DTO.Title;

namespace DTO.Test
{
    public class BasicNovelTest
    {
        private static readonly int[] dims = new int[] {1, 1};

        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] { 
                "id",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                new SimpleTitleDTO[] { new SimpleTitleDTO("lating", "title") },
                "description",
                "title",
                new SimpleProducerDTO[] { },
                1
            };
            yield return new object[] {
                "other",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                new SimpleTitleDTO[] { new SimpleTitleDTO("lating", "title") },
                "other",
                "title",
                new SimpleProducerDTO[] { },
                1
            };
            yield return new object[] {
                "id",
                new ImageDTO("a", "a", dims, 1, 1, 1, "a", dims),
                new SimpleTitleDTO[] { new SimpleTitleDTO("lating", "title") },
                "descriptions",
                "other",
                new SimpleProducerDTO[] { },
                112
            };

        }

        public void TestCtor(string id, ImageDTO? image, SimpleTitleDTO[] titles, string description, string title, SimpleProducerDTO[] developpers, int? average)
        {
            var novel = new BasicNovelDTO(id, image, titles, description, title, developpers, average);

            Assert.Equal(id, novel.id);
            Assert.Equal(description, novel.description);
            Assert.Equal(title, novel.title);
            Assert.Equal(average, novel.average);
        }
    }
}