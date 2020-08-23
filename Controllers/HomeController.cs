using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cajero.Models;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace Cajero.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        int[] monto = { 200, 500, 1000, 2000 };

        [HttpPost]
        public IActionResult Index(string numeroTarjeta, string pin)
        {
            /* C1.Tarjeta = 4435485909011926;
             C1.pin = 1234;
             C1.balance = 56789;

             C2.Tarjeta = 4357102598724164;
             C2.pin = 1234;
             C2.balance = 78653;

             C3.Tarjeta = 4250577304136266;
             C3.pin = 1234;
             C3.balance = 89000;*/

            Cuenta.Tarjeta = Convert.ToInt64(numeroTarjeta);
            Cuenta.pin = Convert.ToInt32(pin);

            if (Cuenta.Tarjeta.Equals(C1.Tarjeta) && Cuenta.pin.Equals(C1.pin))
            {
                Cuenta.balance = C1.balance;
                return View("Menu");
            }
            else if (Cuenta.Tarjeta.Equals(C2.Tarjeta) && Cuenta.pin.Equals(C2.pin))
            {
                Cuenta.balance = C2.balance;
                return View("Menu");
            }
            else if (Cuenta.Tarjeta.Equals(C3.Tarjeta) && Cuenta.pin.Equals(C3.pin))
            {
                Cuenta.balance = C3.balance;
                return View("Menu");
            }
            
            ViewBag.Message = "Su numero de tarjeta o pin no ha sido reconocida por el cajero";

            return View();

        }

        public IActionResult Menu()
        {
            return View();
        }

        
        public IActionResult Depositar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Depositar(string monto)
        {
            String money = Convert.ToString(Request.Form["ingresardinero"]);
            int dinero;
            if (monto != null && monto != "0")
            {

                dinero = Convert.ToInt32(monto);
                Cuenta.balance += dinero;
                if (Cuenta.Tarjeta.Equals(C1.Tarjeta))
                {
                    C1.balance = Cuenta.balance;
                }
                else if (Cuenta.Tarjeta.Equals(C2.Tarjeta))
                {
                    C2.balance = Cuenta.balance;
                }
                else if (Cuenta.Tarjeta.Equals(C3.Tarjeta))
                {
                    C3.balance = Cuenta.balance;
                }
                return View("TransaccionRealizada");

            }
            else if (monto == null)
            {

                if (money != null)
                {

                    int manual = Convert.ToInt32(money);
                    Cuenta.balance += manual;
                    if (Cuenta.Tarjeta.Equals(C1.Tarjeta))
                    {
                        C1.balance = Cuenta.balance;
                    }
                    else if (Cuenta.Tarjeta.Equals(C2.Tarjeta))
                    {
                        C2.balance = Cuenta.balance;
                    }
                    else if (Cuenta.Tarjeta.Equals(C3.Tarjeta))
                    {
                        C3.balance = Cuenta.balance;
                    }
                    return View("TransaccionRealizada");
                }
            }
            else
            {
                ViewBag.M = "Tiene que seleccionar uno de los dos metodos para ingresar el monto";
            }

            return View();
        }


        /* String d = Convert.ToString(Request.Form["monto"]);

            if (d != "0")
            {
                int dinero = Convert.ToInt32(d);
                
            }
           */
        public IActionResult Retirar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Retirar(string retirodinero)
        {
            String money2 = Convert.ToString(Request.Form["retiro"]);
            int dinero2;
            if (retirodinero != null)
            {
                
                dinero2 = Convert.ToInt32(retirodinero);
                if(Cuenta.balance <= 0 || Cuenta.balance < dinero2)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else
                Cuenta.balance -= dinero2;
                if (Cuenta.Tarjeta.Equals(C1.Tarjeta))
                {
                    C1.balance = Cuenta.balance;
                }
                else if (Cuenta.Tarjeta.Equals(C2.Tarjeta))
                {
                    C2.balance = Cuenta.balance;
                }
                else if (Cuenta.Tarjeta.Equals(C3.Tarjeta))
                {
                    C3.balance = Cuenta.balance;
                }
                return View("TransaccionRealizada");

            }
            else if (retirodinero == null)
            {

                if (money2 != null && money2 != "0")
                {

                    int manual2 = Convert.ToInt32(money2);
                    if(Cuenta.balance <= 0 || Cuenta.balance < manual2)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else
                    Cuenta.balance -= manual2;
                    if (Cuenta.Tarjeta.Equals(C1.Tarjeta))
                    {
                        C1.balance = Cuenta.balance;
                    }
                    else if (Cuenta.Tarjeta.Equals(C2.Tarjeta))
                    {
                        C2.balance = Cuenta.balance;
                    }
                    else if (Cuenta.Tarjeta.Equals(C3.Tarjeta))
                    {
                        C3.balance = Cuenta.balance;
                    }
                    return View("TransaccionRealizada");

                }else if(Cuenta.balance == 0)
                {
                    ViewBag.Message = "No tiene suficiente balance en su cuenta para hacer esta transaccion";
                    return View("Menu");

                }else
                {
                    ViewBag.Message2 = "Tiene que seleccionar uno de los dos metodos para ingresar el monto";
                }

            }

            
            return View();
        }

        public IActionResult ConsultarBalance()
        {

            return View();
        }


        public IActionResult Transferir()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Transferir(string transferirmonto, string numCuentaDestino)
        {
            /*String destinoForm = Convert.ToString(Request.Form["numCuentaDestino"]);*/
            /*String money3 = Convert.ToString(Request.Form["transferirmonto"]);*/
            long destino = Convert.ToInt64(numCuentaDestino);
            int transferir = Convert.ToInt32(transferirmonto);

            if (destino != Cuenta.Tarjeta && transferir != 0 && destino != 0)
            {
                if (Cuenta.Tarjeta == C1.Tarjeta && destino == C2.Tarjeta)
                {
                    if(Cuenta.balance <= 0 || Cuenta.balance < transferir)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else

                    Cuenta.balance -= transferir;
                    C1.balance = Cuenta.balance;
                    C2.balance += transferir;
                    return View("TransaccionRealizada");

                }
                else if (Cuenta.Tarjeta == C1.Tarjeta && destino == C3.Tarjeta)
                {
                    if(Cuenta.balance <= 0 || Cuenta.balance < transferir)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else

                    Cuenta.balance -= transferir;
                    C1.balance = Cuenta.balance;
                    C3.balance += transferir;
                    return View("TransaccionRealizada");

                }
                else if (Cuenta.Tarjeta == C2.Tarjeta && destino == C1.Tarjeta)
                {
                    if(Cuenta.balance <= 0 || Cuenta.balance < transferir)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else
                    
                    Cuenta.balance -= transferir;
                    C2.balance = Cuenta.balance;
                    C1.balance += transferir;
                    return View("TransaccionRealizada");

                }
                else if (Cuenta.Tarjeta == C2.Tarjeta && destino == C3.Tarjeta)
                {
                    if(Cuenta.balance <= 0 || Cuenta.balance < transferir)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else
                    
                    Cuenta.balance -= transferir;
                    C2.balance = Cuenta.balance;
                    C3.balance += transferir;
                    return View("TransaccionRealizada");

                }
                else if (Cuenta.Tarjeta == C3.Tarjeta && destino == C1.Tarjeta)
                {
                    if(Cuenta.balance <= 0 || Cuenta.balance < transferir)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else
                    
                    Cuenta.balance -= transferir;
                    C3.balance = Cuenta.balance;
                    C1.balance += transferir;
                    return View("TransaccionRealizada");

                }
                else if (Cuenta.Tarjeta == C3.Tarjeta && destino == C2.Tarjeta)
                {
                    if(Cuenta.balance <= 0 || Cuenta.balance < transferir)
                    {
                        ViewBag.Message = "Su balance es insuficiente para realizar esta transferencia";
                        return View();
                    }else
                    
                    Cuenta.balance -= transferir;
                    C3.balance = Cuenta.balance;
                    C2.balance += transferir;
                    return View("TransaccionRealizada");

                }
            }else if(transferir == 0)
            {
                ViewBag.Message = "Tiene que especificar una cantidad a transferir";
                return View();

            }

            ViewBag.Message = "Tiene que insertar una tarjeta valida o un numero de tarjeta diferente a la suya";
            return View();
        }

        public IActionResult TransaccionRealizada()
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
