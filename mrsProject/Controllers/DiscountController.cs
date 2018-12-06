using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using mrsProject.DAL;
using mrsProject.Models;
using mrsProject.Utilities;

namespace mrsProject.Controllers
{

    public enum DiscountDescription { Sh, C }

    public class DiscountController : Controller
    {

        private readonly AppDbContext _context;

        public DiscountController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        
        public async Task<IActionResult> Index()
        {
            List<Discount> discounts = new List<Discount>();

            return View(discounts);
        }


        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CouponCode,DiscountDescription,DiscountActive")] Discount discount)
        {


            if (ModelState.IsValid)
            {

                _context.Add(discount);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = discount.DiscountID });
            }
            return View(discount);
        }
    }

}

      