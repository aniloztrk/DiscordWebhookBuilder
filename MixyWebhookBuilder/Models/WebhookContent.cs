using System;
using System.Collections.Generic;

namespace MixyWebhookBuilder.Models
{
    public class WebhookContent
    {
        public string username { get; set; }
        
        public string avatar_url { get; set; }
        
        public string content { get; set; }
        
        public List<Embed> embeds { get; set; }

        public WebhookContent(string username, string avatar_url, string content, List<Embed> embeds)
        {
            this.username = username;
            this.avatar_url = avatar_url;
            this.content = content;
            this.embeds = embeds;
        }
        
        public WebhookContent(string username, string avatar_url, string content)
        {
            this.username = username;
            this.avatar_url = avatar_url;
            this.content = content;
            embeds = new List<Embed>();
        }

        public WebhookContent(string username, string avatar_url)
        {
            this.username = username;
            this.avatar_url = avatar_url;
            content = string.Empty;
            embeds = new List<Embed>();
        }

        public void AddEmbed(Embed embed)
        {
            embeds.Add(embed);
        }
        
        public WebhookContent() {}
    }
}