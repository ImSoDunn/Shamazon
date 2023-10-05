using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shamazon.Data;
using Shamazon.Models;

namespace Shamazon.Controllers
{
    public class ShoppingCartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShoppingCarts
        public async Task<IActionResult> Index()
        {
              return _context.ShoppingCart != null ? 
                          View(await _context.ShoppingCart.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ShoppingCart'  is null.");
        }


        //GET: Items/RemoveFromCart
        public IActionResult Remove()
        {
            return View();
        }
        // POST: Items/RemoveFromCart
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(int id)
        {

            var tempItem = await _context.ShoppingCart?.FirstOrDefaultAsync(e => e.Id == id);
            if (tempItem != null && tempItem.ItemQuantity > 1 )
            {
                tempItem.ItemQuantity--;
                _context.ShoppingCart.Update(tempItem);
            }
            else
            {
                _context.ShoppingCart.Remove(_context.ShoppingCart.Find(id));
            }

            
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // POST: Navigate to the Purchase Page
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut()
        {
            return RedirectToAction("Index", "CheckOut");
        }



    }
}
