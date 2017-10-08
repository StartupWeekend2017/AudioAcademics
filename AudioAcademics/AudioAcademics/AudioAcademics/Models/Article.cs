using System.Collections.Generic;

namespace AudioAcademics.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Contents { get; set; }
        public string AudioUrl { get; set; }
        public string CitationUrl { get; set; }
        public string ImageUrl { get; set; }
    }

}
