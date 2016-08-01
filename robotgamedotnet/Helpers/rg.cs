using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public static class rg
    {
        private static double distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(p1.x - p1.x), 2) + Math.Pow(Math.Abs(p1.y - p2.y), 2));
        }

        private static int wdist(Point p1, Point p2)
        {
            return Math.Abs(p1.x - p2.x) + Math.Abs(p1.y - p2.y);
        }

        private static Point CENTER_POINT(Board board)
        {
            return new Point { x = board.size / 2, y = board.size / 2 };
        }
    }
}
