using System;
using System.IO;

namespace P5
{
    class Program
    {/// <summary>
     /// În fişierul numere.txt pe prima linie este memorat un număr natural n (n≤10000), iar pe linia următoare un şir de n numere naturale 
     /// distincte două câte două, separate prin câte un spaţiu, cu maximum 4 cifre fiecare. Se cere afişarea pe ecran a poziţiei pe care s-ar
     /// găsi primul element din şirul aflat pe linia a doua a fişierului, în cazul în care şirul ar fi ordonat crescător.
     /// Numerotarea poziţiilor elementelor în cadrul şirului este de la 1 la n. Alegeţi un algoritm de rezolvare eficient din punct de vedere 
     /// al memoriei utilizate şi al timpului de executare. Exemplu: dacă fişierul numere.txt conţine: 6 267 13 45 628 7 79, se va afişa 5, 
     /// deoarece primul element din şirul iniţial, 267, s-ar găsi pe poziţia a cincea în şirul ordonat crescător (7 13 45 79 267 628).
     /// </summary>
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\CRISTI\Desktop\AplicatiiCarte\MetodeSortare\P5\Numere.txt");
            int n = int.Parse(sr.ReadLine());
            int[] v = new int[n]; 
            string[] buffer = sr.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(buffer[i]);
            int nr1 = v[0]; //retin primul numar din sir
            //sortez crescator sirul
            for(int i=0;i<n-1;i++)
                for(int j=i+1;j<n;j++)
                    if(v[i]>v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            //caut nr1 in vectorul ordonat si afisez pozitia la care a fost gasit
            for(int i=0;i<n;i++)
                if(v[i]==nr1)
                {
                    Console.WriteLine(i+1); //adaug 1 la i pentru a pastra numerotarea de la 1 la n
                    break;
                }
        }
    }
}
