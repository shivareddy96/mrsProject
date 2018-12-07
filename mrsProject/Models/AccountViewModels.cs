using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace mrsProject.Models
{
    public enum CardType { Visa, AmericanExpress, Discover, Mastercard }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {

        

     
        public String FirstName { get; set; }

        public String LastName { get; set; }

        //NOTE: Here is the property for email
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [StringLength(100, ErrorMessage = "The credit card must be at least 16 characters long.", MinimumLength = 16)]
        [Display(Name = "Credit Card1")]
        public string CreditCard1 { get; set; }

        [StringLength(100, ErrorMessage = "The credit card must be at least 16 characters long.", MinimumLength = 16)]
        [Display(Name = "Credit Card2")]
        public string CreditCard2 { get; set; }

        [StringLength(100, ErrorMessage = "The credit must be at least 16 characters long.", MinimumLength = 16)]
        [Display(Name = "Credit Card3")]
        public string CreditCard3 { get; set; }

        public CardType CreditCard1Type { get; set; }
        public CardType CreditCard2Type { get; set; }
        public CardType CreditCard3Type { get; set; }

        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The Password must be at least 6 characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }   

    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}
