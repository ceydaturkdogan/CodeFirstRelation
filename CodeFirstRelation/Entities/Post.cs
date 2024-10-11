
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstRelation.Entities
{
    public class Post
    {
        public string Title { get; set; }

        public string Content { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
