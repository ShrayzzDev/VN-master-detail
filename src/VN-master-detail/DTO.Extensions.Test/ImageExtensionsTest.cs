using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions.Test
{
    public static class ImageExtensionsTest
    {
        public static IEnumerable<object[]> ToModelTestData()
        {
            yield return new object[] { new ImageDTO() };
        }

        [Theory]
        [MemberData(nameof(ToModelTestData))]
        public static void ToModelTest(ImageDTO dto)
        {
            var model = dto.ToModel();

            Assert.Equal(dto.id, model.id);
            Assert.Equal(dto.url, model.url);
            Assert.Equal(dto.dims, model.dims);
            Assert.Equal(dto.sexual, model.sexual);
            Assert.Equal(dto.violence, model.violence);
            Assert.Equal(dto.votecount, model.votecount);
            Assert.Equal(dto.thumbnail, model.thumbnail);
            Assert.Equal(dto.thumbnail_dims, model.thumbnail_dims);
        }
    }
}
