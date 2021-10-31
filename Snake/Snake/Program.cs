using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Основной класс программы. Точка входа в программу
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //константы ширины и высота игрового поля
            const int widthWindow = 120;
            const int heightWindow = 30;

            //Задается размер рамки, чтобы не было скролинга
            Console.SetBufferSize(widthWindow, heightWindow);

            #region Отрисовываем стены

            Walls walls = new Walls(widthWindow, heightWindow);
            walls.CreateFigure();
            #endregion

            //Начальная точка змейки
            Point p = new Point(4, 5, '#');

            //Создание змейки
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.CreateFigure();

            //Создание еды
            FoodCreator foodCreator = new FoodCreator(widthWindow, heightWindow,'%');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Console.CursorVisible = false;

            //игровой процесс
            while (true)
            {
                if  ( walls.IsHit(snake) || snake.IsHitTail() )
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    snake.CreateFigure();
                }
                else
                    snake.Move();

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
