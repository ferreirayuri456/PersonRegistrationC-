namespace Cadastro.model
{
    internal class Telefone
    {

        private int Id { get; set; }
        private string Numero { get; set; }
        private int Ddd { get; set; }
        private string Tipo { get; set; }

        public Telefone(int id, string numero, int ddd, string tipo)
        {
            this.Id = id;
            this.Numero = numero;
            this.Ddd = ddd;
            this.Tipo = tipo;
        }
    }
}