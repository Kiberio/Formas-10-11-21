//Daniel Hiroshi Fugikawa - 200209
namespace Formass
{
    abstract class forma
    {
        //Declaração dos variaveis
        public Color Color { get; set; }
        public forma(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
