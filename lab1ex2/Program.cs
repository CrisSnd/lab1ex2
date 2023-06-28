using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/

            double primulNumar;
            double alDoileaNumar;
            double alTreileaNumar;

            Console.WriteLine("Acest program va calcula media aritmetica a trei numere" + "\n" + "\n");

            Console.WriteLine("Introduceti primul numar:");
            primulNumar = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            alDoileaNumar = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar:");
            alTreileaNumar = double.Parse(Console.ReadLine());

            double mediaAritmetica = (primulNumar + alDoileaNumar + alTreileaNumar)/3;

            Console.WriteLine("Media aritmetica a celor 3 numere este " + mediaAritmetica + ".");

            
        }
    }
}
