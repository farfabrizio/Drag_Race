using System.Reflection;

namespace Drag_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creazione de");

                Moto kawasaki1 = new Moto("Kawasaki", "Ninja ZX-10R", -200, 2.6, 998);
                Console.WriteLine(kawasaki1);

                Moto yamaha1 = new Moto("Yamaha", "YZF-R1", 200, 2.7, 998);
                Console.WriteLine(yamaha1);
                Console.WriteLine(kawasaki1.ConfrontoCilindrata(yamaha1));

                Console.WriteLine(yamaha1.ConfrontaAccelerazione(kawasaki1));

            }
            catch (ArgumentException ex)  //eccezioni personalizzate utilizzate e previste nelle proprietà
            {

                Console.WriteLine(ex.ToString());

            }

            catch (Exception ex)  // eccezioni generiche non previste
            {
                Console.WriteLine(ex.ToString());
            }

            Moto m3 = new Moto("Benelli", "Fantic", 50, 5.5, 125);
            Moto m4 = new Moto(m3);
            Console.WriteLine(m3);
            Console.WriteLine(" Creazione Moto con metodo costruttore di copia");
            Console.WriteLine(m4);
            Console.WriteLine("Programma Eseguito ");
        }

        // per capire il costruttore di copia fare questo esempio

        //Moto m3 = new Moto("Benelli", "Fantic", 50, 5.5, 125);
       // Moto m4 = m3; ATTENZIONE: Nessun 'new', nessuna copia!
    }
}
