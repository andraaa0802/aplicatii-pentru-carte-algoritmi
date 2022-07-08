using System;

namespace P2
{
    class Program
    {
        /// <summary>
        /// Scrieţi definiţia completă a subprogramului sub cu trei parametri:
        /// n (număr natural, 5<n≤30000), a  şi b; subprogramul furnizează prin intermediul 
        /// parametrilor a şi b cele mai mari două numere prime distincte mai mici decât  n. 
        /// Exemplu: dacă n= 28 la apelul subprogramului se va furniza prin parametrul a valoarea 23 şi prin parametrul b valoarea 19.
        /// </summary>
        static void Main(string[] args)
        {
            int n,a=-1,b=-1;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            sub(n, ref a, ref b);
            Console.WriteLine("Primele doua numere prime mai mici decat n sunt: " + a +" "+ b);
        }

        private static void sub(int n, ref int a, ref int b)
        {
            bool prim=false; //prin intrmediul acestei variabile vom retine daca un nr este sau nu prim

            n--; //deoarece numerele trebuie sa fie mai mici decat n
            if (n % 2 == 0)
                n--; //deoarece un numar par sigur nu e prim
            
            for (int i=n;i>0 && prim==false;i-=2) //i merge din 2 in 2, descrescator, pt a sari peste numerele pare
            {
                prim = true; //presupunem ca i este nr prim, iar daca se va dovedi ca nu este, prim va redeveni false
                for (int j = 3; j * j <= i; j += 2)
                    if (i % j == 0)
                    {
                        prim = false; //daca i se imparte exact la j, inseamna ca nu este prim si putem trece la j+2
                        break;
                    }
                if (prim==true) //daca prim a ramas true inseamna ca nu s-a gasit niciun divizor pt i si se iese din for deoarece prim != false
                    a = i;
            }

            prim = false;
            for(int i=a-2;i>0 && prim==false; i-=2) //cautam al doilea nr prim incepand cu a-2; comentariile de mai sus raman valabile si aici
            {
                prim = true; 
                for (int j = 3; j * j <= i; j += 2)
                    if (i % j == 0)
                    {
                        prim = false; 
                        break;
                    }
                if (prim == true) 
                    b = i;
            }
        }
    }
}
