using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Класс создания горизонтальных линий
    /// </summary>
    class HorizontalLine : Figure
    {
        /// <summary>
        /// Строим горизонтальную линию
        /// </summary>
        /// <param name="xLeft">Координата левой точки</param>
        /// <param name="xRight">Координата правой точки</param>
        /// <param name="y">Строка расположения горизонтальной линии</param>
        /// <param name="sym">Символ используемый для построения линии</param>
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
