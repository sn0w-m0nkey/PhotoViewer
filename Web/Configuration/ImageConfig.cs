namespace Web.Configuration;

public class ImageConfig
{
    public const string SectionName = "ImageConfig";
    
    public string ImagesRootRelativePath { get; set; }
    public string CanonSampleImages { get; set; }
    public string FujiSampleImages { get; set; }   
    
}