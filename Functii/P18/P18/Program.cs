using System;
using System.IO;
namespace P18
{
    class Program
    {/// <summary>
     ///Se consideră subprogramul P care are doi parametri: 
     /// -  n, prin intermediul căruia primeşte un număr natural de cel mult 9 cifre
     /// -  c, prin intermediul căruia primeşte o cifră.  Subprogramul va furniza tot prin intermediul parametrului n numărul 
     /// obţinut din n prin eliminarea tuturor apriţiilor cifrei c. Dacă, după eliminare, numărul nu mai conţine nicio cifră sau 
     /// conţine doar cifre 0, rezultatul returnat va fi 0. Pe prima linie a fişierului text BAC.IN se găsesc, separate prin câte 
     /// un spaţiu, mai multe numere naturale de cel mult 9 cifre fiecare. Scrieţi programul C# care citeşte numerele din acest fişier,
     /// utilizând apeluri ale subprogramului P elimină toate cifrele impare din fiecare dintre aceste numere şi apoi scrie în fişierul text BAC.OUT
     /// numerele astfel obţinute, separate prin câte un spaţiu. Dacă un număr din fişierul BAC.IN nu conţine nicio cifră pară nenulă, 
     /// acesta nu va mai apărea deloc în fişierul de ieşire. 
     /// Exemplu: dacă fişierul BAC.IN conţine numerele 25 7 38 1030 45127 0 35 60 15, atunci BAC.OUT va avea conţinutul: 2 8 42 60. 
     /// </summary>
        static void Main(string[] args)
        {
            int nr;
            StreamReader sr = new StreamReader(@"..\..\BAC.IN");
            StreamWriter sw = new StreamWriter(@"..\..\BAC.OUT");
            string[] buffer = sr.ReadLine().Split(' ');
            for(int i=0;i<buffer.Length;i++) //se parcurge prima linie citita din fisier
            {
                nr = int.Parse(buffer[i]); //in nr se retine numarul de pe pozitia i din fisier
                for (int j = 1; j <= 9; j += 2) //cu acest for se parcurg cifrele impare
                    P(ref nr, j); //apeleaza subprogramul pentru nr si fiecare cifra impara
                if (nr != 0) //daca nr este diferit de 0, il afiseaza
                    sw.Write(nr + " ");
            }
            sr.Close();
            sw.Close();
        }
        private static void P(ref int n, int c)
        {
            int a=0, p=1;//in a se va retine numarul nou, iar p se va folosi pentru a pastra ordinea cifrelor
            while (n!=0)
            {
                if (n % 10 != c) //daca ultima cifra a lui n este diferita de c o adauga la a
                {
                    a += n % 10 * p;
                    p *= 10;
                }
                n /= 10;
            }
            n = a;
        }
    }
}
