using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Web.Configuration;
using Web.Models;
using Web.Services;

namespace Web.Components.Pages.PhotoTemplates;

public class BasePhotoTemplate : ComponentBase
{
    [Inject]
    private IOptions<ImageConfig> _imageOptions { get; set; }
    [Inject]
    private IImageLoader _imageLoader { get; set; }
    
    protected string GalleryTitle { get; set; }
    private List<Photo> Images = new();
    
    protected override Task OnInitializedAsync()
    {
        Images = GetPhotos();
        return base.OnInitializedAsync();
    }
    protected List<Photo> GetPhotos()
    {
        var imagePaths = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            imagePaths.Add(_imageOptions.Value.CanonSampleImages);
            imagePaths.Add(_imageOptions.Value.FujiSampleImages);
        }
        return _imageLoader.LoadAllPhotos(imagePaths.ToArray());
    }
}
