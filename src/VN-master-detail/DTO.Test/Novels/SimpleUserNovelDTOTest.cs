using DTO.Novel;
using DTO.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test.Novels
{
    public static class SimpleUserNovelDTOTest
    {
        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] { "id", new ImageDTO(), "description", "title", int.MinValue, Array.Empty<SimpleProducerDTO>(),
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "other", new ImageDTO(), "description", "title", int.MinValue, Array.Empty<SimpleProducerDTO>(),
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "other", "title", int.MinValue, Array.Empty<SimpleProducerDTO>(),
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "other", int.MinValue, Array.Empty<SimpleProducerDTO>(),
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", int.MaxValue, Array.Empty<SimpleProducerDTO>(),
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", int.MinValue, Array.Empty<SimpleProducerDTO>(),
                                        int.MaxValue, int.MaxValue, int.MaxValue };
        }

        public static void CtorTest(string id, ImageDTO? image, string description, string title, float? average, 
                                    SimpleProducerDTO[] developpers, int added, int? voted, int? vote)
        {
            var novel = new SimpleUserNovelDTO(id, image, description, title, average, developpers, added, voted, vote);

            Assert.Equal(id, novel.id);
            Assert.Equal(image, novel.image);
            Assert.Equal(description, novel.description);
            Assert.Equal(title, novel.title);
            Assert.Equal(average, novel.average);
            Assert.Equal(added, novel.added);
            Assert.Equal(voted, novel.voted);
            Assert.Equal(vote, novel.vote);
        }

        public static void DefaultCtorTest()
        {
            var novel = new SimpleUserNovelDTO();

            Assert.Equal("", novel.id);
            Assert.Equal("", novel.description);
            Assert.Equal("", novel.title);
            Assert.Equal(0, novel.average);
            Assert.Equal([], novel.developers);
            Assert.Equal(0, novel.added);
            Assert.Equal(0, novel.voted);
            Assert.Equal(0, novel.vote);
        }
    }
}
