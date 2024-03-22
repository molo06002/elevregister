using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_elevregister
{
    class Elevregister
    {
        public string namn;
        public int ålder;
        public string adress;
        public int personnummer;

        public void method1()
        {
            Console.WriteLine("Skriv in ditt namn: ");
            string namn = Console.ReadLine();
            Console.WriteLine("Skriv in din ålder: ");
            int ålder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in din adress: ");
            string adress = Console.ReadLine();
            Console.WriteLine("Skriv in ditt personnummer: ");
            int personnummer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Thread.Sleep(1500);
            Console.WriteLine("Bearbetas..");
            Console.Clear();

            Console.WriteLine("Dina svar: ");
            Console.WriteLine("Namn: " + namn);
            Console.WriteLine("Ålder: " + ålder);
            Console.WriteLine("Adress: " + adress);
            Console.WriteLine("Personnummer: " + personnummer);

            List<string> elevlista = new List<string>();
            elevlista.Add(namn);
            string ålder1 = Convert.ToString(ålder);
            elevlista.Add(ålder1);
            elevlista.Add(adress);
            string personnummer1 = Convert.ToString(personnummer);
            elevlista.Add(personnummer1);

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Lista på alla registrerade elever: ");
            Console.WriteLine(elevlista.Capacity);
            Console.WriteLine(elevlista.Count);
            Console.WriteLine(elevlista.Contains(namn));
            Console.WriteLine(elevlista.Contains(ålder1));
            Console.WriteLine(elevlista.Contains(adress));
            Console.WriteLine(elevlista.Contains(personnummer1));

            int p = 0;
 
            foreach (string k in elevlista)
            {
                Console.Write("Rad nummer {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

        }
        public static void method2()
        {
            Console.Clear();
            Console.WriteLine("Avslutas..");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
