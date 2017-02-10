using GummyBearKingdom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GummyContext db = new GummyContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            db.Products.Add(newProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int productId)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == productId);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product editedProduct)
        {
            db.Entry(editedProduct).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int productId)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == productId);
            return View(thisProduct);
        }

        [HttpPost(ActionName("Delete")]
        public IActionResult DeleteConfirmed(int productId)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == productId);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
