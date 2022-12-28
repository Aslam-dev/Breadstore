using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Breadstore.Pages
{
    [BindProperties(SupportsGet =true)]
    public class ThankYouModel : PageModel
    {
        public string BreadName { get; set; }
        public string ImageName { get; set; }
        public string BreadSize { get; set; }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(BreadName))
            {
                BreadName = "Custom Order";
            }
        }
    }
}
