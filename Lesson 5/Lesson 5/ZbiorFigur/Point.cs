using System;


namespace ZbiorFigur
{
    public class Point 
    {
        public int x;
        public int y;
        protected string name;

        protected Point[] square = new Point[4];
        protected Point[] circle = new Point[2];


        public Point()
        {

        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        


    }
}
