using DTO.Novel;
using DTO.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test.Novels
{
    public static class BasicUserNovelDTOTest
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
            var novel = new BasicUserNovelDTO(id, image, description, title, average, developpers, added, voted, vote);

            Assert.Equal(id, novel.id);
            Assert.Equal(image, novel.vn.image);
            Assert.Equal(description, novel.vn.description);
            Assert.Equal(title, novel.vn.title);
            Assert.Equal(average, novel.vn.average);
            Assert.Equal(added, novel.added);
            Assert.Equal(voted, novel.voted);
            Assert.Equal(vote, novel.vote);
        }

        public static void DefaultCtorTest()
        {
            var novel = new BasicUserNovelDTO();

            Assert.Equal("", novel.id);
            Assert.Equal("", novel.vn.description);
            Assert.Equal("", novel.vn.title);
            Assert.Equal(0, novel.vn.average);
            Assert.Equal([], novel.vn.developers);
            Assert.Equal(0, novel.added);
            Assert.Equal(0, novel.voted);
            Assert.Equal(0, novel.vote);
        }
    }
}
