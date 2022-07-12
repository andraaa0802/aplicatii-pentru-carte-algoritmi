using System;

namespace P11
{
    class Program
    {
        /// <summary>
        /// Subprogramul cif, cu doi parametri, primeşte prin intermediul parametrului a un număr natural cu cel mult 8 cifre şi prin intermediul 
        /// parametrului b o cifră; subprogramul returnează numărul de apariţii ale cifrei b în scrierea numărului a. 
        /// Exemplu: pentru a=125854 şi b=5, subprogramul va returna valoarea 2.
        /// Scrieţi definiţia completă a subprogramului cif.Scrieţi un program C# care citeşte de la tastatură un număr natural n 
        /// cu exact 8 cifre, fiecare cifră fiind nenulă, şi care determină şi afişează pe ecran, folosind apeluri utile ale subprogramului cif,
        /// cel mai mic număr palindrom ce poate fi obţinut prin rearanjarea tuturor cifrelor numărului n.
        /// Dacă nu se poate obţine un palindrom din toate cifrele numărului n, programul va afişa pe ecran numărul 0. 
        /// Un număr natural este palindrom dacă este egal cu numărul obţinut prin scrierea cifrelor sale în ordine inversă.
        /// Exemplu: dacă n=21523531 atunci se va afişa pe ecran numărul 12355321, iar dacă n=12272351 atunci se va afişa pe ecran numărul 0.
        /// </summary>
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());

            //intr-un palindrom de 8 cifre, cifrele numarului au un nr par de aparitii; astfel, vom folosi un vector de frecventa care sa numere aparitiile cifrelor
            int[] frecv = new int[10];
            bool ok = true; //variabila care va deveni false in caz ca frecventa unei cifre va fi impara
            for(int i=0;i<10;i++)
            {
                frecv[i] = cif(a, i);
                if (frecv[i]%2!=0)
                {
                    Console.WriteLine(0);
                    ok = false;
                    break;
                }
            }   
            if (ok==true)
            {
                int[] nr = new int[8]; //in acest vector formez noul numar despre care se stie ca are 8 cifre din cerinta
                int poz = 0;
                for(int i=0;i<10;i++)
                    if(frecv[i]%2==0)
                    {
                        while(frecv[i]!=0)
                        {
                            nr[poz] = nr[7 - poz] = i; //pt poz=0, la aceasta instructiune, prima si ultima cifra devin egale cu i; pt poz=1, a doua si penultima cifra devin egale cu i 
                            poz++;
                            frecv[i] -= 2;
                        }
                    }
                for(int i=0;i<8;i++)
                    Console.Write(nr[i]);
            }
        }

        private static int cif(int a, int b)
        {
            int contor = 0; //variabila in care se va retine nr de aparitii a lui b in a
            while(a!=0)
            {
                if (a % 10 == b) //daca ultima cifra a lui a este b, se incrementeaza contor cu 1
                    contor++;
                a /= 10; //se taie ultima cifra din a, fiind deja verificata
            }
            return contor;
        }
    }
}
