using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Класс создания еды на игровом поле
    /// </summary>
    class FoodCreator
    {
        //ширина игрового поля
        int mapWidth;

        //высота игрового поля
        int mapHeight;

        //символ еды
        char sym;

        Random random = new Random();

        /// <summary>
        /// Метод получения данных о размере игрового поля
        /// </summary>
        /// <param name="mapWidth"></param>
        /// <param name="mapHeight"></param>
        /// <param name="sym"></param>
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        /// <summary>
        /// Метод создания еды на игровом поле
        /// </summary>
        /// <returns></returns>
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
