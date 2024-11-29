using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Test
{
    public static class ImageDTOTest
    {
        private static readonly int[] dims = { 0, 0 };

        public static IEnumerable<object[]> CtorTestData()
        {
            yield return new object[] { "id", "url", dims, 0, 0, 0, "thumbnail", dims };
            yield return new object[] { "other", "url", dims, 0, 0, 0, "thumbnail", dims };
            yield return new object[] { "id", "other", new int[] {int.MaxValue, int.MaxValue}, 0, 0, 0, "thumbnail", dims };
            yield return new object[] { "id", "url", dims, 100, 0, 0, "thumbnail", dims };
            yield return new object[] { "id", "url", dims, 0, 100, 0, "thumbnail", dims };
            yield return new object[] { "id", "url", dims, 0, 0, 100, "thumbnail", dims };
            yield return new object[] { "id", "url", dims, 0, 0, 0, "other", dims };
            yield return new object[] { "id", "url", dims, 0, 0, 0, "thumbnail", new int[] { int.MaxValue, int.MaxValue } };
        }

        [Theory]
        [MemberData(nameof(CtorTestData))]
        public static void CtorTest(string id, string url, int[] dims, float sexual, short violence, int votecount, string thumbnail,
                                    int[] tdims)
        {
            var image = new ImageDTO(id, url, dims, sexual, violence, votecount, thumbnail, tdims);

            Assert.Equal(id, image.id);
            Assert.Equal(url, image.url);
            Assert.Equal(dims, image.dims);
            Assert.Equal(sexual, image.sexual);
            Assert.Equal(violence, image.violence);
            Assert.Equal(votecount, image.votecount);
            Assert.Equal(thumbnail, image.thumbnail);
            Assert.Equal(tdims, image.thumbnail_dims);
        }

        [Fact]
        public static void DefaultCtorTest()
        {
            var image = new ImageDTO();

            Assert.Equal(string.Empty, image.id);
            Assert.Equal(string.Empty, image.url);
            Assert.Equal(dims, image.dims);
            Assert.Equal(0, image.sexual);
            Assert.Equal(0, image.violence);
            Assert.Equal(0, image.votecount);
            Assert.Equal(string.Empty, image.thumbnail);
            Assert.Equal(dims, image.thumbnail_dims);
        }
    }
}
