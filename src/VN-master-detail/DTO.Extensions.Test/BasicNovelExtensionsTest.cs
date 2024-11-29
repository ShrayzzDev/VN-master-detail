using DTO.Novel;
using DTO.Producer;
using DTO.Title;

namespace DTO.Extensions.Test
{
    public static class BasicNovelExtensionsTest
    {
        public static IEnumerable<object[]> ToModelTestData()
        {
            yield return new object[] { new BasicNovelDTO("id", new ImageDTO(), Array.Empty<SimpleTitleDTO>(), "description",
                                                          "title", [], 50) };
            yield return new object[] { new BasicNovelDTO("other", new ImageDTO(), Array.Empty<SimpleTitleDTO>(), "description",
                                                          "title", [], 50) };
            yield return new object[] { new BasicNovelDTO("id", new ImageDTO(), Array.Empty<SimpleTitleDTO>(), "other",
                                                          "title", [], 50) };
            yield return new object[] { new BasicNovelDTO("id", new ImageDTO(), Array.Empty<SimpleTitleDTO>(), "description",
                                                          "other", [], 50) };
            yield return new object[] { new BasicNovelDTO("id", new ImageDTO(), Array.Empty<SimpleTitleDTO>(), "description",
                                                          "title", [], 10) };
            yield return new object[] { new BasicNovelDTO("id", new ImageDTO(), Array.Empty<SimpleTitleDTO>(), "description",
                                                          "title", [], 100) };
        }

        [Theory]
        [MemberData(nameof(ToModelTestData))]  
        public static void ToModelTest(BasicNovelDTO dto)
        {
            var model = dto.ToModel();

            Assert.Equal(dto.id, model.Id);
            Assert.Equal(dto.image?.id, model.Image?.id);
            Assert.Equal(dto.titles.Length, model.Titles.Count);
            Assert.Equal(dto.description, model.Description);
            Assert.Equal(dto.title, model.Title);
            Assert.Equal(dto.developers.Length, model.Developpers.Length);
            Assert.Equal(dto.average, model.Average);
        }

        public static IEnumerable<object[]> ToModelsTestData()
        {
            yield return new object[] { new List<BasicNovelDTO>() { } };
            yield return new object[] { new List<BasicNovelDTO>() { new() } };
            yield return new object[] { new List<BasicNovelDTO>() { new(), new() } };
        }

        [Theory]
        [MemberData(nameof(ToModelsTestData))]
        public static void ToModelsTest(List<BasicNovelDTO> dtos)
        {
            var models = dtos.ToModels();

            Assert.Equal(dtos.Count, models.Count());
        }
    }
}