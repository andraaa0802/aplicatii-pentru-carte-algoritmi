using System;

namespace P6
{
    class Program
    {
        /// <summary>
        /// Subprogramul aranjare are doi parametri: a prin care primeşte un tablou unidimensional  
        /// cu maximum 100 de numere reale nenule şi n, numărul de elemente din tablou.
        /// Subprogramul rearanjează elementele tabloului unidimensional astfel încât toate 
        /// valorile negative să se afle pe primele poziţii, iar valorile pozitive în continuarea celor negative.
        /// Ordinea în cadrul secvenţei de elemente pozitive, respectiv în cadrul secvenţei de elemente negative, poate fi oricare.
        /// Tabloul modificat va fi furnizat tot prin intermediul parametrului a. 
        /// Exemplu: dacă tabloul are 6 elemente şi este de forma  (12, -7.5, 6.5, -3, -8, 7.5), după apel,
        /// acesta ar putea fi: (-7.5, -3, -8, 12, 6.5, 7.5).  Scrieţi definiţia completă a subprogramului aranjare
        /// </summary>
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
            aranjare(ref a, n);
            for (int i=0;i<n;i++)
                Console.Write(a[i]+" ");
        }

        private static void aranjare(ref double[] a, int n)
        {
            int elPozitive = 0, elNegative = 0; //in cele 2 variabile se numara nr pozitive, respectiv negative si vor fi folosite ca si indecsi pt cei 2 vectori de mai jos
            double[] vPozitiv = new double[n], vNegativ = new double[n]; //in cei 2 vectori se vor pune nr pozitive, respectiv negative
            for(int i=0;i<n;i++)
            {
                if (a[i] < 0) //daca el de pe pozitia i este negativ il memoreaza in vectorul destinat valorilor negative
                {
                    vNegativ[elNegative] = a[i];
                    elNegative++;
                }
                    
                else //daca el de pe pozitia i este pozitiv sau 0 il memoreaza in vectorul destinat valorilor pozitive
                {
                    vPozitiv[elPozitive] = a[i];
                    elPozitive++;
                }
                    
            }

            //schimba elementele din a cu elementele din vectorul de valori negative, urmate de elementele din vectorul de valori pozitive
            for (int i = 0; i < elNegative; i++) 
                a[i] = vNegativ[i];
            for (int i = elNegative; i < n; i++)
                a[i] = vPozitiv[i - elNegative];
        }
    }
}
