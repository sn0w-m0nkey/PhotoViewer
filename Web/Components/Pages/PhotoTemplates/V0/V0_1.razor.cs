using Web.Models;

namespace Web.Components.Pages.PhotoTemplates.V0
{
    public partial class V0_1 : BasePhotoTemplate
    {
        // [Parameter]
        // public List<Photo> _photos { get; set; } = new();
        //
        // protected override void OnInitialized()
        // {
        //     base.OnInitialized();
        //     _photos = GetPhotos();
        // }
    
        private Photo selectedPhoto;

        private void OpenPhoto(Photo photo)
        {
            selectedPhoto = photo;
        }

        private void ClosePhoto()
        {
            selectedPhoto = null;
        }
    }
}
