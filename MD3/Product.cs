
namespace MD3
{
    public class Product
    {
        public Product(double height, double width, double weight)
        {
            Height = height;
            Width = width;
            Weight = weight;
        }
        public double Height { get; }
        public double Width { get; }
        public double Weight { get; }

        public void Pro()
        {
            Console.WriteLine("product");
        }
    }
}
