namespace Drag_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto Kawasaki1 = new Moto("Kawasaki","Ninja ZX-10R", 200, 2.6, 998);
            Console.WriteLine(Kawasaki1.ToString());

            Moto Yamaha1= new Moto("Yamaha", "YZF-R1", 200, 2.7, 998);
            Console.WriteLine(Yamaha1.ToString());
            Console.WriteLine(Kawasaki1.ConfrontoCilindrata(Yamaha1));

            Console.WriteLine(Yamaha1.ConfrontaAccelerazione(Kawasaki1));
        }
    }
}
