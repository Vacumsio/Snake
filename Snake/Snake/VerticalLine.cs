using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        /// <summary>
        /// Строим вертикальную линию
        /// </summary>
        /// <param name="yUp">Координата верхней точки</param>
        /// <param name="yDown">Координата нижней точки</param>
        /// <param name="x">Строка расположения вертикальной линии</param>
        /// <param name="sym">Символ используемый для построения линии</param>
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
