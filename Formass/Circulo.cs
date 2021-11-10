//Daniel Hiroshi Fugikawa - 200209
using System;

namespace Formass
{
    class Circulo : forma
    {
        //Declaração do Raio
        public double Raio { get; set; }
        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
            Color = cor;
        }
        //Calculo da area do circulo
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
