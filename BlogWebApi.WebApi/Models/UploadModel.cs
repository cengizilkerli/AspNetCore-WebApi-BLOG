using BlogWebApi.WebApi.Enums;

namespace BlogWebApi.WebApi.Models
{
    public class UploadModel
    {
        public string NewName { get; set; }
        public string ErrorMessage { get; set; }
        public UploadState UploadState { get; set; }
    }
}