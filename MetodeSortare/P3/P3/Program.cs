using System;
using System.IO;
namespace P3
{
    class Program
    {
        /// <summary>
        /// Se consideră fişierul BAC.TXT ce conţine cel mult un milion de numere naturale separate prin spatii, fiecare număr având 
        /// cel mult nouă cifre. Scrieţi un program C# care citeşte toate numerele din fişierul BAC.TXT şi determină, folosind un algoritm 
        /// eficient din punct de vedere timpului de executare, cele mai mari două numere de trei cifre care nu se află în fişier. 
        /// Cele două numere vor fi afişate pe ecran în ordine descrescătoare, cu un spaţiu între ele. Dacă nu pot fi determinate două astfel 
        /// de numere, programul va afişa pe ecran valoarea 0. 
        /// Exemplu: dacă fişierul BAC.TXT conţine numerele: 12 2345 123 67 989 6 999 123 67 989 999, atunci programul va afişa 998 997
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\CRISTI\Desktop\AplicatiiCarte\MetodeSortare\P3\BAC.txt");
            int[] v = new int[1000]; //vector de frecventa pt numerele de 3 cifre din fisier
            string[] buffer = sr.ReadLine().Split(' ');
            for(int i=0;i<buffer.Length;i++)
            {
                int nr = int.Parse(buffer[i]);
                if(nr>99 && nr<1000) //daca nr are 3 cifre, v[nr] creste cu 1
                    v[nr]++;
            }
            int contor = 0; //variabila menita sa numere cate numere se afiseaza, iar cand/daca ajunge la 2 programul se va opri 
            for(int i=999;i>=100 && contor<2;i--) //parcurge vectorul de la 999 pana la 100, cat timp contor<2, adica numerele nu au fost inca determinate
                if(v[i]==0 && contor==0) //daca v[i] si contor sunt 0, inseamna ca i nu apartine numerelor din fisier si este primul numar care verifica conditia
                {
                    Console.Write(i+" ");
                    contor++;
                }
                else if(v[i]==0 && contor==1) //daca v[i] este 0 si contor este 1, inseamna ca i nu apartine numerelor din fisier si este al doilea numar care verifica conditia
                {
                    Console.Write(i+" ");
                    contor++;
                }
            if(contor==0)
                Console.WriteLine(0);
        }
    }
}
