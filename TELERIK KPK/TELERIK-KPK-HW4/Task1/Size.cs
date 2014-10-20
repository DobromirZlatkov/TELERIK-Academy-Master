namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Size
    {
        private double width;
        private double height;

        public Size(double inputWidth, double inputHeigth)
        {
            this.width = inputWidth;
            this.height = inputHeigth;
        }
        /// <summary>
        /// Sets the width of the figure. Checks if input is negative number or 0 an throws exception
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.width = value;
                }
            }
        }
        /// <summary>
        /// Sets the height of the figure. Checks if input is negative number or 0 an throws exception
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.height = value;
                }
            }
        }
        /// <summary>
        /// Returns the rotated size
        /// </summary>
        /// <param name="inputSize">figure size</param>
        /// <param name="figureAngle"></param>
        /// <returns>returns rotated size</returns>
        public static Size GetRotatedSize(Size inputSize, double figureAngle)
        {
            double width = Math.Cos((figureAngle) * inputSize.Width) + Math.Abs((Math.Sin(figureAngle)) * inputSize.Height);
            
            double heigth = Math.Abs((Math.Sin(figureAngle) * inputSize.Width) + Math.Abs((Math.Cos(figureAngle)) * inputSize.Height));
            
            Size rotatedSize = new Size(width, heigth);

            return rotatedSize;
        }
    }
}
