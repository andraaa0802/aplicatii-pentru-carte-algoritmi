using System;

namespace P11
{
    class Program
    {
        /// <summary>
        /// Subprogramul cif, cu doi parametri, primeşte prin intermediul parametrului a un număr natural cu cel mult 8 cifre şi prin intermediul 
        /// parametrului b o cifră; subprogramul returnează numărul de apariţii ale cifrei b în scrierea numărului a. 
        /// Exemplu: pentru a=125854 şi b=5, subprogramul va returna valoarea 2.
        /// </summary>
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(cif(a,b));
        }

        private static int cif(int a, int b)
        {
            int contor = 0; //variabila in care se va retine nr de aparitii a lui b in a
            while(a!=0)
            {
                if (a % 10 == b)
                    contor++;
                a /= 10;
            }
            return contor;
        }
    }
}
