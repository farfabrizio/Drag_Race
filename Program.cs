using System.Reflection;
using System.Threading.Channels;

namespace Drag_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Blocco Try");

                Moto kawasaki1 = new Moto("Kawasaki", "Ninja ZX-10R", 200, -2.6, 998);
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
            /*
            catch (ArgumentNullException ex)   questa scrittura sarebbe inutile visto NullException è figlia di ArgumentException
            { 
                Console.WriteLine(ex.ToString());
            }
            */
            catch (Exception ex)  // eccezioni generiche non previste
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Blocco successivo al Try and Catch");

            Moto m3 = new Moto("Benelli", "Fantic", 50, 5.5, 125);
            Moto m4 = new Moto(m3);
            Console.WriteLine(m3);
            Console.WriteLine(" Creazione Moto con metodo costruttore di copia");
            Console.WriteLine(m4);
            Console.WriteLine("Programma Eseguito ");

            // per capire il costruttore di copia fare questo esempio

            //Moto m3 = new Moto("Benelli", "Fantic", 50, 5.5, 125);
            Moto m5 = m3;// ATTENZIONE: Nessun 'new', nessuna copia!
            Console.WriteLine(m5.Equals(m3));
            m3.Cilindrata = 1200;
            Console.WriteLine(m5);
        }

       
    }
}
