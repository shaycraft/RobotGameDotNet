using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public class Board
    {
        public int size { get; set; }

        public bool IsRobotPresent(Point p)
        {
            return _robots.Any(r => r.location.x == p.x && r.location.y == p.y);
        }

        private Point[,] _grid;

        private List<Robot> _robots;
        private List<Player> _players;

        // number of turns passed
        private int turn = 0;

        public Board(int size)
        {
            this.size = size;
            _grid = new Point[size, size];
            _robots = new List<Robot>();
            _players = new List<Player>();
        }
    }
}
