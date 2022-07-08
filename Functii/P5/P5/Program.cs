using System;

namespace P5
{
    class Program
    {
        /// <summary>
        /// Scrieţi definiţia completă a subprogramului count care are doi parametri, a şi n,
        /// prin care primeşte un tablou unidimensional cu maximum 100 de numere reale 
        /// şi respectiv numărul efectiv de elemente din tablou. Subprogramul returnează 
        /// numărul de elemente din tabloul a care sunt mai mari sau cel puţin egale 
        /// cu media aritmetică a tuturor elementelor din tablou.
        /// Exemplu: dacă tabloul are 6 elemente şi este de forma  (12, 7.5, 6.5, 3, 8.5, 7.5),
        /// subprogramul va returna valoarea 4 (deoarece media tuturor elementelor este 7.5 şi 
        /// numerele subliniate sunt cel puţin egale cu această medie).6.
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            Console.WriteLine("Introduceti elementele tabloului pe o singura linie: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                a[i] = float.Parse(buffer[i]);
            Console.WriteLine("Nr de elemente este: "+ count(a,n));
        }

        private static int count(float[] a, int n)
        {
            float suma = 0, media; //in suma se va stoca suma elementelor pentru a putea face media lor aritmetica,n in medie se va stoca media
            int nrElemente = 0; //in nrElemente se va stoca nr de elemente care verifica consitia
            for (int i = 0; i < n; i++) //parcurgem vectorul pentru a face suma elementelor
                suma += a[i];
            media = suma / n;

            for (int i = 0; i < n; i++) //parcurgem vectorul pentru a verifica conditia din cerinta
                if (a[i] >= media)
                    nrElemente++;
            return nrElemente;
        }
    }
}
