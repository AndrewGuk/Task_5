namespace Cone
{
    public class Cones
    {
        double radius{ get; set; }
        double height { get; set; }
        public double areaSurface;
        public double areaTotal;

        public  Cones(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            areaSurface = AreaSurfaceBase(this.radius, this.height);
            areaSurface = AreaTotal(radius, height);
        }
        double AreaSurfaceBase(double radius, double height)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Here we see how the method is used <AreaSurfaceBase>:");
            Console.WriteLine($"Radius is <{radius}>, height is <{height}>");
            double area = (Math.PI * radius) * Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Base surface area is {area}.");
            return area;
        }
        double AreaTotal(double radius, double height)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Here we see how the method is used <AreaTotal>:");
            double areaBase = AreaSurfaceBase(radius, height);
            double areaSurface = Math.PI * Math.Pow(radius, 2);
            double areaTotal = areaBase + areaSurface;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Full surface of the cone is {areaTotal}.");
            return areaTotal;
        }
    }
}