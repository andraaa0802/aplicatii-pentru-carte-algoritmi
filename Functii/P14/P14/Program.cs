using System;

namespace P17
{
    class Program
    {/// <summary>
     ///Scrieţi definitia funcţiei sum care primeşte ca parametru un număr natural nenul x cu maximum 9 cifre şi returnează suma divizorilor
     ///numărului x.Exemplu: sum(6) are valoarea 12 (=1+2+3+6). Să se scrie un program C# care citeşte de la tastatură un număr natural n (0<n<25) 
     ///şi apoi n numere naturale nenule cu maximum 9 cifre fiecare. Programul calculează, folosind apeluri ale funcţiei sum, 
     ///şi afişează pe ecran câte numere prime conţine şirul citit. Exemplu: pentru n=5 şi valorile 12 3 9 7 1 se va afişa pe ecran valoarea 2 
     ///(în şirul dat există două numere prime şi anume 3 şi 7).
     /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            int contor = 0; //numara numerele prime
            Console.WriteLine("Introduceti sirul pe o singura linie: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for(int i=0;i<n;i++)
            {
                int nr = int.Parse(buffer[i]);
                if (sum(nr) == 1 + nr) //un numar este prim daca suma divizorilor sai este egala cu 1+nr, deoarece divizorii unui numar prim sunt 1 si el insusi
                    contor++; 
            }
            Console.WriteLine(contor);
        }

        private static int sum(int n)
        {
            if (n == 1)//suma divizorilor lui 1 este 1 
                return 1;
            int suma = 1+n; //se va memora suma divizorilor; primul divizor al unui nr este 1, iar ultimul este mereu el insusi
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) //daca n se divide cu i, adaugam i la suma
                    suma += i;
            return suma;
        }
    }
}
