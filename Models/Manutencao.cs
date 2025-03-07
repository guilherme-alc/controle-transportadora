namespace ControleTransportadora.Models
{
    public abstract class Manutencao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Quilometragem { get; set; }
        public int VeiculoId { get; set; }
    }
}
