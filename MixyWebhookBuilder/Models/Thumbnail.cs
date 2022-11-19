namespace MixyWebhookBuilder.Models
{
    public class Thumbnail
    {
        public string url { get; set; }

        public Thumbnail(string url)
        {
            this.url = url;
        }
        
        public Thumbnail() {}
    }
}