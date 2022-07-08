using System;

namespace P3
{
    class Program
    {
        /// <summary>
        /// Scrieţi definiţia completă a subprogramului multiplu care are 3 parametri:
        /// a, prin care primeşte un tablou unidimensional cu maximum 100 de numere naturale mai mici decât 1000,
        /// n, numărul efectiv de elemente ale tabloului şi k, un număr natural (k≤9). 
        /// Subprogramul returnează numărul de elemente din tablou care sunt multipli ai numărului k şi au ultima cifră egală cu k.
        /// Exemplu: dacă n=6, a=(9,273,63,83,93,123), iar k=3, subprogramul va returna valoarea 4.
        /// </summary>
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Introduceti n (nr. de elemente): ");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Introduceti pe o singura linie elementele tabloului: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(buffer[i]);
            Console.WriteLine("Introduceti k: ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Nr de elemente care respecta cerinta este: "+multiplu(a,n,k));
        }

        private static int multiplu(int[] a, int n, int k)
        {
            int nrElemente = 0; //stocheaza nr de elemente care respecta cerinta
            for (int i = 0; i < n; i++)
                if (a[i] % k == 0 && a[i] % 10 == k) //verifica daca elementul de pe pozitia i este divizibil cu k si are ultima cifra k
                    nrElemente++;
            return nrElemente;
        }
    }
}
