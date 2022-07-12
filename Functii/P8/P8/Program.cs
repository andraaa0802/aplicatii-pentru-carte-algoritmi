using System;

namespace P8
{
    class Program
    {
        /// <summary>
        /// Scrieţi definiţia completă a unui subprogram i_prim care primeşte prin singurul său parametru, n, 
        /// un număr natural din intervalul [2,30000] şi returnează diferenţa minimă p2-p1 în care p1 şi p2 sunt numere prime şi p1≤n≤p2.
        /// Exemplu: dacă n=20 atunci i_prim(n)=4, valoare obţinută pentru p1=19 şi p2=23. Functii + Program1.
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(i_prim(n));
        }

        private static int i_prim(int n)
        {
            int p1 = n, p2 = n; //p1 si p2 se initializeaza la n deoarece cele doua numere pot fi si egale cu n 
            while (prim(p1) != true) //cat timp p1 nu este prim, se face p1-1 pana cand p1 devine prim, deoarece p1<=n 
                p1--;
            while (prim(p2) != true) //cat timp p2 nu este prim, se face p2+1 pana cand p2 devine prim, deoarece p2>=n
                p2++;
            return p2 - p1;
        }

        private static bool prim(int nr)
        {
            if (nr < 2) //numerele mai mici decat 2 nu sunt prime
                return false;
            if (nr == 2) //2 este singurul numar par prim
                return true;
            for (int d = 2; d * d <= nr; d++) //se verifica daca numarul are vreun divizor
                if (nr % d == 0)
                    return false;
            return true;
        }
    }
}
