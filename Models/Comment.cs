using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetAtlas.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required,Display(Name ="Commentaires")]
        public string Text;


        [ScaffoldColumn(false)]
        public DateTime? CreatedAt { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public ICollection<Reply> Replies { get; set; }


    }
}
