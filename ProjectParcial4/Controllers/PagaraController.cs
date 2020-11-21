using ProjectParcial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectParcial4.Controllers
{
    public class PagaraController : Controller
    {
        // GET: Pagara
        public ActionResult Compra()
        {
            return View();
        }
        public ActionResult cal()
        {
            Calculo cl = new Calculo();
            cl.nomb = Request.Form["txtproducto"].ToString();
            cl.num = int.Parse(Request.Form["txtCantidad"].ToString());
            cl.precio = double.Parse(Request.Form["txtPrecio"].ToString());
            cl.Result = cl.num * cl.precio;

            if (cl.Result>100000)
            {
                cl.Reba = (cl.num * cl.precio) - ((cl.num * cl.precio) * 0.20);
            }
            else
            {
                cl.Reba = cl.num * cl.precio;
            }
            return View("cal",cl);
        }
        
    }
}