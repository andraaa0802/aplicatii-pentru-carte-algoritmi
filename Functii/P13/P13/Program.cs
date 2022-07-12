using System;

namespace P13
{
    class Program
    {/// <summary>
     /// Subprogramul f, cu un parametru primeşte prin intermediul parametrului a un număr natural cu cel mult 8 cifre (a>1) 
     /// si returnează cel mai mic divizor prim al valorii parametrului a.Exemplu: pentru valoarea 45 a parametrului a, subprogramul va returna
     /// valoarea 3 deoarece a=32*5, iar cel mai mic divizor prim al său este 3. Scrieţi definiţia completă a subprogramului f. 
     /// Scrieţi un program C# care să citească de la tastatură un număr natural nenul n (n≤100) şi apoi un şir de n numere naturale de cel mult 
     /// 8 cifre fiecare, toate numerele din şir fiind strict mai mari decât 1. Folosind apeluri utile ale subprogramului f, programul va determina
     /// şi va afişa pe ecran toate numerele prime din şirul citit. Numerele determinate se vor afişa pe ecran, separate prin câte un spaţiu, 
     /// în ordine crescătoare a valorii lor. Dacă nu există astfel de numere se va afişa pe ecran mesajul NU EXISTA.
     /// Exemplu: pentru n=7, şirul: 1125, 2, 314, 101, 37, 225, 12 pe ecran se va afişa: 2 37 101.
     /// </summary>
        static void Main(string[] args)
        {
            int n, nr;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n]; //declaram un vector in care se vor stoca numerele prime
            int contor = 0;//numaram cate numere prime am gasit si punem pe pozitia contor din v numarul prim gasit 
            Console.WriteLine("Introduceti pe o singura linie numerele: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for(int i=0;i<n;i++)
            {
                nr = int.Parse(buffer[i]);
                if(f(nr)==nr) //daca functia returneaza acelasi nr inseamna ca nu a gasit divizori pt nr, deci nr este prim
                {
                    v[contor] = nr;
                    contor++;
                }
            }
            //sortam vectorul cu valori prime
            for(int i=0;i<contor-1;i++)
                for(int j=i+1;j<contor;j++)
                    if(v[j]<v[i])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            //afisam numerele prime daca exista
            if (contor!=0)
                for(int i=0;i<contor;i++)
                    Console.Write(v[i]+" ");
            else
                Console.WriteLine("NU EXISTA");
        }

        private static int f(int n)
        {
            for (int i = 2; i <= n / 2; i++) //cauta, de la 2, un divizor prim pentru n; daca nu gaseste, returneaza n
                if (n % i == 0)
                    return i;
            return n;
        }
    }
}
