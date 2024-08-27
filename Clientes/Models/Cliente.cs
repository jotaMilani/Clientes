namespace Clientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNasc { get; set; }


        public Cliente(int Id, string Nome, string Email, string Telefone, DateOnly DataNasc)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
            this.Telefone = Telefone;
            this.DataNasc = DataNasc;

        }


    }
}
