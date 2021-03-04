using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_fifth_assignment.Models;

namespace asp_net_fifth_assignment.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBookstoreRepository repository;

        public NavigationMenuViewComponent (IBookstoreRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                );
        }
    }
}
