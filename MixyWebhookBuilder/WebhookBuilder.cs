using System;
using System.Net;
using System.Threading.Tasks;
using MixyWebhookBuilder.Models;
using Newtonsoft.Json;

namespace MixyWebhookBuilder
{
    public class WebhookBuilder
    {
        private WebhookContent Content { get; set; }
        
        private Uri WebhookUrl { get; set; }

        private readonly WebClient _webClient;

        public WebhookBuilder(string webhookUrl)
        {
            WebhookUrl = new Uri(webhookUrl);
            _webClient = new WebClient();
            _webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
        }

        public WebhookBuilder(Uri webhookUrl)
        {
            WebhookUrl = webhookUrl;
            _webClient = new WebClient();
            _webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
        }
        
        public WebhookBuilder() {}

        public WebhookContent SetContent(WebhookContent webhookContent)
        {
            Content = webhookContent;
            return Content;
        }

        public string SendContent()
        {
            var contentJson = JsonConvert.SerializeObject(Content);

            _webClient.UploadString(WebhookUrl, "POST", contentJson);

            return contentJson;
        }

        public async Task<string> SendContentTaskAsync()
        {
            var contentJson = JsonConvert.SerializeObject(Content);

            await _webClient.UploadStringTaskAsync(WebhookUrl, "POST", contentJson);

            return contentJson;
        }
    }
}