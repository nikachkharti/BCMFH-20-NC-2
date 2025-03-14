using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using University.Service.Interfaces;

namespace University.Service.Implementations
{
    public class ImageService : IImageService
    {
        private readonly string _imageFolder;
        private const string _imageSubFolder = "images";

        public ImageService(IWebHostEnvironment environment)
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

        public async Task<string> UploadImage(IFormFile imageFile)
        {
            try
            {
                if (imageFile is null || imageFile.Length == 0)
                    return null;

                var fileName = $"{Path.GetRandomFileName()}{Path.GetExtension(imageFile.FileName)}";
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

        public async Task<string> UploadResizedImage(IFormFile imageFile)
        {
            try
            {
                if (imageFile is null || imageFile.Length == 0)
                    return null;

                var fileName = $"{Path.GetRandomFileName()}{Path.GetExtension(imageFile.FileName)}";
                var filePath = Path.Combine(_imageFolder, fileName);

                using var image = await Image.LoadAsync(imageFile.OpenReadStream());

                //Resize
                int maxWidth = 20;
                int maxHeight = 20;

                image.Mutate(i => i.Resize(new ResizeOptions()
                {
                    Size = new Size(maxWidth, maxHeight),
                    Mode = ResizeMode.Max
                }));

                await image.SaveAsync(filePath, new JpegEncoder() { Quality = 80 });

                return $"/{_imageSubFolder}/{fileName}";
            }
            catch
            {
                return null;
            }
        }
    }
}
