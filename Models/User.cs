using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models
{
    public class User
    {
        [Key]
        public int Id { get; set;}

        [Required, MinLength(5, ErrorMessage = "5 caractères minimun"), Display(Name = "Nom d'utilisateur")]
        public string Username { get; set; }

        [Required,MinLength(6, ErrorMessage = "5 caractères minimun"), Display(Name = "Mot de passe"),DataType(DataType.Password)]
        public string Password { get; set;}

        [Required, EmailAddress, Display(Name = "Adresse Email")]
        public string Email { get; set;}


        [ScaffoldColumn(false)]
        public string ImageUrl { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedAt { get; set; }




    }
}
