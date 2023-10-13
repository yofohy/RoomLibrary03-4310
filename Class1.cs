using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary03ПРд4310
{
    public class Room
    {
        double roomLenght; // длина комнаты
        double roomWidth; // ширина комнаты

        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns> Возвращает значение периметра </returns>
        public double RoomPerimetr()
        {
            return 2 * (roomLenght + roomWidth);
        }

        /// <summary>
        /// Метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>Возврщает значенние площади</returns>
        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }

        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// на одного человека
        /// </summary>
        /// <param name="пр"> Число человек </param>
        /// <returns> Возвращает число квадратных метров </returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }

        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public string info()
        {
            return " Комната площадью " + RoomArea() + " кв.м. ";
        }

        /// <summary>
        /// Жилая комната
        /// </summary>
        public class LivingRoom:Room
        {
            int numWin; //число окон
            public int NumWin
            { get { return numWin; } 
                set { numWin = value; }
            
            }
            public string info()
            {
                return " Жилая комната площадью " + RoomArea() + " кв.м, с " + numWin + " окнами ";
            }
        }

        public class Office:Room
        {
            int numSockets;// число розеток
            public int NumSockets
            {
                get { return numSockets; }
                set { numSockets = value; }
            }
            /// <summary>
            /// Возможное число рабочих
            /// мест, на одного работника 4,5 кв.м.мест, на одного работника 4,5
            /// </summary> 
            /// <returns></returns>
            public int NumWorkPlaces()
            { int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
                return Math.Min(numSockets, num);


            }

            /// <summary>
            /// Информация об офисе
            /// </summary>
            /// <returns></returns>
            public string info()
            { return " Офис на " + NumWorkPlaces() + " рабочих мест"; }
        }
    }
}
