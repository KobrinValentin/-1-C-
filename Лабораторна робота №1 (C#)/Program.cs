using System;
using System.Text;

namespace Лабораторна_робота__1__C__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstSide, secondSide;
            int angleDegree;

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть вхідні дані");

            Console.Write($"перша сторона (см) -> ");
            firstSide = Convert.ToSingle (Console.ReadLine());
            Console.Write($"друга сторона (см) -> ");
            secondSide = Convert.ToSingle (Console.ReadLine());
            Console.Write($"градусна міра кута (градуси) -> ");
            angleDegree = Convert.ToInt32 (Console.ReadLine());

            AreaCalculation(firstSide, secondSide, angleDegree);

            void AreaCalculation (float FirstSide, float SecondSide, int AngleDegree ) 
            {
                float result;

                Console.WriteLine("\nОбчислення площі паралелограма:");

                switch (AngleDegree)
                {
                    case 0:
                    case 180:
                    case 360:
                        result = FirstSide * SecondSide * 0;
                        Console.WriteLine ($"площа паралелограма {result} (кв.см)"); 
                        break;
                    case 120:
                    case 60:
                        result = (FirstSide * SecondSide) * (float)(Math.Sqrt(3) / 2);
                        Console.WriteLine($"площа паралелограма {result} (кв.см)");
                        break;
                    case 45:
                        result = (FirstSide * SecondSide) * (float)(Math.Sqrt(2) / 2);
                        Console.WriteLine($"площа паралелограма {result} (кв.см)");
                        break;
                    case 30:
                        result = (FirstSide * SecondSide) * 0.5f;
                        Console.WriteLine($"площа паралелограма {result} (кв.см)");
                        break;
                    case 90:
                        result = FirstSide * SecondSide * 1;
                        Console.WriteLine($"площа паралелограма {result} (кв.см)");
                        break;
                    case 270:
                        result = FirstSide * SecondSide * Math.Abs(-1);
                        Console.WriteLine($"площа паралелограма {result} (кв.см)"); ;
                        break;
                    default:
                        Console.WriteLine("кут може приймати тільки такі значення: 0, 30, 45, 60, 90, 120, 180, 270, 360 (градуси)");
                        break;
                }
            }
    }
    }
}
