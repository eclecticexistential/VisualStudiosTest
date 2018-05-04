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
            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ProgramExceptions)
            {
                Console.WriteLine("unhandled program exception here.");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}
