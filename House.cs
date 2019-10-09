using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stroiteli
{
    public class House
    { 
        Basement Basement { get; set; }
        List<Walls> Walls { get; set; }
        List<Door> Doors { get; set; }
        List<Window> Windows { get; set; }
        Roof Roof { get; set; }
        public House()
        {
            Basement = new Basement(1, 1, 1);
            Roof = new Roof(1, 1, 1);
            Walls = new List<Walls>()
            {
                new Walls(1,1,1),
                new Walls(1,1,1),
                new Walls(1,1,1),
                new Walls(1,1,1),
            };
            Doors = new List<Door>() {
                new Door(1,1,1)
            };
            Windows = new List<Window>() {
                new Window(1,1,1),
                new Window(1,1,1),
                new Window(1,1,1),
                new Window(1,1,1),
            };
        }
    }
}
