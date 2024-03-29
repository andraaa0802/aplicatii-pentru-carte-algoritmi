﻿using System;

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
        /// Să se scrie un program C# care să citească de la tastatură un număr natural nenul n (n≤100) şi n numere întregi, 
        /// fiecare având cel mult 4 cifre, şi care, folosind apeluri utile ale subprogramului sub, să afişeze pe ecran mesajul DA dacă oricare două dintre 
        /// cele n numere întregi citite sunt distincte două câte două, sau mesajul NU în caz contrar.
        /// Exemplu: pentru n=6 şi cele n numere citite de la tastatură: 47 183 69 8 134 -56 se va afişa pe ecran mesajul DA.
        /// </summary>
        static void Main(string[] args)
        {
            int n, s=0;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele tabloului pe o singura linie: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(buffer[i]);

            for (int i = 0; i < n; i++) //parcurge vectorul
                s += sub(n, v, v[i]); //in s se aduna rezultatul apelului functiei care verifica cate numere sunt mai mici decat v[i]
            if (s==n*(n-1)/2) //atunci cand numerele sunt distincte, in s se afla suma numerelor de la 0 la n-1 care se calculeaza cu suma lui Gauss, prezenta in if
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");

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
