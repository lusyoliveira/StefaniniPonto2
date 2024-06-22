using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace StefaniniPonto2.Controllers
{
    public class PontoController : Controller
    {
        //
        // GET: /Ponto/
        public ActionResult Index()
        {
            StefaniniProntoEntities entities = new StefaniniProntoEntities();

            ViewBag.PontoList = entities.Ponto.ToList();

            return View();
        }
	}
}