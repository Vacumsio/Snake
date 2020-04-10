using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Родительский класс создания фигур
    /// </summary>
    class Figure
    {
        protected List<Point> pList;

        /// <summary>
        /// Отрисовка линии
        /// </summary>
        public void CreateFigure()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
