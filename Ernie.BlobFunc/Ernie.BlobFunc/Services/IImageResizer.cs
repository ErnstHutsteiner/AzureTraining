using System.IO;
using System.Threading.Tasks;

namespace Ernie.BlobFunc.Services;

public interface IImageResizer
{ 
    Task Resize (Stream input, Stream output);
}