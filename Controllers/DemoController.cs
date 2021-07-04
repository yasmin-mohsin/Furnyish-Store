using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Data;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class DemoController : Controller
    {
        private readonly FurnitureDBContext _context;
        public DemoController(FurnitureDBContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "User")]
        public IActionResult AddToCart(int id,int amount)
        {
            var prod = _context.Products.Where(p => p.ID == id).ToList();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var shoppingCarts = _context.ShoppingProducts.Where(s => s.ProductID == id).ToList();
            if(shoppingCarts.Count == 0)
            {
                if ( amount <= prod.Count)
                {

                    var shopp = new ShoppingProduct();
                    shopp.UserID = userId;
                    shopp.ProductID = id;
                    shopp.Amount = amount;
                    _context.ShoppingProducts.Add(shopp);
                    _context.SaveChanges();
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                var ShoopingCartID = shoppingCarts.FirstOrDefault(w => w.ProductID == id);
                //var amountInProductInShoopingCart = int.Parse(shoppingCarts.Select(s => s.Amount).ToString());
                
                var newAmount = amount + ShoopingCartID.Amount;
                var product = prod.FirstOrDefault(e => e.ID == id);
                if (newAmount <= product.Count  )
                {
                   
                    ShoopingCartID.Amount = newAmount;
                    _context.ShoppingProducts.Update(ShoopingCartID);
                    _context.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }
           
                return RedirectToAction("Index");

        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.allProduct = _context.ShoppingProducts.Where(i => i.UserID == userId).Include(i => i.product).ToList();
            var all= _context.ShoppingProducts.Where(i => i.UserID == userId).Include(i => i.product).ToList();
            return View(all);
        }
        public IActionResult Rmove(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var shopproduct = _context.ShoppingProducts.Find( id);
            _context.ShoppingProducts.Remove(shopproduct);
            _context.SaveChanges();
           
            
            return RedirectToAction(nameof(Index));
        }
    }
}
