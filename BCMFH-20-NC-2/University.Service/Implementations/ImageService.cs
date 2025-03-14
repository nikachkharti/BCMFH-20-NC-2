using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using University.Service.Interfaces;

namespace University.Service.Implementations
{
    public class ImageService : IImageService
    {
        private readonly string _imageFolder;
        private const string _imageSubFolder = "images";

        public ImageService(IWebHostEnvironment environment,string subFolder)
        {
            if (environment.WebRootPath is null)
                throw new ArgumentNullException("WebRootPath is not configured");

            _imageFolder = Path.Combine(environment.WebRootPath, _imageSubFolder);

            if (!Directory.Exists(_imageFolder))
                Directory.CreateDirectory(_imageFolder);
        }

        public string DeleteImage(string imageUrl)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imageUrl))
                    return null;

                var fileName = Path.GetFileName(imageUrl);
                var filePath = Path.Combine(_imageFolder, fileName);

                if (File.Exists(filePath))
                    File.Delete(filePath);

                return filePath;
            }
            catch
            {
                return null;
            }
        }

        public async Task<string> UploadImage(IFormFile imageFile) //nika.png
        {
            try
            {
                if (imageFile is null || imageFile.Length == 0)
                    return null;

                var fileName = $"{Path.GetRandomFileName()}{Path.GetExtension(imageFile.FileName)}"; //asdasjdbjaksbdads.png
                var filePath = Path.Combine(_imageFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                    await imageFile.CopyToAsync(stream);

                return $"/{_imageSubFolder}/{fileName}";
            }
            catch
            {
                return null;
            }
        }
    }
}
