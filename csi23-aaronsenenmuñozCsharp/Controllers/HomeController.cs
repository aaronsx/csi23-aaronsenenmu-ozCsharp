using csi23_aaronsenenmuñozCsharp.Models;
using csi23_aaronsenenmuñozCsharp.Servicios;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace csi23_aaronsenenmuñozCsharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Contexto contexto;
        public HomeController(Contexto contexto)
        {
           bool cerrarMenu = false;
            IntServCatering servCatering = new ImpleServCatering();
           
            

            do
            {

                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1 Añadir vajilla");
                Console.WriteLine("2 Mostrar");
                Console.WriteLine("3 Crear Reserva");
                Console.WriteLine("0 Cerrar menu");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Eligue una opcion");
                int menu=Convert.ToInt32(Console.ReadLine());
                
                switch (menu) 
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        servCatering.AñadirVajilla(contexto);
                        break;
                    case 2:
                        servCatering.MostrarStock(contexto);
                        break; 
                    case 3:
                        servCatering.CrearReserva(contexto);
                        break;
                }
                
            } while (!cerrarMenu);

           
        }

        public IActionResult Index()
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