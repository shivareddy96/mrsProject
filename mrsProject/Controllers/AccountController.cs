using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mrsProject.DAL;
using mrsProject.Models;



namespace mrsProject.Controllers
{
    public enum CardType { Visa, AmericanExpress, Discover, Mastercard }

    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _db;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _db = context;
            _userManager = userManager;
            _signInManager = signIn;
           
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return Redirect(returnUrl ?? "/");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
        }
        
        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Register(RegisterViewModel model, CardType SelectCardType1, CardType SelectCardType2, CardType SelectCardType3)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PasswordHash = model.Password,
                    CreditCard1 = model.CreditCard1,
                    CreditCard1Type = model.CreditCard1Type,
                    CreditCard2 = model.CreditCard2,
                    CreditCard2Type = model.CreditCard2Type,
                    CreditCard3 = model.CreditCard3,
                    CreditCard3Type = model.CreditCard3Type
                };


                switch (SelectCardType1)
                {
                    case CardType.Discover:
                        model.CreditCard1Type = Models.CardType.Discover;
                        break;
                    case CardType.Visa:
                        model.CreditCard1Type = Models.CardType.Visa;
                        break;
                    case CardType.AmericanExpress:
                        model.CreditCard1Type = Models.CardType.AmericanExpress;
                        break;
                    case CardType.Mastercard:
                        model.CreditCard1Type = Models.CardType.Mastercard;
                        break;
                }
                switch (SelectCardType2)
                {
                    case CardType.Discover:
                        model.CreditCard2Type = Models.CardType.Discover;
                        break;
                    case CardType.Visa:
                        model.CreditCard2Type = Models.CardType.Visa;
                        break;
                    case CardType.AmericanExpress:
                        model.CreditCard2Type = Models.CardType.AmericanExpress;
                        break;
                    case CardType.Mastercard:
                        model.CreditCard2Type = Models.CardType.Mastercard;
                        break;
                }
                switch (SelectCardType3)
                {
                    case CardType.Discover:
                        model.CreditCard3Type = Models.CardType.Discover;
                        break;
                    case CardType.Visa:
                        model.CreditCard3Type = Models.CardType.Visa;
                        break;
                    case CardType.AmericanExpress:
                        model.CreditCard3Type = Models.CardType.AmericanExpress;
                        break;
                    case CardType.Mastercard:
                        model.CreditCard3Type = Models.CardType.Mastercard;
                        break;
                }






                IdentityResult result = await _userManager.CreateAsync(appUser, model.Password);
                if (result.Succeeded)
                {

                    //This will not work until you have seeded Identity OR added the "Customer" role 
                    //by navigating to the RoleAdmin controller and manually added the "Customer" role

                    await _userManager.AddToRoleAsync(appUser, "Customer");
                    //another example
                    //await _userManager.AddToRoleAsync(user, "Manager");

                    Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                

            }
            return View(model);
        }
        

        //GET: Account/Index
        public ActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser appUser = _db.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            ivm.Email = appUser.Email;
            ivm.HasPassword = true;
            ivm.UserID = appUser.Id;
            ivm.UserName = appUser.UserName;
            ivm.FirstName = appUser.FirstName;
            ivm.LastName = appUser.LastName;
            ivm.Address = appUser.Address;
            ivm.PhoneNumber = appUser.PhoneNumber;


            return View(ivm);
        }

        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false); 
                return RedirectToAction("Index", "Home");
            }
            AddErrors(result);
            return View(model);
        }

        //GET:/Account/AccessDenied
        public ActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
           
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}