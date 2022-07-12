using System;
using System.IO;

namespace P4
{
    class Program
    {
        /// <summary>
        /// În fişierul numere.txt sunt memorate maximum 10000 de numere naturale cu cel mult 9 cifre fiecare.
        /// Fiecare linie a fişierului conţine câte un număr. Se cere afişarea pe ecran, în ordine descrescrescătoare, a tuturor cifrelor 
        /// care apar în numerele din fişier. Alegeţi un algoritm de rezolvare eficient din punct de vedere al timpului de executare.
        /// Exemplu: dacă fişierul numere.txt conţine:267 39628 79, se va tipări 9987766322.
        /// </summary>
        static void Main(string[] args)
        {
            int[] cif = new int[10];//vector de frecventa pt cifrele numerelor din fisier
            foreach (string line in File.ReadLines(@"C:\Users\CRISTI\Desktop\AplicatiiCarte\MetodeSortare\P4\numere.txt"))
            {
                int nr = int.Parse(line);
                while (nr!=0)
                {
                    cif[nr % 10]++; //stocheaza frecventa aparitiei cifrelor din nr, unde nr este numarul citit din fisier
                    nr /= 10;
                }
            }
            for(int i=9;i>=0;i--)
                if(cif[i]!=0)
                    while(cif[i]!=0) //pentru a afisa fiecare cifra de cate ori apare
                    {
                        Console.Write(i);
                        cif[i]--;
                    }
        }
    }
}
