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
    public static class DetailedNovelDTOTest
    {
        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "other", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "other", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "other", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 100, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "other", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "other",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MaxValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "other", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MaxValue,
                                        int.MinValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MaxValue, int.MinValue, int.MinValue };
            yield return new object[] { "id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MaxValue, int.MinValue };
            yield return new object[] { "id",   new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MaxValue };
        }

        [Theory]
        [MemberData(nameof(CtorTestData))]
        public static void CtorTest(string id, ImageDTO? image, string description, string title, SimpleTitleDTO[] titles,
                             SimpleProducerDTO[] producers, int? average, string? alttitle, string[] aliases, string olang,
                             int devstatus, string released, string[] languages, string[] platforms, int length, int? length_minutes,
                             int length_votes, int votecount)
        {
            var novel = new DetailedNovelDTO(id, image, description, title, titles, producers, average, alttitle, aliases, olang,
                                             devstatus, released, languages, platforms, length, length_minutes, length_votes, votecount);

            Assert.Equal(id, novel.id);
            Assert.Equal(description, novel.description);
            Assert.Equal(title, novel.title);
            Assert.Equal(average, novel.average);
            Assert.Equal(alttitle, novel.alttitle);
            Assert.Equal(olang, novel.olang);
            Assert.Equal(devstatus, novel.devstatus);
            Assert.Equal(released, novel.released);
            Assert.Equal(length, novel.length);
            Assert.Equal(length_minutes, novel.length_minutes);
            Assert.Equal(length_votes, novel.length_votes);
            Assert.Equal(votecount, novel.votecount);
        }

        [Fact]
        public static void DefaultCtorTest()
        {
            var novel = new DetailedNovelDTO();

            Assert.Equal("", novel.id);
            Assert.Equal("", novel.description); 
            Assert.Equal("", novel.title);
            Assert.Equal([], novel.titles);
            Assert.Equal([], novel.developers);
            Assert.Equal(10, novel.average);
            Assert.Equal("", novel.alttitle);
            Assert.Equal([], novel.aliases);
            Assert.Equal("", novel.olang);
            Assert.Equal(0, novel.devstatus);
            Assert.Equal("", novel.released);
            Assert.Equal([], novel.languages);
            Assert.Equal([], novel.platforms);
            Assert.Equal(0, novel.length);
            Assert.Equal(0, novel.length_minutes);
            Assert.Equal(0, novel.length_votes);
            Assert.Equal(0, novel.votecount);
        }
    }
}
