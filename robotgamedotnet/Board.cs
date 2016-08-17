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

        public Board()
        {
            _robots = new List<Robot>();
            _players = new List<Player>();
        }

        private Point[,] _grid;

        public List<Robot> _robots { get; set; }
        public List<Player> _players { get; set; }

        // number of turns passed
        private int turn = 0;

        public Board(int size)
        {
            this.size = size;
            _grid = new Point[size, size];
            _robots = new List<Robot>();
            _players = new List<Player>();
        }

        public void AddRobotToBoard(Robot robot)
        {
            Point p = new Point();
            p.x = (new Random()).Next(size);
            p.y = (new Random()).Next(size);
            while (_robots.Where(r => r.location == p).Any())
            {
                p.x = (new Random()).Next(size);
                p.y = (new Random()).Next(size);
            }
            robot.location = p;
            _robots.Add(robot);
            robot.board = this;
        }
    }
}
