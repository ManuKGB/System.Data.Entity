using System.ComponentModel.DataAnnotations;
namespace NetAtlas.ViewModels

{
    public class RegisterVM
    {
        [Required, MinLength(5, ErrorMessage = "5 caractères minimun"), Display(Name = "Nom d'utilisateur")]
        public string Username { get; set; }

        [Required, EmailAddress, Display(Name = "Adresse Email")]
        public string Email { get; set; }

        [Required, MinLength(6, ErrorMessage = "5 caractères minimun"), Display(Name = "Mot de passe"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required,Compare("Password"),  Display(Name = "Confirmation mot de passe"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        

    }
}
