using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectParcial4.Models
{
    delegate Double Temperatura(double x1, double x2, double x3, double x4, double x5, double x6, double x7);
    public class Delegado
    {
        public double Calcular(double t1,double t2,double t3, double t4, double t5, double t6,double t7)
        {
            return (t1 + t2 + t3 + t4 + t5 + t6 + t7)/7;
        }
    }
}