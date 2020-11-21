using ProjectParcial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectParcial4.Controllers
{
    public class DeportistaController : Controller
    {
        // GET: Deportista
        public ActionResult Atleta()
        {
            return View();
        }
        public ActionResult apro()
        {
            Aprobacion hg = new Aprobacion();
            hg.nombre = Request.Form["txtname"].ToString();
            hg.apellido = Request.Form["txtapellido"].ToString();
            hg.edad = int.Parse(Request.Form["txtedad"].ToString());
            hg.peso = double.Parse(Request.Form["txtpeso"].ToString());
            hg.estatura = double.Parse(Request.Form["txtesta"].ToString());

            if (hg.edad <= 18 && hg.estatura > 180 && hg.peso <= 80)
            {
                hg.comentario = "Aprobado ¡Felicidades!";
            }
            else
            {
                hg.comentario = "Lo Sentimos no Cumple con los Requisitos minimos ¡Rechazado!";
            }
            return View("Apro", hg);

        }
    }
}