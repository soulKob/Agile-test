using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace createTable
{
    class algo
    {
        public static Point createPointList(Point positionInClick)
        {
            //List of point in center
            List<Point> centerPosition = new List<Point>();
            int[] pointCenterNumber = { 28, 85, 142, 199, 256, 313, 370, 427 };

            //List of point in Top-Left
            List<Point> topLeftPosition = new List<Point>();
            int[] pointTopLeftNumber = { 0, 57, 114, 171, 228, 285, 342, 399 };

            int pointX;
            int pointY;

            //Create point int center
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pointX = pointCenterNumber[j];
                    pointY = pointCenterNumber[i];
                    Point p = new Point(pointX, pointY);
                    centerPosition.Add(p);
                }
            }
            //Create point in Top-Left
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pointX = pointTopLeftNumber[j];
                    pointY = pointTopLeftNumber[i];
                    Point p = new Point(pointX, pointY);
                    topLeftPosition.Add(p);
                }
            }
            int shortPosition = algo.GetDistance(centerPosition, new Point(positionInClick.X, positionInClick.Y));
            //Console.WriteLine(topLeftPosition[shortPosition].X + " , " + topLeftPosition[shortPosition].Y);

            return topLeftPosition[shortPosition];
        }

        public static int GetDistance(List<Point> centerPosition, Point currPositon)
        {
            //int shortPosition = 0;
            List<double> distanceList = new List<double>();
            for (int i = 0; i < centerPosition.Count; i++)
            {
                double distance = Math.Sqrt(((currPositon.X - centerPosition[i].X) * (currPositon.X - centerPosition[i].X)) + ((currPositon.Y - centerPosition[i].Y) * (currPositon.Y - centerPosition[i].Y)));
                distanceList.Add(distance);
                //if (distance <= 57)
                //{
                //    shortPosition = i;
                //}
            }
            double minvalue = distanceList.Min();

            int minIndex = distanceList.IndexOf(minvalue);

            //Console.WriteLine("min value "+ minvalue+"  minIndex"+minIndex);
            return minIndex;
        }

    }
}
