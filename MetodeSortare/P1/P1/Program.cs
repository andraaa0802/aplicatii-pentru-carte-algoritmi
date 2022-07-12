using System;
using System.IO;
namespace P1
{
    class Program
    {
        /// <summary>
        /// Fişierul text NR.TXT conţine pe o singură linie, separate prin câte un singur spaţiu, cel mult 100 de numere naturale, 
        /// fiecare număr având cel mult 4 cifre. Scrieţi un program C# care citeşte toate numerele din fişierul NR.TXT şi afişează pe ecran,
        /// separate prin câte un spaţiu, în ordine crescătoare, toate numerele din fişier care au cel puţin 3 cifre.
        /// Dacă fişierul nu conţine astfel de numere se va afişa pe ecran mesajul NU EXISTA.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\CRISTI\Desktop\AplicatiiCarte\MetodeSortare\P1\NR.txt");
            string[] buffer = sr.ReadLine().Split(' ');
            int lungime = buffer.Length; //numarul de numere aflate in fisier
            int[] v = new int[lungime]; //creez un vector de aceeasi lungime ca si numarul numerelor din fisier, presupunand ca toate au cel putin 3 cifre
            int contor = 0;//numar numerele care verifica conditia
            for(int i=0;i<buffer.Length;i++)
            {
                int nr = int.Parse(buffer[i]);
                if(nr>99)
                {
                    v[contor] = nr; //punem in v numerele care verifica conditia
                    contor++;
                }
            }
            if (contor!=0) //daca contor!=0 inseamna ca avem numere care sa verifice conditia si sortam crescator vectorul
            {
                for(int i=0;i<contor-1;i++)
                    for(int j=i+1;j<contor;j++)
                        if(v[i]>v[j])
                        {
                            int aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                        }
                for(int i=0;i<contor;i++) //afisam numerele
                    Console.Write(v[i]+" ");
            }
            else
                Console.WriteLine("NU EXISTA");

        }
    }
}
