using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Класс для создания точки
    /// </summary>
    class Point
    {        
        // координата по Оси X
        public int x;

        // Координата по Оси Y
        public int y;
        
        // Символ выводимый в консоль
        public char sym;

        /// <summary>
        /// Конструктор класса - Пустой
        /// </summary>
        public Point()
        {
        }
        /// <summary>
        /// Конструктор класса принимающий в качестве аргумента точку
        /// </summary>
        /// <param name="p"></param>
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        /// <summary>
        /// Конструктор класса - создание точки
        /// </summary>
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        /// <summary>
        /// Вывод токи в консоль
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        /// <summary>
        /// Метод пересечения двух точек
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        /// <summary>
        /// Создание фигуры змейки, логика смещения
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="direction"></param>
        public void Move(int offset, Direction direction)
        {
            if (direction==Direction.Right)
            {
                x = x + offset;
            }
            else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Up)
            {
                y = y - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }
        }

        /// <summary>
        /// Метод позволяющий очищать поле от несуществующей части змейки
        /// </summary>
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
