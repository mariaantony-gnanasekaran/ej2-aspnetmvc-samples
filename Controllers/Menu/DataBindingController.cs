using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Menu
{
    public partial class MenuController : Controller
    {
        // GET: DataBinding
        public ActionResult DataBinding()
        {
            List<object> menuItems = new List<object>()
            {
                new { id= "parent1", text= "Appliances" },
                new { id= "parent2", text= "Accessories" },
                new { id= "parent3", text= "Fashion" },
                new { id= "parent4", text= "Home & Living" },
                new { id= "parent5", text= "Entertainment" },
                new { id= "parent6", text= "Kitchen", parentId= "parent1" },
                new { id= "parent7", text= "Washing Machine", parentId= "parent1" },
                new { id= "parent8", text= "Air Conditioners", parentId= "parent1" },
                new { id= "parent9", text= "Electric Cookers", parentId= "parent6" },
                new { id= "parent10", text= "Coffee Makers", parentId= "parent6" },
                new { id= "parent11", text= "Blenders", parentId= "parent6" },
                new { id= "parent12", text= "Fully Automatic", parentId= "parent7" },
                new { id= "parent13", text= "Semi Automatic", parentId= "parent7" },
                new { id= "parent14", text= "Inverter ACs", parentId= "parent8" },
                new { id= "parent15", text= "Split ACs", parentId= "parent8" },
                new { id= "parent16", text= "Window ACs", parentId= "parent8" },
                new { id= "parent17", text= "Mobile", parentId= "parent2" },
                new { id= "parent18", text= "Computer", parentId= "parent2" },
                new { id= "parent19", text= "Headphones", parentId= "parent17" },
                new { id= "parent20", text= "Memory Cards", parentId= "parent17" },
                new { id= "parent21", text= "Power Banks", parentId= "parent17" },
                new { id= "parent22", text= "Pendrives", parentId= "parent18" },
                new { id= "parent23", text= "External Hard Disks", parentId= "parent18" },
                new { id= "parent24", text= "Monitors", parentId= "parent18" },
                new { id= "parent25", text= "Men", parentId= "parent3" },
                new { id= "parent26", text= "Women", parentId= "parent3" },
                new { id= "parent27", text= "Shirts", parentId= "parent25" },
                new { id= "parent28", text= "Jackets", parentId= "parent25" },
                new { id= "parent29", text= "Track Suits", parentId= "parent25" },
                new { id= "parent30", text= "Kurtas", parentId= "parent26" },
                new { id= "parent31", text= "Salwars", parentId= "parent26" },
                new { id= "parent32", text= "Sarees", parentId= "parent26" },
                new { id= "parent33", text= "Furniture", parentId= "parent4" },
                new { id= "parent34", text= "Decor", parentId= "parent4" },
                new { id= "parent35", text= "Beds", parentId= "parent33" },
                new { id= "parent36", text= "Mattresses", parentId= "parent33" },
                new { id= "parent37", text= "Dining Tables", parentId= "parent33" },
                new { id= "parent38", text= "Clocks", parentId= "parent34" },
                new { id= "parent39", text= "Wall Decals", parentId= "parent34" },
                new { id= "parent40", text= "Paintings", parentId= "parent34" },
                new { id= "parent41", text= "Televisions", parentId= "parent5" },
                new { id= "parent42", text= "Home Theatres", parentId= "parent5" },
                new { id= "parent43", text= "Gaming Laptops", parentId= "parent5" }
            };

            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}
