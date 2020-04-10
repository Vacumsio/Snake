using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        /// <summary>
        /// Конструктор класса змейка
        /// </summary>
        /// <param name="tail"></param>
        /// <param name="length"></param>
        /// <param name="_direction"></param>
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        /// <summary>
        /// Метод описываищй движение змейки
        /// </summary>
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        /// <summary>
        /// Метод описывающий направления движения змейки
        /// </summary>
        /// <returns></returns>
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count-2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод описывающий клавиши отвечающие за управление змейкой
        /// </summary>
        /// <param name="key"></param>
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }

        /// <summary>
        /// Метод описыващий процесс поглощения еды змейкой
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
