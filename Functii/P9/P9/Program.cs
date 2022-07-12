using System;

namespace P9
{
    class Program
    {
        /// <summary>
        /// Subprogramul sub, cu trei parametri, primeşte prin intermediul parametrilor: v un tablou unidimensional cu cel mult 100 de componente
        /// ce memorează numere întregi de cel mult 4 cifre fiecare, n un număr natural nenul mai mic sau egal cu 100 ce reprezintă numărul 
        /// efectiv de componente ale tabloului primit prin intermediul parametrului v, a un număr întreg cu cel mult 4 cifre.
        /// Subprogramul sub returnează numărul componentelor tabloului primit prin intermediul parametrului v ale căror valori sunt 
        /// strict mai mici decât valoarea parametrului a.Exemplu: pentru valorile n=5, v=(1,21,9,21,403), a=20 ale parametrilor, în urma apelului, 
        /// subprogramului sub va returna valoarea 2. Scrieţi definiţia completă a subprogramului sub.
        /// </summary>
        static void Main(string[] args)
        {
            int n, a;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele tabloului pe o singura linie: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(buffer[i]);
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(sub(n,v,a));
        }

        private static int sub(int n, int[] v, int a)
        {
            int contor = 0; //numara cate numere verifica conditia din cerinta
            for (int i = 0; i < n; i++)
                if (v[i] < a)
                    contor++;
            return contor;
        }
    }
}
