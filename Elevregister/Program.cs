// See https://aka.ms/new-console-template for more information
using System; 
namespace class_elevregister
{
    class Program
    {
        static void Main()
        {
            Elevregister elev1 = new Elevregister();
            elev1.method1();
            Elevregister.method2();
            Elevregister elev2 = new Elevregister();
            elev2.method1();
            Elevregister.method2();
            

        }
    }
}