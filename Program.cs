using System;

namespace OOPLab7
{
    class Program
    {
        public static Triangle Triangle { get; set; } = null;

        static void Main(string[] args)
        {
            Triangle = new Triangle();

            while(true)
            {
                switch (Menu())
                {
                    case 1:
                        Console.Clear();
                        Triangle.SetPoint();
                        break;
                    case 2:
                        Console.Clear();
                        Triangle.ClearPoints();
                        break;
                    case 3:
                        Console.Clear();
                        Triangle.CheckTriangle();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        

        static int Menu()
        {
            int choice = 0;

            Console.Clear();
            Console.WriteLine("Меню: ");
            Console.WriteLine("1 - Ввести точку.");
            Console.WriteLine("2 - Очистить точки.");
            Console.WriteLine("3 - Проверить треугольник.");
            Console.WriteLine("4 - Выйти.");
            Console.Write("Ваш выбор: ");
            choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
    }
}
