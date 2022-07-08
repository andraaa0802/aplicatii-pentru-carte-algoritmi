using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k: ");
            k = int.Parse(Console.ReadLine());
            sub(n, k);
        }
        /// <summary>
        /// 1.	Scrieţi definiţia completă a subprogramului sub cu doi parametri:
        /// n (număr natural, 0<n≤50) şi k (număr natural, 0<k≤20).
        /// Subprogramul determină afişarea pe o linie nouă a ecranului, 
        /// în ordine descrescătoare, a primelor n numere naturale nenule divizibile cu k.
        /// Numerele vor fi separate prin câte spaţiu. 
        /// Exemplu: dacă n=3  şi k=5 la apelul subprogramului se va afişa pe ecran: 15 10 5.
        /// </summary>
       
        private static void sub(int n, int k)
        {
            //primele n numere naturale nenule divizibile cu k <=> primii n multipli ai lui k
            //acesti multipli pot fi obtinuti prin inmultirea lui k cu 1, 2, ..., n
            //pentru a-i putea afisa descrescator, inep inmultirea lui k cu n, n-1, ..., 1
            Console.WriteLine("Primele n numere divizibile cu k, afisate descrescator, sunt: ");
            for(int i=n;i>=1;i--)
                Console.Write(k*i+" ");
        }
    }
}
