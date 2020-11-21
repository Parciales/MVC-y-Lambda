using ProjectParcial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectParcial4.Controllers;

namespace ProjectParcial4.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Temperatura()
        {
            Medidor ob = new Medidor();
            ob.Templ = double.Parse(Request.Form["txtLunes"].ToString());
            ob.Tempm = double.Parse(Request.Form["txtMartes"].ToString());
            ob.TempMi = double.Parse(Request.Form["txtMiercoles"].ToString());
            ob.TempJ = double.Parse(Request.Form["txtJueves"].ToString());
            ob.TempV = double.Parse(Request.Form["txtViernes"].ToString());
            ob.TempS = double.Parse(Request.Form["txtSabado"].ToString());
            ob.TempD = double.Parse(Request.Form["txtDomingo"].ToString());

            ob.Resultado = (ob.Templ + ob.Tempm + ob.TempMi + ob.TempJ + ob.TempV + ob.TempS + ob.TempD) / 7;
            if (ob.Resultado>35)
            {
                ob.mess = "¡Que Semana tan calurosa!";
            }
            else if (ob.Resultado>=15 && ob.Resultado<=35)
            {
                ob.mess = "¡Que clima tan delicioso!";
            }
            else if (ob.Resultado <15)
            {
                ob.mess = "¡Que Semana tan Fria Como el corazon de mi ex cold cold!";
            }
            return View("Temperatura", ob);
            
        }


    }
}