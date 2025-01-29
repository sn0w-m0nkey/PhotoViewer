namespace Web.Models;

public class Photo
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ThumbnailUrl { get; set; }
    public string FullSizeUrl { get; set; }
}