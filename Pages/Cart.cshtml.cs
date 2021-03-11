using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_fifth_assignment.Infrastructure;
using asp_net_fifth_assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_fifth_assignment.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepository repository;

        public CartModel (IBookstoreRepository repo)
        {
            repository = repo;
        }
        
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

    }
}
