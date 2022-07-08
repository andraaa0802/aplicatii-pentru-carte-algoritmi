using System;

namespace P7
{
    class Program
    {
        /// <summary>
        /// 7.	Subprogramul nule are doi parametri: a, prin care primeşte un tablou unidimensional  
        /// cu maximum 100 de numere întregi, cu cel mult 4 cifre fiecare şi n, numărul de elemente din tablou. 
        /// Subprogramul rearanjează elementele tabloului unidimensional astfel încât toate valorile nule 
        /// să se afle la sfârşitul tabloului. Ordinea în cadrul secvenţei de elemente nenule poate fi oricare.
        /// Tabloul modificat este furnizat tot prin parametrul a. Exemplu: dacă n=6, a=(12,0,0,-3,-8,0),
        /// după apel, acesta ar putea fi:  a=(12,-3,-8,0,0,0).  Scrieţi definiţia completă a subprogramului nule.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Introduceti elementele tabloului pe o singura linie: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                a[i] = double.Parse(buffer[i]);
            nule(ref a, n);
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }

        private static void nule(ref double[] a, int n)
        {
            double temp; 
            for (int i = 0; i < n - 1; i++) //verifica mai intai primul element cu cele care urmeaza dupa el si, daca e 0, le interschimba, ducand spre capat numerele nule; procedeaza la fel cu al doilea element si restul etc.
                for (int j = i + 1; j < n; j++)
                    if (a[i] > 0)
                    { 
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp; 
                    }
        }
    }
}
