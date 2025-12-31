using Microsoft.AspNetCore.Mvc;
using TinyEditorDemo.Data;
using TinyEditorDemo.Models;

namespace TinyEditorDemo.Controllers
{
    public class ArticleController : Controller
    {
        private readonly AppDbContext _db;

        public ArticleController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Article model)
        {
            model.CreatedAt = DateTime.Now;
            _db.Articles.Add(model);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View(_db.Articles.ToList());
        }
    }
}
