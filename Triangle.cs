using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace OOPLab7
{
    public class Triangle
    {
        public Point FirstPoint { get; set; } = null;
        public Point SecondPoint { get; set; } = null;
        public Point ThirdPoint { get; set; } = null;

        private double _ABLength = 0.0;
        private double _BCLength = 0.0;
        private double _ACLength = 0.0;

        public Triangle()
        {
            FirstPoint = null;
            SecondPoint = null;
            ThirdPoint = null;
        }

        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
        }

        public void SetPoint()
        {
            if (FirstPoint != null && SecondPoint != null && ThirdPoint != null)
            {
                Console.WriteLine("Все точки уже введены!");
                Thread.Sleep(1000);
                return;
            }

            Console.WriteLine("Введите точку.");
            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (FirstPoint == null)
            {
                FirstPoint = new Point(x, y);
                return;
            }
            if (SecondPoint == null)
            {
                SecondPoint = new Point(x, y);
                return;
            }
            if (ThirdPoint == null)
            {
                ThirdPoint = new Point(x, y);
                return;
            }

            Console.WriteLine("Точка успешно введена!");
            Console.Clear();
        }

        public void ClearPoints()
        {
            FirstPoint = null;
            SecondPoint = null;
            ThirdPoint = null;

            Console.WriteLine("Точки успешно очищены!");
            Console.Clear();
        }

        public void CheckTriangle()
        {
            if (FirstPoint == null || SecondPoint == null || ThirdPoint == null)
            {
                Console.WriteLine("Не все точки введены!");
                Thread.Sleep(1000);
                return;
            }

            _ABLength = FirstPoint.Distance(SecondPoint);
            _BCLength = SecondPoint.Distance(ThirdPoint);
            _ACLength = ThirdPoint.Distance(FirstPoint);

            if ((_ABLength + _BCLength) < _ACLength && (_BCLength + _ACLength) < _ABLength && (_ACLength + _ABLength) < _BCLength)
            {
                Console.WriteLine("Треугольник не существует!");
                Thread.Sleep(1000);
                return;
            }

            if (_ABLength == _BCLength && _BCLength == _ACLength)
            {
                Console.WriteLine("Треугольник равносторонний.");
                Thread.Sleep(1000);
                return;
            }

            if (_ABLength == _BCLength || _BCLength == _ACLength || _ACLength == _ABLength)
            {
                if ((Math.Round(Math.Pow(_ABLength, 2)) + Math.Round(Math.Pow(_BCLength, 2)) == Math.Round(Math.Pow(_ACLength, 2))) ||
                    (Math.Round(Math.Pow(_ABLength, 2)) + Math.Round(Math.Pow(_ACLength, 2)) == Math.Round(Math.Pow(_BCLength, 2))) ||
                    (Math.Round(Math.Pow(_ACLength, 2)) + Math.Round(Math.Pow(_BCLength, 2)) == Math.Round(Math.Pow(_ABLength, 2))))
                {
                    Console.WriteLine("Треугольник прямоугольный.");
                    Thread.Sleep(1000);
                    return;
                }

                Console.WriteLine("Треугольник равнобедренный.");
                Thread.Sleep(1000);
                return;
            }

            if ((Math.Round(Math.Pow(_ABLength, 2)) + Math.Round(Math.Pow(_BCLength, 2)) == Math.Round(Math.Pow(_ACLength, 2))) ||
                (Math.Round(Math.Pow(_ABLength, 2)) + Math.Round(Math.Pow(_ACLength, 2)) == Math.Round(Math.Pow(_BCLength, 2))) ||
                (Math.Round(Math.Pow(_ACLength, 2)) + Math.Round(Math.Pow(_BCLength, 2)) == Math.Round(Math.Pow(_ABLength, 2))))
            {
                Console.WriteLine("Треугольник прямоугольный.");
                Thread.Sleep(1000);
                return;
            }

            Console.WriteLine("Треугольник разносторонний.");
            Thread.Sleep(1000);
        }
    }
}
