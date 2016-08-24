using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public class PointComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point p1, Point p2)
        {
            return (p1.x == p2.x && p1.y == p2.y);
        }

        public int GetHashCode(Point obj)
        {
            //return obj.x ^ obj.y;
            return string.Format("{0},{1}", obj.x, obj.y).GetHashCode();
        }
    }

    public class Point
    {
        public Point() { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }

        public static bool operator ==(Point p1, Point p2)
        {
            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            {
                return false;
            }
            return p1.x == p2.x & p1.y == p2.y;
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
