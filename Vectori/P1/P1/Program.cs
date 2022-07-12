using System;
using System.IO;
namespace P1
{
    class Program
    {
        /// <summary>
        /// Să se formeze vectorul primelor n, unde n este un număr natural dat, elemente ale şirului lui Fibonacci: 
        /// 0, 1, 1, 2, 3, 5, 8, 13, 21,.... (f[1]=0, f[2]=1, f[i]=f[i-1]+f[i-2]) și să se afișeze în fișierul fibonacci.out 
        /// </summary>
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\CRISTI\Desktop\AplicatiiCarte\Vectori\P1\fibonacci.out");
            int n = int.Parse(Console.ReadLine());
            int[] f = new int[n];
            int nr1 = 0, nr2 = 1; 
            if (n == 1) //daca n este 1, vectorul il va contine doar pe 0, acesta fiind primul element al sirului lui Fibonacci
                f[0] = nr1;
            else if(n==2) //daca n este 2, vectorul va contine 0 si 1, fiind primele 2 elemente ale sirului
            {
                f[0] = nr1;
                f[1] = nr2;
            }
            else //daca n este mai mare decat 2, incepand cu elementul al 3-lea, elementele se vor forma prin adunarea celor 2 numere precedente
            {
                f[0] = nr1;
                f[1] = nr2;
                int nr3;
                for(int i=2;i<n;i++)
                {
                    nr3 = nr1 + nr2;
                    f[i] = nr3;
                    nr1 = nr2;
                    nr2 = nr3; 
                }
            }
            for (int i = 0; i < n; i++)
                sw.Write(f[i] + " ");
            sw.Close();
        }
    }
}
