using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace createTable
{
    class algo
    {
        public void chkWayToGo()
        {
            //int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        }
        public static double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(((a.X - b.X) * (a.X - b.X)) + ((a.Y - b.Y) * (a.Y - b.Y)));
        }
        public void createArrayStatus()
        {
            List<Point> position = new List<Point>();
            int[,] status = new int[8, 4];

            position.Add(new Point(0, 0));
            position.Add(new Point(114, 0));
            position.Add(new Point(228, 0));
            position.Add(new Point(342, 0));

            position.Add(new Point(57, 57));
            position.Add(new Point(171, 57));
            position.Add(new Point(285, 57));
            position.Add(new Point(456, 57));

            position.Add(new Point(0, 114));
            position.Add(new Point(114, 114));
            position.Add(new Point(228, 114));
            position.Add(new Point(342, 114));

            position.Add(new Point(57, 171));
            position.Add(new Point(171, 171));
            position.Add(new Point(285, 171));
            position.Add(new Point(456, 171));

            position.Add(new Point(0, 228));
            position.Add(new Point(114, 228));
            position.Add(new Point(228, 228));
            position.Add(new Point(342, 228));

            position.Add(new Point(57, 285));
            position.Add(new Point(171, 285));
            position.Add(new Point(285, 285));
            position.Add(new Point(456, 285));

            position.Add(new Point(0, 342));
            position.Add(new Point(114, 342));
            position.Add(new Point(228, 342));
            position.Add(new Point(342, 342));

            position.Add(new Point(57, 456));
            position.Add(new Point(171, 456));
            position.Add(new Point(285, 456));
            position.Add(new Point(456, 456));
        }
    }
}
