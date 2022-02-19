using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetAtlas.Models;
using NetAtlas.Controllers;
using NetAtlas.ViewModels;
using NetAtlas.Data;

namespace NetAtlas.Controllers
{
    public class AccountController : Controller
    {
        private readonly NetAtlasContext _context;

        public AccountController(NetAtlasContext context)
        {
            _context = context;
        }
        /*private*/
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Id,Username,Password,Email,ImageUrl,CreatedAt")] User user)
        {

            bool UserExists= _context.User.Any(e => e.Username == user.Username);
            bool EmailExists = _context.User.Any(e => e.Email == user.Email);
            if (UserExists)
            {
                ViewBag.UserName = "Nom d'utilisateur déjâ utiliser";
                return View();
            }
            if (EmailExists)
            {
                ViewBag.Email = "Adresse E-mail déjâ utiliser";
                return View();
            }
            user.ImageUrl = "";
             user.CreatedAt = DateTime.UtcNow;
             _context.Add(user);
             _context.SaveChanges();
            ///return View();
            return RedirectToAction("Index","ChatRoom");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Login([Bind("Id,Username,Password,Email,ImageUrl,CreatedAt")] User user)
        {

            bool UserExists = _context.User.Any(e => e.Username == user.Username && e.Password==user.Password);
            if (UserExists)
            {
                return RedirectToAction("Index", "ChatRoom");
            }
            ViewBag.Message = "Identifiant ou mot de passe incorrecte!";

            return View();
        }














    }
}
