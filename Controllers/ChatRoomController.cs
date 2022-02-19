using Microsoft.AspNetCore.Mvc;
using NetAtlas.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace NetAtlas.Controllers
{
    public class ChatRoomController : Controller
    {

        private readonly NetAtlasContext _context;

        public ChatRoomController(NetAtlasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var comments = _context.Comment.Include(x=> x.Replies).ToList() ;
            return View(comments);
        }
    }
}
