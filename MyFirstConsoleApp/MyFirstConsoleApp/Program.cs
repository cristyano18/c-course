using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyFirstConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			program.firstExercise();
			program.secondExercise();
			program.thirdExercise();
			program.fourthExercise();
			program.fifthExercise(10);
			Console.WriteLine(program.sixthExercise(5, 10, 8));
			Console.WriteLine(program.seventhExercise(12));
			Console.WriteLine(program.eigthExercise(4));
			List<int> list = program.optionalFirst(2);
			foreach (int item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(program.optionalSecond(25, 10000, 8));
			Console.WriteLine(program.optionalThird(10000));
			Console.Read();





		}
		public void firstExercise()
		{
			int a = 3;
			int b = (a = 2) * a;
			int c = b * (b = 5);
			Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);
			//Ce va afisa la executie si de ce?
			//Va afisa a =2, b =5, c =20
			//Pentru ca are loc o concatenare intre string si valoarea celor 3 variable de tip int
		}

		public void secondExercise()
		{
			double d = 2.95;
			int i = 4;
			Console.WriteLine(++d > i ? d : i);

			//Va afisa 4 (i)
			//Pentru ca intai incrementeaza d cu 1, dupa care verifica daca d este mai mare decat i
			//Dupa care afiseaza d in cazul true sau i in cazul false
		}

		public void thirdExercise()
		{
			int a2 = 3;
			if (++a2 < 4)
			{
				if (a2++ < 4)
				{
					Console.WriteLine(a2);
				}
				else
				{
					Console.WriteLine(a2);
				}
			}
			//Nu afiseaza nimic pentru ca valoarea lui a2 este 4, si nu indeplineste conditia de < 4
		}

		public void fourthExercise()
		{
			int suma = 0;
			for (int ix = 1; ix < 10; ix++)
			{
				suma = suma + ix;
			}
			Console.WriteLine("Suma este: " + suma);
			//afiseaza Suma este: 45, pentru ca incepand de la 1 pana la 9 inclusiv, va aduna toate numerele si le va memora in variabila suma
		}

		public void fifthExercise(int n)
		{
			int sum = 1;
			for (int x = 1; x < n; x++)
			{
				sum = sum * x;

			}
			Console.WriteLine(sum);
		}

		public int sixthExercise(int a, int b, int c)
		{
			if (a > b && a > c)
			{
				return a;
			}
			else if (b > a && b > c)
			{
				return b;
			}
			else
			{
				return c;
			}
			
			
		}

		public bool seventhExercise(int n)
		{
			if (n % 2 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public string eigthExercise(int n)
		{
			switch(n)
			{
				case 1: return "Monday";
				case 2: return "Tuesday";
				case 3: return "Wednesday";
				case 4: return "Thursday";
				case 5: return "Friday";
				case 6: return "Saturday";
				case 7: return "Sunday";
				default: return "Day number " + n + " does not exist!";
			}
		}

		public List<int> optionalFirst(int n)
		{

			//Scrieti un program care afiseaza primele 4 numere naturale care sunt egale cu suma divizorilor lor.
			//Exemplu: 28 = 1 + 2 + 4 + 7 + 14 este un numar valid.


			List<int> numbersList = new List<int>();
			int currentNumber = 1;

			while (true)
			{
				int currentSum = 0;
				for (int x = 1; x < currentNumber; x++)
				{
					if (currentNumber % x == 0)
					{
						currentSum = currentSum + x;
					}
				}
				if (currentNumber == currentSum)
				{
					numbersList.Add(currentNumber);
				}

				currentNumber = currentNumber + 1;

				if (numbersList.Count == n)
				{
					return numbersList;
				}
			}
		}

		public decimal optionalSecond(decimal rate, decimal sum, int years)
		{
			//Presupunem ca depunem o suma (depozit la termen) intr-o banca ce ofera o dobanda de 25% pe an. 
			//Sa se calculeze suma finala dupa un anumit numar de ani (se va tine cont de “dobanda la dobanda”).

			for (int year = 1; year <= years; year++)
			{
				sum = sum + (sum * rate / 100);
			}

			return sum;

		}

		public string optionalThird(int seconds)
		{
			//Scrieti un program care primeste la intrare(declarati voi ca variabila) un numar de secunde si afiseaza maximul de ore
			//minute, secunde care este echivant ca timp cu numarul initial de secunde.
			//De exemplu: 7384 secunde este echivalent cu 2 ore 3 minute si 4 secunde.

			Dictionary<string, int> timeDefinition = new Dictionary<string, int>
				{
					{"hours", 3600 },
					{"minutes", 60 },
					{"seconds", 1 }
				};
			
			StringBuilder response = new StringBuilder();

			while (seconds != 0)
			{
				for (int index = 0; index < timeDefinition.Count; index++)
				{
					int numberOfMeasures = 0;
					while (seconds >= timeDefinition.ElementAt(index).Value)
					{
						numberOfMeasures++;

						seconds = seconds - timeDefinition.ElementAt(index).Value;
						
					}
					response.Append(string.Format("{0} {1} ", timeDefinition.ElementAt(index).Key, numberOfMeasures));
				}
			}
			return response.ToString();

		}
	}
}
