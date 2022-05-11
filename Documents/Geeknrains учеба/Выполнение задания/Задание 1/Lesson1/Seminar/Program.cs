using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{ 
	//Выполнил: Васильев
	internal class Questionnaire
	{
		static string inputName;
		static string inputSurname;
		static string inputYourHeight;
		static string inputYourWeight;

		static float indexTask2;
		static int x;
		static float y;
		static void Main(string[] args)
		{
			/*Задание 1
			1.Написать программу «Анкета».
			Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
			В результате вся информация выводится в одну строчку:

			а) используя склеивание;
			б) используя форматированный вывод;
			в) используя вывод со знаком $.
			*/
			Task1();

			/*Задание 2
			2.Ввести вес и рост человека. 
		    Рассчитать и вывести индекс массы тела(ИМТ)
			по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
			*/
			indexTask2 = Task2(x, y);
			Console.Clear();
			Console.WriteLine($"Индекс: {indexTask2}");
			Console.ReadLine();
			/*Задание 3
			 а) Написать программу, которая подсчитывает
			расстояние между точками с координатами
			x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
			Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
             б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
			*/
			double x1;
			double y1 = 4;
			double x2 = 6;
			double y2 = 8;
			double r;
			//Задание 3.а
			Console.Clear();
			Console.Write("x1: ");
			x1 = double.Parse(Console.ReadLine());
			Console.Write("y1: ");
			y1 = double.Parse(Console.ReadLine());
			Console.Write("x2: ");
			x2 = double.Parse(Console.ReadLine());
			Console.Write("y2: ");
			y2 = double.Parse(Console.ReadLine());
			r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			Console.Clear();

			Console.WriteLine($"{r:F}");
			Console.ReadLine();
			Console.Clear();
			//Задание 3.б
			r = Task3(x1, y2, x2, y2);

			Console.Clear();
			Console.WriteLine($"{r:F}");
			Console.ReadLine();

			Console.Clear();
			Number();
			Console.ReadLine();
		}

		//Задание 1
		static void Task1()
		{
			Console.Write("Введите имя: ");
			inputName = Console.ReadLine();

			Console.Write("Введите фамилию: ");
			inputSurname = Console.ReadLine();

			Console.Write("Введите рост: ");
			inputYourHeight = Console.ReadLine();

			Console.Write("Введите вес: ");
			inputYourWeight = Console.ReadLine();

			Console.Clear();
			Console.WriteLine(("Имя: ") + inputName + (", ") + ("Фамилия: ") + inputSurname + (", ") + ("Рост: ") + inputYourHeight + (", ") + ("Вес: ") + inputYourWeight);
			Console.WriteLine("Имя: {0}, Фамилия: {1}, Рост: {2}, Вес: {3}", inputName, inputSurname, inputYourHeight, inputYourWeight);
			Console.WriteLine($"Имя: {inputName}, Фамилия: {inputSurname}, Рост: {inputYourHeight}, Вес: {inputYourWeight}");
			Console.ReadLine();
			Console.Clear();
		}
		//Задание 2
		static float Task2(float aW, float bH)
		{
			Console.Write("Введите рост(м): ");
			bH = float.Parse(Console.ReadLine());
			Console.Write("Введите вес(кг): ");
			aW = float.Parse(Console.ReadLine());
			float index;
			index = aW / (bH * bH);
			return index;
		}

		//Задание 3.б
		static double Task3(double x1, double y1, double x2, double y2)
        {
			double res;
			Console.Write("x1: ");
			x1 = double.Parse(Console.ReadLine());
			Console.Write("y1: ");
			y1 = double.Parse(Console.ReadLine());
			Console.Write("x2: ");
			x2 = double.Parse(Console.ReadLine());
			Console.Write("y2: ");
			y2 = double.Parse(Console.ReadLine());
			res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			return res;
		}
		/* Задание 4
		 4. Написать программу обмена значениями двух переменных
		    типа int без использования вспомогательных методов.
		 а) с использованием третьей переменной;
         б) *без использования третьей переменной.
		*/
		static void Number() 
		{
			//4.a
			int a = 3;
			int b = 6;
			int c;
			c = a;
			a = b;
			b = c;

            Console.WriteLine($"a = {a}, b = {b}");

			//4.b
			a = a + b;
			b = a - b;
			a -= b;

			Console.WriteLine($"a = {a}, b = {b}");
		}
	}
} 