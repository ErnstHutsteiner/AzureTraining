using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Ernie.BlobFunc.Services;

namespace Ernie.BlobFunc;

public class BlobTrigger
{
    
    private readonly IImageResizer imageResizer;

    public BlobTrigger(IImageResizer imageResizer)
          => this.imageResizer = imageResizer;

    
    [FunctionName("BlobTrigger")]
    public async Task RunAsync(
        [BlobTrigger("normal-size/{name}", Connection = "")] Stream inputBlob,
        [Blob("reduced-size/{name}", FileAccess.Write)] Stream outputBlob,
        string name, ILogger log)
    {
        log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {inputBlob.Length} Bytes");

        try
        {
            await this.imageResizer.Resize(inputBlob, outputBlob);

            log.LogInformation("Reduced image saved to blob storage");
        }
        catch (Exception e)
        {
            log.LogError("Resize fails", e);
        }   
    }
}