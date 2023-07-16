using SelectionGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelectionGame.Controllers
{
    public class SelectGameController : Controller
    {
        // GET: SelectGame
        public ActionResult Index()
        {

            return View();
        }


        [HttpGet]
        public JsonResult loadJson()
        {
            List<SelectGameDTO> list = new List<SelectGameDTO>()
            {
                new SelectGameDTO() { CountryName="Canada",ProvinceName="Saskatchewan"},
                new SelectGameDTO() { CountryName="India",ProvinceName="Punjab"},
                new SelectGameDTO() { CountryName="China",ProvinceName="Shangai"},
                new SelectGameDTO() { CountryName="Japan",ProvinceName="Saitama"},
                new SelectGameDTO() { CountryName="US",ProvinceName="Utah"},
                new SelectGameDTO() { CountryName="Australia",ProvinceName="Victoria"},
                new SelectGameDTO() { CountryName="Mexico",ProvinceName="Jalisco"},
                new SelectGameDTO() { CountryName="Germany",ProvinceName="Bavaria"},
                new SelectGameDTO() { CountryName="Italy",ProvinceName="Lombardy"}               
            };

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}