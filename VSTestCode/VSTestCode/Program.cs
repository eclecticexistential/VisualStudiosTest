using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTestCode
{
    class Game
    {
        public static void Main()
        {
            Tower tower = new Tower();
            Map map = new Map(8, 5);
            MapLocation x = new MapLocation(4, 2);
            Point p = x;
            map.OnMap(new MapLocation(0, 0));
            Console.WriteLine(x.DistanceTo(5, 5));
            Console.WriteLine(x is MapLocation);
            Console.WriteLine(x is Point);
            Point point = new Point(0, 0);
            Console.WriteLine(point is MapLocation);
        }
    }
}
