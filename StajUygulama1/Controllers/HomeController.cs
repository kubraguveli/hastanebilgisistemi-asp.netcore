using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajUygulama1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Controllers
{
    public class HomeController : Controller
    {
      
        private DataContext context;


        public HomeController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {

            return View();
        }


       

        //[HttpPost]
        //public JsonResult GetStateList(int IlId)
        //{
        //    context.ProxyCreationEnabled = false;
        //    List<Ilce> IlceList = context.Ilceler.Where(x => x.IlId == IlId).ToList();
        //    return Json(IlceList, new Newtonsoft.Json.JsonSerializerSettings());

        //}


    }
}
