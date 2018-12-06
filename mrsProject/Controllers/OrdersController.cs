using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mrsProject.DAL;
using mrsProject.Models;
using mrsProject.Utilities;

namespace mrsProject.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            List<Order> Orders = new List<Order>();
            if (User.IsInRole("Customer"))
            {
                Orders = _context.Orders.Where(o => o.user.UserName == User.Identity.Name).ToList();
            }
            else
            {
                Orders = _context.Orders.Include(o => o.OrderDetails).ToList();
            }
            return View(Orders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.Include(r => r.OrderDetails).ThenInclude(r => r.Book).FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
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
        public async Task<IActionResult> Create([Bind("OrderID,OrderNumber,OrderDate,OrderNotes")] Order order)
        {

            
            order.OrderDate = System.DateTime.Today;

            if (ModelState.IsValid)
            {

                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("AddToOrder", new { id = order.OrderID });
            }
            return View(order);
        }

        public IActionResult AddToOrder(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You must specify a product to add!" });
            }

            List<Order> Orders = new List<Order>();

            Orders = _context.Orders.Where(o => o.user.UserName == User.Identity.Name).ToList();

            Order cart = Orders.FirstOrDefault(o => o.PendingOrder == true);

            if (cart == null)
            {
                cart = new Order();
                cart.PendingOrder = true;
                String userid = User.Identity.Name;
                AppUser user = _context.Users.FirstOrDefault(u => u.UserName == userid);
                cart.user = user;
            }

            Order ord = cart;
 
            if (ord == null)
            {
                return View("Error", new string[] { "Order not found!" });
            }

            List<Book> Books = new List<Book>();

            Books = _context.Books.Where(b => b.BookID == id).ToList();

            Book book = Books.FirstOrDefault(b => b.BookID == id);

            OrderDetail rd = new OrderDetail
            {
                Order = ord,
                Book = book
            };

            //ViewBag.AllProducts = GetAllProducts(id);
            return View("AddToOrder", rd);
        }

        [HttpPost]
        public IActionResult AddToOrder(OrderDetail rd)
        {


            //find the course associated with the selected course id
            Book book = _context.Books.Find(rd.Book.BookID);

            //set the registration detail's course equal to the course we just found
            rd.Book = book;

            List<Order> Orders = new List<Order>();

            Orders = _context.Orders.Where(o => o.user.UserName == User.Identity.Name).ToList();

            Order cart = Orders.FirstOrDefault(o => o.PendingOrder == true);

            if (cart == null)
            {
                cart = new Order();
                cart.PendingOrder = true;
                cart.OrderNumber = GenerateNextOrderNumber.GetNextOrderNumber(_context);
                String userid = User.Identity.Name;
                AppUser user = _context.Users.FirstOrDefault(u => u.UserName == userid);
                cart.user = user;
            }

            //find the registration based on the id
            //Order ord = _context.Orders.Find(rd.Order.OrderID); 

            //set the registration detail's registration equal to the registration we just found
            rd.Order = cart;

            //set the course fee for this detail equal to the current course fee
            rd.OrderDetailPrice = rd.Book.Price;

            //add total fees
            rd.OrderExtendedPrice = rd.OrderQuantity * rd.OrderDetailPrice;

            if (ModelState.IsValid)
            {
                _context.OrderDetails.Add(rd);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = rd.Order.OrderID });
            }
            
            return View(rd);
        }




        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Order order)
        {
            //Find the related registration in the database
            Order DbOd = _context.Orders.Find(order.OrderID);

            //Update the notes
            DbOd.OrderNotes = order.OrderNotes;

            //Update the database
            _context.Orders.Update(DbOd);

            //Save changes
            _context.SaveChanges();

            //Go back to index
            return RedirectToAction(nameof(Index));
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveFromOrder(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You need to specify an order id" });
            }

            Order od = _context.Orders.Include(r => r.OrderDetails).ThenInclude(r => r.Book).FirstOrDefault(r => r.OrderID == id);

            if (od == null || od.OrderDetails.Count == 0)
            {
                return RedirectToAction("Details", new { id = id });
            }

            //pass the list of order details to the view
            return View(od.OrderDetails);
        }


        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }

        //GET
        public IActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You need to specify an order id" });
            }

            List<Order> Orders = new List<Order>();
            Orders = _context.Orders.Where(o => o.user.UserName == User.Identity.Name).ToList();
            Order cart = Orders.FirstOrDefault(o => o.PendingOrder == true);

            //Order cart = _context.Orders.Include(r => r.OrderDetails).ThenInclude(r => r.Book).FirstOrDefault(r => r.OrderID == id);

            if (cart == null)
            {
                return View("Error");
            }


            return View("CheckOut", cart);
        }

        [HttpPost]
        public IActionResult CheckOut(Order cart, string SelectedCoupon, int SelectedCreditCard)
        {
            String userid = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == userid);

            Order dbCheckOutOrder = _context.Orders.Find(cart.OrderID);



            if (SelectedCreditCard == 0)
            {
                dbCheckOutOrder.PaymentMethod = user.CreditCard1;
            }
            else if (SelectedCreditCard == 1)
            {
                dbCheckOutOrder.PaymentMethod = user.CreditCard2;
            }
            else if (SelectedCreditCard == 2)
            {
                dbCheckOutOrder.PaymentMethod = user.CreditCard3;
            }

            if (dbCheckOutOrder.PaymentMethod == null)
            {
                return View("Error");
            }

            Discount coupon = _context.Discounts.FirstOrDefault(x => x.CouponCode == SelectedCoupon);
            if (coupon == null)
            {
                return View("Error");
            }

            if (ModelState.IsValid)
            {
                _context.Orders.Update(dbCheckOutOrder);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = dbCheckOutOrder.OrderID });
            }

            //Note: ADD THE CODE TO APPLY THE COUPON TO AFFECT THE ORDER
            return View("CheckOut", cart);
        }



        //Get
        //private IActionResult PlaceOrder(Order cart)
        //{

        //}
    }
}

