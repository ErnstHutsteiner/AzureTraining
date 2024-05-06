using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Threading.Tasks;

namespace Ernie.BlobFunc.Services;

public class ImageResizer : IImageResizer
{
    public async Task Resize(Stream input, Stream output)
    {
        using (Image image = Image.Load(input))
        {
            image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));
            image.Save(output, new JpegEncoder());
        }
    }
}