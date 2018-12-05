using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mrsProject.DAL;
using mrsProject.Models;

namespace mrsProject.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

   



        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderDetail orderDetail)
        {
            
            OrderDetail DbOrdDet = _context.OrderDetails
                                        .Include(r => r.Book)
                                        .Include(r => r.Order)
                                        .FirstOrDefault(r => r.OrderDetailID ==
                                                            orderDetail.OrderDetailID);

          
            DbOrdDet.OrderQuantity = orderDetail.OrderQuantity;
            DbOrdDet.OrderDetailPrice = DbOrdDet.Book.Price;
            DbOrdDet.OrderExtendedPrice = DbOrdDet.Book.Price * DbOrdDet.OrderQuantity;

            //update the database
            _context.OrderDetails.Update(DbOrdDet);
            _context.SaveChanges();

            //return to the order details
            return RedirectToAction("Details", "Orders", new { id = DbOrdDet.Order.OrderID });
        }
           

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails
                .FirstOrDefaultAsync(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();
            Order od = _context.Orders.FirstOrDefault(r => r.OrderDetails.Any(ord => ord.OrderDetailID== id));
            return RedirectToAction("Details", "Orders", new { id = od.OrderID });
        }

        private bool OrderDetailExists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailID == id);
        }
    }
}
