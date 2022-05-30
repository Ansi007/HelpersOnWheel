using System;
using System.Collections.Generic;

namespace HOW.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public string AuthorEmail { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
