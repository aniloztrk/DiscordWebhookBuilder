using System.Collections.Generic;

namespace MixyWebhookBuilder.Models
{
    public class Embed
    {
        public string url { get; set; }
        
        public string title { get; set; }
        
        public string description { get; set; }
        
        public string timestamp { get; set; }
        
        public int color { get; set; }

        public Author author { get; set; } 

        public Image image { get; set; } 

        public Thumbnail thumbnail { get; set; } 

        public Footer footer { get; set; } 

        public List<Field> fields { get; set; } 

        public Embed(string url, string title, string description, string timestamp, int color, Author author, Image image, Thumbnail thumbnail, Footer footer, List<Field> fields)
        {
            this.url = url;
            this.title = title;
            this.description = description;
            this.timestamp = timestamp;
            this.color = color;
            this.author = author;
            this.image = image;
            this.thumbnail = thumbnail;
            this.footer = footer;
            this.fields = fields;
        }

        public Embed(string url, string title, string description, string timestamp, int color)
        {
            this.url = url;
            this.title = title;
            this.description = description;
            this.timestamp = timestamp;
            this.color = color;
            author = new Author();
            image = new Image();
            thumbnail = new Thumbnail();
            footer = new Footer();
            fields = new List<Field>();
        }
        
        public Embed(string title, string description, int color)
        {
            this.title = title;
            this.description = description;
            this.color = color;
            url = string.Empty;
            timestamp = string.Empty;
            author = new Author();
            image = new Image();
            thumbnail = new Thumbnail();
            footer = new Footer();
            fields = new List<Field>();
        }

        public Author SetAuthor(Author author)
        {
            this.author = author;  
            return author;
        }

        public Author SetAuthor(string name, string url, string icon_url)
        {
            author = new Author(name, url, icon_url);
            return author;
        }

        public Image SetImage(string url)
        {
            image = new Image(url);
            return image;
        }

        public Thumbnail SetThumbnail(string url)
        {
            thumbnail = new Thumbnail(url);
            return thumbnail;
        }

        public Footer SetFooter(Footer footer)
        {
            this.footer = footer;
            return footer;
        }
        
        public Footer SetFooter(string text, string icon_url)
        {
            footer = new Footer(text, icon_url);
            return footer;
        }

        public Field AddField(Field field)
        {
            fields.Add(field);
            return field;
        }

        public Field AddField(string name, string value, bool inline)
        {
            var field = new Field(name, value, inline);
            fields.Add(field);
            return field;
        }
        
        public Embed() {}
    }
}