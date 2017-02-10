using GummyBearKingdom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GummyContext db = new GummyContext();

        public IActionResult Index()
        {
            List<Product> allProducts = db.Products.ToList();
            return View(allProducts);
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == id);
            return View(thisProduct);
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

        public IActionResult Edit(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product editedProduct)
        {
            db.Entry(editedProduct).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(p => p.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
