using System;

namespace P19
{
    class Program
    {
        /// <summary>
        /// Scrieţi definiţia completă a unui subprogram, nz, cu un parametru întreg n (0<n≤32000), care returnează 
        /// numărul zerourilor de la sfârşitul numărului n!. Scrieţi programul  C# care citește de la tastatură un număr 
        /// natural k (0<k≤3) și determină, folosind apeluri ale subprogramului nz, cel mai mic număr natural n pentru care n! 
        /// are cel puţin k zerouri la sfârşit. Numărul determinat se afișează pe ecran.
        /// </summary>
        static void Main(string[] args)
        {
            int k;
            k = int.Parse(Console.ReadLine());
            bool ok = false; //variabila care ne va spune cand se va gasi numarul cautat
            for(int i=0;ok==false;i++) 
                if(nz(i)==k) //verificam conditia din cerinta pana cand ne convine rezultatul
                {
                    Console.WriteLine(i);
                    ok = true;
                }
        }

        private static int nz(int n)
        {
            int s = 0, p = 5; //in s se va retine numarul de zerouri, iar la p se va imparti numarul pentru a-i afla nr de zerouri
            while(p<=n)
            {
                s += n / p; 
                p *= 5;
            }
            return s;
        }
    }
}
