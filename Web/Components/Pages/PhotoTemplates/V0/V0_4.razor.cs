using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Web.Components.Pages.PhotoTemplates;
using Web.Models;

namespace Web.Components.Pages.PhotoTemplates.V0
{
    public partial class V0_4 : BasePhotoTemplate
    {
        [Inject] private IJSRuntime JSRuntime { get; set; }

        protected List<Photo> Photos { get; set; } = new List<Photo>();
        private Photo selectedPhoto;
        private bool isModalOpen;
        private int currentIndex;

        protected override async Task OnInitializedAsync()
        {
            Photos = await LoadPhotosAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //if (firstRender)
            //{
                await JSRuntime.InvokeVoidAsync("initMasonry");
            //}
        }

        private void OpenModal(Photo photo)
        {
            selectedPhoto = photo;
            currentIndex = Photos.IndexOf(photo);
            isModalOpen = true;
        }

        private void CloseModal()
        {
            isModalOpen = false;
            selectedPhoto = null;
        }

        private void PreviousPhoto()
        {
            currentIndex = (currentIndex - 1 + Photos.Count) % Photos.Count;
            selectedPhoto = Photos[currentIndex];
        }

        private void NextPhoto()
        {
            currentIndex = (currentIndex + 1) % Photos.Count;
            selectedPhoto = Photos[currentIndex];
        }

        private async Task<List<Photo>> LoadPhotosAsync()
        {
            return GetPhotos();
        }
    }
}
