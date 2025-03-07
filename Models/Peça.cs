namespace ControleTransportadora.Models
{
    public class Peça
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int VeiculoId { get; set; }
    }
}
