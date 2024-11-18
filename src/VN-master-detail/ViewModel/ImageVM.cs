using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ImageVM
    {
        internal Image? image;

        public string Url
        {
            get => image == null ? string.Empty : image.url;
        }

        public int[] Dims
        {
            get => image == null ? [0, 0] : image.dims;
        }
    }
}
