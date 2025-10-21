using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment02___OOP
{
    internal class Rectangle
    {

        #region Attribute

        private double width;

		public double Width
		{
			get { 
				
				return width ;
			
			}
            set
            {
                if (value < 0) Console.WriteLine("Error: Width cannot be negative!");

                else width = value;
            } 
        }

		private double height;

		public double Height
        {
            get
            {

                return height;
            }
            set
            {
                if (value < 0) Console.WriteLine("Error: Height cannot be negative!");

                else height = value;

            }
        }


        #endregion

        #region Default Constructor

        public Rectangle()
        {
            width = 7;
			height = 21;
        }


        #endregion

        #region Parameterized Constructor

        public Rectangle(double Height)
        {
            this.height = Height;
            this.width = 7;  
        }

        public Rectangle(double Width, double Height)
        {
            this.width = Width;
            this.height = Height;
        }


        #endregion

        #region Method

        public string GetArea()
        {

            return $"Area \t= {width} * {height} = {height * width}";

        }

        public string DisplayInfo() {

            return $"Width \t= {width}\nHeihgt \t= {height}\nArea \t= {width * height}";

        }


        #endregion

    }
}
