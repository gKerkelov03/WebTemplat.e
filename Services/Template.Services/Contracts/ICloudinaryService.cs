namespace Template.Services.Contracts;

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Template.Services.Common;

public interface ICloudinaryService : ITransientService

{
    Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
}
