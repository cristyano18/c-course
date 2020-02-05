using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {

            first(10, 20, 30);

            second();
            char[] test = third("Visual Studio 2040");
            foreach (char n in test)
                Console.WriteLine(n);

            Console.WriteLine(fourth("I do drugs"));

            fifth(new Random().Next(0,500));

            optional("mara este bine");
        }

        public static void first(double a, double b, double c)
        {
            // Scrieti un program care stocheaza intr-un vector 3 variabile de tip double declarate de voi si le afiseaza parcurgand vectorul.
            double[] doubleArray = { a, b, c };

            for (int index = 0; index < doubleArray.Length; index++)
            {
                Console.WriteLine(doubleArray[index]);
            }
        }

        public static void second()
        {
            // Scrieti o clasa ce declara un array de tip int cu o singura valoare negativa si restul pozitive.Afisati pozitia valorii negative din array.
            int[] intArray = { 3, 8, 12, -50, 100, 500 };
            for (int index = 0; index < intArray.Length; index++)
            {
                if (intArray[index] < 0)
                {
                    Console.WriteLine("Negative number at index: " + index);
                }
            }

        }

        public static char[] third(string transform)
        {
            // Scrieti o clasa ce transforma un String intr-un array de caractere.
            char[] charArray = transform.ToCharArray();
            return charArray;
        }

        public static string fourth(string toUpperCase)
        {
            // Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase.
            char[] charArray = toUpperCase.ToCharArray();

            for (int index = 0; index < charArray.Length; index++)
            {
                if (index % 2 == 0)
                {
                    charArray[index] = Char.ToUpper(charArray[index]);
                }
                
            }
            return new String(charArray);

        }

        public static void fifth(double n)
        {
            // Avand un vector de numere intregi, adunati un nr double la valorile stocate si pastrati rezultatul in alt vector corespunzator.
            Random rand = new Random();
            int[] defaultArray = { rand.Next(0, 500), rand.Next(0, 500), rand.Next(0, 500), rand.Next(0, 500) };

            Console.Write("Printing current Array numbers: ");
            for (int x = 0; x < defaultArray.Length; x++)
            {
                Console.Write(defaultArray[x] + " ");
            }

            Console.WriteLine("Adding " + n + " to each number...");
            for (int i = 0; i < defaultArray.Length; i++)
            {
                defaultArray[i] = defaultArray[i] + (int)n;
            }

            Console.Write("Printing Array numbers after addition: ");
            for (int x = 0; x < defaultArray.Length; x++)
            {
                Console.Write(defaultArray[x] + " ");
            }

        }

        public static void optional(string s)
        { 
            string[] strArray = s.Split(' ');
            int sumLength = 0;
            bool isEvenLength = true;

            for (int index = 0; index < strArray.Length; index++)
            {
                sumLength = sumLength + strArray[index].Length;
                if (sumLength / (index + 1) != strArray[index].Length)
                {
                    isEvenLength = false;
                }
            }

            if (isEvenLength)
            {
                char[,] bidimensional = new char[sumLength / strArray.Length, sumLength / strArray.Length];
                for (int index = 0; index < strArray.Length; index++)
                {
                    for (int z = 0; z < strArray[index].Length; z++)
                    {
                        bidimensional[index, z] = strArray[index].ElementAt(z);

                    }
                }

                for (int q = 0; q < bidimensional.GetLength(0); q++)
                {
                    Console.WriteLine("");
                    for (int w = 0; w < bidimensional.GetLength(1); w++)
                    {
                        Console.Write(bidimensional[q, w]);
                    }
                }
            }


            

        }
    }
}
