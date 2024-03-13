
namespace HHTaskLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string typeName, double radius) : base(typeName)
        {
            Radius = radius;
        }

        public override double Square()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 1);
        }
    }
}
