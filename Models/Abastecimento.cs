namespace ControleTransportadora.Models
{
    public class Abastecimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int VeiculoId { get; set; }
        public int Quilometragem { get; set; }
        public double Litros { get; set; }
        public decimal Valor { get; set; }
    }
}
