using System;

namespace P4
{
    class Program
    {
        /// <summary>
        /// Scrieţi definiţia completă a subprogramului interval care are doi parametri a şi n, 
        /// prin care primeşte un tablou unidimensional cu maximum 100 de numere naturale mai mici decât 1000 
        /// şi respectiv numărul efectiv de elemente din tabloul unidimensional.
        /// Subprogramul returnează numărul de elemente din tabloul unidimensional 
        /// care aparţin intervalului închis determinat de primul şi respectiv ultimul element al tabloului. 
        /// Exemplu: dacă tabloul are 6 elemente şi este de forma (12,27,6,8,9,2), subprogramul va returna valoarea 5.
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Introduceti elementele tabloului pe o singura linie: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(buffer[i]);
            Console.WriteLine("Nr de elemente care apartin intervalului este: " + interval(a,n));
        }

        private static int interval(int[] a, int n)
        {
            int nr1, nr2; //variabile in care se vor memora capetele tabloului
            int nrElemente=0; //variabila in care se va stoca nr de elemente care verifica conditia din cerinta
            //verific care dintre cele doua numere din capete este mai mare si stochez in nr1 numarul mai mic, iar in nr2 numarul mai mare
            if(a[0]>a[n-1])
            {
                nr1 = a[n - 1];
                nr2 = a[0];
            }
            else
            {
                nr1 = a[0];
                nr2 = a[n - 1];
            }

            for (int i = 0; i < n; i++)
                if (a[i] >= nr1 && a[i] <= nr2) //verific apartenenta la interval
                    nrElemente++;

            return nrElemente;
        }
    }
}
