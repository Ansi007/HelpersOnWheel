using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = null!;

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
