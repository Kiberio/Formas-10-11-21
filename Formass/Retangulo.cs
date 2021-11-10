//Daniel Hiroshi Fugikawa - 200209
namespace Formass
{
    class Retangulo : forma
    {
        //Declarações das variaveis
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        //Calculo da area
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
