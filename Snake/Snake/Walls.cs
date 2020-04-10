using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallsList;

        public Walls(int mapwidth, int mapheight)
        {
            wallsList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapwidth-2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapwidth-2, mapheight-2, '+');
            VerticalLine leftLine = new VerticalLine(0, mapheight-2, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapheight-2, mapwidth-2, '+');

            wallsList.Add(upLine);
            wallsList.Add(downLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
        }

        public void CreateFigure()
        {
            foreach (var wall in wallsList)
            {
                wall.CreateFigure();
            }
        }

        /// <summary>
        /// Метод пересечения двух точек
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal bool IsHit(Figure figure)
        {
            foreach (var walls in wallsList)
            {
                if (walls.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
