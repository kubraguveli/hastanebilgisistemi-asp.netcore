using Microsoft.AspNetCore.Mvc;
using StajUygulama1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Controllers
{
    public class HastaBilgiController : Controller
    {
        private IHastaBilgiRepository repository;
        public HastaBilgiController(IHastaBilgiRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult AddHasta()
        {
            //List<Il> IlList = context.Iller.OrderBy(x => x.IlAdi).ToList();
            //ViewBag.IlList = new SelectList(IlList, "IlId", "IlAdi");
            return View();
        }

        /// <summary>
        /// Veritabanına hasta bilgilerini kaydeder
        /// </summary>
        /// <param name="newHasta"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public IActionResult AddHasta(HastaBilgi newHasta)
        {
            if (!ModelState.IsValid)
            {
                return View("AddHasta");
            }

            repository.AddHastaBilgi(newHasta);
            return RedirectToAction("List");
           
        }

        public IActionResult List(string tcno = null, string ad = null, string soyad = null)
        {
            var hastalar = repository.GetHastaBilgileriByFilters(tcno, ad, soyad);
            
            ViewBag.KimlikNo = tcno;
            ViewBag.Ad = ad;
            ViewBag.Soyad = soyad;
            return View(hastalar);
        }
        public IActionResult Update(int id)
        {
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(HastaBilgi entity, HastaBilgi original)
        {
            repository.UpdateHastaBilgi(entity, original);
            return RedirectToAction("List");

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.DeleteHastaBilgi(id);
            return RedirectToAction("List");
        }
    }
}
