using System;

namespace P10
{
    class Program
    {
        /// <summary>
        /// Un număr n se numeşte extraprim dacă atât el, cât şi orice număr obţinut prin permutarea cifrelor lui n, sunt numere prime.
        /// De exemplu, numărul 113 este un număr extraprim deoarece 113, 311, 131 sunt numere prime.
        /// Scrieţi definiţia completă a unui subprogram e_prim, cu un parametru, subprogram care primeşte prin intermediul parametrului a 
        /// un număr natural cu cel mult 3 cifre (a>1) si returnează suma tuturor exponenţilor din descompunerea în factori primi a valorii
        /// parametrului a.Exemplu: pentru a=90 subprogramul va returna valoarea 4, deoarece a=2*3^2*5 şi 1+2+1=4.
        /// Scrieţi un program C# care citeşte de la tastatură un număr natural n, 2≤n≤999 şi, folosind apeluri utile ale subprogramului e_prim, 
        /// verifică dacă n este un număr extraprim. În caz afirmativ, programul afişează pe ecran mesajul DA, în caz contrar afişând mesajul NU.
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //ca un nr sa fie prim, suma exponentilor din descompunerea in factori primi trebuie sa fie 1
            //astfel, ca un nr sa fie extraprim, atat suma exponentilor din descompunerea in factori primi a numarului n, cat si a numerelor obtinute
            //din permutarea cifrelor lui n, trebuie sa fie 1

            if(n<10) //daca n are o singura cifra, e de ajuns sa verificam daca e_prim(n) este 1
                if(e_prim(n)==1)
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NU");
            else if (n>9 && n<100) //daca n are 2 cifre, trebuie sa verificam atat pt n, cat si pentru n inversat
                if(e_prim(n)==1 && e_prim(n%10*10+n/10)==1)
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NU");
            else if (n>99 && n<1000) //daca n are 3 cifre, trebuie sa verificam atat pt n, cat si pt permutarile lui n
            {
                //pt a nu ne incurca, iau 3 variabile in care sa retin fiecare cifra a lui n, astfel putand sa verific mai usor permutarile
                int a, b, c;
                a = n / 100;
                b = n / 10 % 10;
                c = n % 10;
                //reformam numerele in functie de a,b,c a.i. sa obtinem permutarile lui n
                if(e_prim(n)==1 && e_prim(a*100+c*10+b)==1 && e_prim(b*100+a*10+c)==1 && e_prim(b*100+c*10+a)==1 && e_prim(c*100+a*10+b)==1 && e_prim(c*100+b*10+a)==1)
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NU");
            }
        }

        private static int e_prim(int n)
        {
            int p, d = 2, sum=0; //in p se va tine minte puterea la care se afla factorul prim in descompunerea lui n, 
           //d este factorul prim cu care se va incerca divizarea lui n, iar sum este variabila in care se memoreaza suma puterilor factorilor primi din descompunerea lui n 
            while (n!=1) 
            {
                p = 0; 
                while (n%d==0) //cat timp n se divide cu n, se face aceasta divizare si se aduna 1 la p, adica puterea factorului d creste cu 1 
                {
                    n /= d;
                    p++;
                }
                if (p > 0) 
                    sum += p;
                d++;
            }
            return sum;
        }
    }
}
