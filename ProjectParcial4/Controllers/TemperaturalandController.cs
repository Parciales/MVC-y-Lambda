using ProjectParcial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectParcial4.Controllers
{
    public class TemperaturalandController : Controller
    {
        // GET: Temperaturaland
        public ActionResult Calor()
        {
            return View();
        }
        public ActionResult situacion()
        {
            Delegado dg = new Delegado();
            Medidor ob = new Medidor();
            ob.Templ = double.Parse(Request.Form["txtLunes"].ToString());
            ob.Tempm = double.Parse(Request.Form["txtMartes"].ToString());
            ob.TempMi = double.Parse(Request.Form["txtMiercoles"].ToString());
            ob.TempJ = double.Parse(Request.Form["txtJueves"].ToString());
            ob.TempV = double.Parse(Request.Form["txtViernes"].ToString());
            ob.TempS = double.Parse(Request.Form["txtSabado"].ToString());
            ob.TempD = double.Parse(Request.Form["txtDomingo"].ToString());

            //Delegate Programacion II
            Temperatura delegadotempe = dg.Calcular;
            ob.Resultado= delegadotempe(ob.Templ, ob.Tempm, ob.TempMi, ob.TempJ, ob.TempV, ob.TempS, ob.TempD);
            if (ob.Resultado > 35)
            {
                ob.mess = "¡Que Semana tan calurosa!";
            }
            else if (ob.Resultado >= 15 && ob.Resultado <= 35)
            {
                ob.mess = "¡Que clima tan delicioso!";
            }
            else if (ob.Resultado < 15)
            {
                ob.mess = "¡Que Semana tan Fria Como el corazon de mi ex cold cold!";
            }
           
            return View("situacion",ob);
        }

    }
}