using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Template.Services.Common;

namespace Template.Services.Contracts
{
    public interface ICloudinaryService : ITransientService
    {
        Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
    }
}
