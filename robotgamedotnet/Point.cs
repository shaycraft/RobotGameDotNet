using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Point))
            {
                return false;
            }

            Point p = (Point)obj;
            return p.x == x && p.y == y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
