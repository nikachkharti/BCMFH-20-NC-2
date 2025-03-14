using Microsoft.AspNetCore.Http;

namespace University.Service.Interfaces
{
    public interface IImageService
    {
        string DeleteImage(string imageUrl);
        Task<string> UploadImage(IFormFile imageFile);
        Task<string> UploadResizedImage(IFormFile imageFile);
    }
}
