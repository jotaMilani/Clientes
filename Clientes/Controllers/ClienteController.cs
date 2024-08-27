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

        public Clientes(int v1, string v2, string v3, string v4, DateOnly dateOnly)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.dateOnly = dateOnly;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetClientes()
        {
            Clientes c1 = new Clientes(1, "João Pedro", "jjdo0800@gmail.com", "0100-3100", new DateOnly(2001, 30, 4));
            Clientes c2 = new Clientes(2, "Bryan", "ratinsemquejo@gmail.com", "0200-3200", new DateOnly(2001, 9, 8));
            Clientes c3 = new Clientes(3, "Carlos", "carlaodolavas@gmail.com", "0300-3300", new DateOnly(2001, 14, 10));
            Clientes c4 = new Clientes(4, "Romero", "romerojogador@gmail.com", "0400-3400", new DateOnly(2001, 6, 6));
            Clientes c5 = new Clientes(5, "Felipe", "minimano@gmail.com", "0500-3500", new DateOnly(2001, 18, 12));


            List<Clientes> listClientes = new List<Clientes>();

            listClientes.Add(c1);
            listClientes.Add(c2);
            listClientes.Add(c3);
            listClientes.Add(c4);
            listClientes.Add(c5);

            return View(listClientes);
        }
    }
}
