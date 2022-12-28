using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breadstore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Breadstore.Pages
{
    public class CustomOrderModel : PageModel
    {
        [BindProperty]
        //bindproperty conect back end to front end
        public BreadModel Bread { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("./Thankyou" , new {Bread.BreadName,Bread.ImageName,Bread.BreadSize});
        }
    }
}
