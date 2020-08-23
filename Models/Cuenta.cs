using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cajero.Models
{
     public static class Cuenta
    {
        public static long Tarjeta { get; set; }
        public static int pin { get; set; }

        public static double credito { get; set; }

        public static double debito { get; set; }
        public static int balance { get; set; }

        public static DateTime fecha { get; set; }

        public static double Tcredito { get; set; }

        public static double Tdebito { get; set; }

        public static int monto { get; set; }
    }
}
