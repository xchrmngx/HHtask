using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // не совсем понял значения "Напишите на C# библиотеку", нужно было написать код наследованием? 
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите, площадь какой фигуры нужно посчитать");
            Console.WriteLine("1 - Круг");
            Console.WriteLine("2 - Треугольник");
            string vibor = Console.ReadLine();
            if (vibor == "Круг" || vibor == "круг" || vibor == "1") // капча ввода для выбора
            {
                Console.WriteLine("Выбран круг. Укажите радиус круга");
                int rkrug = Convert.ToInt32(Console.ReadLine()); // выбор какой будет радиус у круга
                double Skrug = (rkrug * 2) * 3.14; // подсчет площади круга
                Console.WriteLine($"Площадь круга: {Skrug}");
            }
            else if (vibor == "Треугольник" || vibor == "треугольник" || vibor == "2") // капча ввода для выбора
            {
                Console.WriteLine("Выбран треугольник, укажите длину всех сторон и высоту");
                Console.WriteLine("Укажите длину стороны A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите длину стороны B");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите длину стороны С");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите высоту H");
                int h = Convert.ToInt32(Console.ReadLine());
                if (a > b || a > c || b > a || b > c || c > a || c > b) // проверка неравнобедренности треугольника
                {
                    Console.WriteLine("Треугольник неравнобедренный");
                }
                else if (a == b || a == c || b == a || b == c || c == a || c == b) // проверка равнобедренности треугольника
                {
                    Console.WriteLine("Треугольник равнобедренный");
                }
                double sTriangle = (a * h) / 2; // подсчет площади треугольника
                Console.WriteLine($"Площадь треугольника: {sTriangle}");
            }    
            Console.ReadKey();
            
        }
    }
}
