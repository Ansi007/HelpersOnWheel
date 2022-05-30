using System;
using System.Collections.Generic;

namespace HOW.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public string AuthorEmail { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PostId { get; set; }
        public virtual Question Post { get; set; } = null!;
    }
}
