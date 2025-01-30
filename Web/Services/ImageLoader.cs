using Microsoft.Extensions.Options;
using Web.Configuration;
using Web.Models;

namespace Web.Services;

public interface IImageLoader
{
    List<Photo> LoadAllPhotos(params string[] imageFolders);
    List<Photo> LoadAllPhotos(ReadOnlySpan<string> imageFolders);
}

public class ImageLoader(IOptions<ImageConfig> imageOptions) : IImageLoader
{
    private readonly ImageConfig _imageConfig = imageOptions.Value;

    public List<Photo> LoadAllPhotos(params string[] imageFolders)
    {
        return LoadAllPhotos(imageFolders.AsSpan());
    }
    
    public List<Photo> LoadAllPhotos(ReadOnlySpan<string> imageFolders)
    {
        var photos = new List<Photo>();
        var id = 0;

        foreach (var imageFolder in imageFolders)
        {
            photos.AddRange(LoadPhotosFromFolder(imageFolder, ref id));
        }

        return photos;
    }
    
    private List<Photo> LoadPhotosFromFolder(string imageFolder, ref int id)
    {
        var photos = new List<Photo>();
        var imagesPath = GetImageDirectory(imageFolder);
        var imagePaths = Directory.GetFiles(imagesPath).ToList();

        imagePaths = imagePaths.Select(x => x.Replace('\\', '/')).ToList();
        foreach (var imagePath in imagePaths)
        {
            photos.Add(CreatePhoto(imagePath, ref id));
        }

        return photos;
    }

    private Photo CreatePhoto(string imagePath, ref int id)
    {
        var fileName = Path.GetFileNameWithoutExtension(imagePath.Split("/").Last());
        return new Photo
        {
            Id = id++,
            Title = fileName,
            Description = $"Description of {fileName}",
            ThumbnailUrl = imagePath.Replace("/wwwroot", ""), // TODO: Replace with thumbnail path
            FullSizeUrl = imagePath.Replace("/wwwroot", "")
        };
    }

    private string GetImageDirectory(string imageFolder)
    {
        return $"{_imageConfig.ImagesRootRelativePath}{imageFolder}";
    }
}