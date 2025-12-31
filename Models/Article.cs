namespace TinyEditorDemo.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
