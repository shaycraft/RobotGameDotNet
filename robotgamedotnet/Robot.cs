using robotgamedotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public abstract class Robot
    {
        public Guid id { get; private set; }
        public Point location { get; set; }
        public int hp { get; set; }
        public Player player { get; set; }
        public Board board { get; set; }

        public abstract Action act();

        // Constructor
        public Robot()
        {
            id = Guid.NewGuid();
            hp = Settings.robot_hp;
        }
    }
}
