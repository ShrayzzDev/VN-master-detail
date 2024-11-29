using DTO.Novel;
using DTO.Producer;
using DTO.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions.Test
{
    public static class DetailedNovelsExtensionsTest
    {
        public static IEnumerable<object[]> ToModelTestData()
        {
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("other", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "other", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "other", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 100, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "other", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "other",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MaxValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "other", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MaxValue,
                                        int.MinValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MaxValue, int.MinValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id", new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MaxValue, int.MinValue) };
            yield return new object[] { new DetailedNovelDTO("id",   new ImageDTO(), "description", "title", Array.Empty<SimpleTitleDTO>(),
                                        Array.Empty<SimpleProducerDTO>(), 10, "alttitle", Array.Empty<string>(), "olang",
                                        int.MinValue, "released", Array.Empty<string>(), Array.Empty<string>(), int.MinValue,
                                        int.MinValue, int.MinValue, int.MaxValue) };
        }

        [Theory]
        [MemberData(nameof(ToModelTestData))]
        public static void ToModelTest(DetailedNovelDTO dto)
        {
            var model = dto.ToModel();

            Assert.Equal(dto.id, model.Id);
            Assert.Equal(dto.description, model.Description);
            Assert.Equal(dto.title, model.Title);
            Assert.Equal(dto.average, model.Average);
            Assert.Equal(dto.alttitle, model.alttitle);
            Assert.Equal(dto.olang, model.olang);
            Assert.Equal(dto.devstatus, (int)model.devstatus);
            Assert.Equal(dto.released, model.released);
            Assert.Equal(dto.length, (int)model.length);
            Assert.Equal(dto.length_minutes, model.length_minutes);
            Assert.Equal(dto.length_votes, model.length_votes);
            Assert.Equal(dto.votecount, model.votecount);
        }
    }
}
