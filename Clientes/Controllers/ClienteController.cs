using Clientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Controllers
{
    public class Clientes : Controller
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private DateOnly dateOnly;

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "João Pedro", "jjdo0800@gmail.com", "0100-3100", new DateOnly(2001, 1, 4));
            Cliente c2 = new Cliente(2, "Bryan", "ratinsemquejo@gmail.com", "0200-3200", new DateOnly(2001, 9, 8));
            Cliente c3 = new Cliente(3, "Carlos", "carlaodolavas@gmail.com", "0300-3300", new DateOnly(2001, 4, 10));
            Cliente c4 = new Cliente(4, "Romero", "romerojogador@gmail.com", "0400-3400", new DateOnly(2001, 6, 6));
            Cliente c5 = new Cliente(5, "Felipe", "minimano@gmail.com", "0500-3500", new DateOnly(2001, 8, 12));


            List<Cliente> listClientes = new List<Cliente>();

            listClientes.Add(c1);
            listClientes.Add(c2);
            listClientes.Add(c3);
            listClientes.Add(c4);
            listClientes.Add(c5);

            return View(listClientes);
        }
    }
}
