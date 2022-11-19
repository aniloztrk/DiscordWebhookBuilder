namespace MixyWebhookBuilder.Models
{
    public class Image
    {
        public string url { get; set; }

        public Image(string url)
        {
            this.url = url;
        }
        
        public Image() {}
    }
}