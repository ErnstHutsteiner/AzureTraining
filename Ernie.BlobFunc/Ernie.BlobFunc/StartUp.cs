using Ernie.BlobFunc;
using Ernie.BlobFunc.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Ernie.BlobFunc.Startup))]
namespace Ernie.BlobFunc
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IImageResizer, ImageResizer>();
        }
    }
}




