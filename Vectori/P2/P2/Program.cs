using System;
using System.IO;

namespace P2
{
    class Program
    {
        /// <summary>
        /// Fișierul date.in conține numere naturale mai mici decât 100. Se cere să se afișeze, în ordine crescătoare elementele aflate 
        /// în fișier. Indicație: se va crea un tablou, inițializat cu zero, care “numără” elementele din fișier. Astfel, fiecare număr din 
        /// fișier este considerat indice al tabloului și, de fiecare data când este extrase, valoarea din tablou este incrementată (v[x]=v[x]+1)
        /// </summary>
        
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\CRISTI\Desktop\AplicatiiCarte\Vectori\P2\date.in");
            string[] buffer = sr.ReadLine().Split(' ');
            int lungime = buffer.Length; //lungimea vectorului este egala cu lungimea stringului citit de pe prima linie
            int[] v_initial = new int[lungime];
            int maxim = -1; //avem nevoie sa gasim maximul pentru a stabili lungimea vectorului ce trebuie creat
            
            for(int i=0;i<lungime;i++)
            {
                v_initial[i] = int.Parse(buffer[i]);
                if (v_initial[i] > maxim)
                    maxim = v_initial[i];
            }
            int[] v = new int[maxim + 1];
            for(int i=0;i<lungime;i++)
                v[v_initial[i]]++; //numaram aparitiile numerelor din vectorul initial
            for(int i=0;i<maxim+1;i++)
                if(v[i]!=0)
                    while (v[i]!=0) //pentru numerele care apar de mai multe ori, le vom afisa de cate ori apar
                    {
                        Console.Write(i+" ");
                        v[i]--;
                    }
        }
    }
}
