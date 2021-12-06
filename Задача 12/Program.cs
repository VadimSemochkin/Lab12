using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
	class Program
	{
		static void Main(string[] args)
		{


			Console.Write("Введите радиус окружности: ");
			double Radius = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите координату Х точки: ");
			double positionX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
			Console.Write("Введите координату Y точки: ");
			double positionY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
			Circle.CircleLengh(Radius);
			Circle.CircleSquare(Radius);
			Circle.Belong(Radius, positionX, positionY);
			Console.ReadKey();
		}

		static class Circle
		{
			public  static void CircleLengh(double Radius)
			{
				double circleLengh = Math.PI * 2 * Radius;
				Console.WriteLine("Длина окружности равна {0:F2}", circleLengh);
			}
			public static void CircleSquare(double Radius)
			{
				double circleSquare = Math.PI * Math.Pow(Radius, 2);
				Console.WriteLine("Площадь круга равна {0:F2}", circleSquare);
			}
			public static void Belong(double Radius, double positionX, double positionY)
			{
				if (positionX <= Radius && positionY <= Radius)
				{
					Console.WriteLine("Точка с координатами ({0},{1}) принадлежит окружности с радиусом {2}", positionX, positionY, Radius);
				}
				else
				{
					Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит окружности с радиусом {2}", positionX, positionY, Radius);
				}
			}
		}
	}
}
