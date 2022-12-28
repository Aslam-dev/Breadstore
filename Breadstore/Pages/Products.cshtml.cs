using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breadstore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Breadstore.Pages
{
    public class ProductsModel : PageModel
    {
        public List<BreadModel> BreadModels = new List<BreadModel>()
        {
            new BreadModel() {BreadName="Flat Bread",ImageName="FlatBread",BreadSize="Medium",BreadPrice=25},
            new BreadModel() {BreadName="Freanch Bread",ImageName="FrenchBread",BreadSize="large",BreadPrice=35},
            new BreadModel() {BreadName="Muliti Grain Bread",ImageName="MultiGrainBread",BreadSize="Small",BreadPrice=65},
            new BreadModel() {BreadName="Rye Bread",ImageName="RyeBread",BreadSize="Medium",BreadPrice=20},
            new BreadModel() {BreadName="Wheat Bread",ImageName="WheatBread",BreadSize="Large",BreadPrice=40},
            new BreadModel() {BreadName="White Bread",ImageName="WhiteBread",BreadSize="Small",BreadPrice=20},
        };
        public void OnGet()
        {
        }
    }
}
