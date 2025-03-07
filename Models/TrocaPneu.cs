using ControleTransportadora.Enums;

namespace ControleTransportadora.Models
{
    public class TrocaPneu : Manutencao
    {
        public Eixo Eixo { get; set; }
        public LadoPneu Lado { get; set; }
        public int QtdReformas { get; set; }
    }
}
