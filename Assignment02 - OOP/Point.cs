using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment02___OOP
{
    internal struct Point
    {
        #region Attribute

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }




        #endregion

        #region Default Constructor

        public Point()
        {
            x = 7;
            y = 21;
        }



        #endregion

        #region Parameterized Constructor

        public Point(int X)
        {
            this.x = X = y;
            
        }

        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;


        }

        #endregion

        #region Method


        public string GetDifference (int X, int Y)    
        {

            return $"Difference between X and Y = {x - y}";

        }


        #endregion

    }
}
