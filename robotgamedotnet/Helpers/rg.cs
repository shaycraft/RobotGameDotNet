using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public static class rg
    {
        public static double distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(p1.x - p1.x), 2) + Math.Pow(Math.Abs(p1.y - p2.y), 2));
        }

        public static int wdist(Point p1, Point p2)
        {
            return Math.Abs(p1.x - p2.x) + Math.Abs(p1.y - p2.y);
        }

        public static Point CENTER_POINT(Board board)
        {
            return new Point { x = board.size / 2, y = board.size / 2 };
        }

        public static Point toward(Point start, Point end)
        {
            Point p = new Point();
            // straight line in x?
            if (start.x == end.x)
            {
                p.x = start.x;
                p.y = start.y + (end.y > start.y ? 1 : -1);
            }
            // else just go in y direction
            else
            {
                p.y = start.y;
                p.x = start.x + (end.x > start.x ? 1 : -1);
            }

            return p;
        }
    }
}
