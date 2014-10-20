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
         private double  heigth;


         public Size(double inputWidth, double inputHeigth)
         {
        
            this.width = inputWidth;
            this.heigth = inputHeigth;
         }

        public double Width
        {
            get
            {
                return width;
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

        public double Heigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                if (value <= 0)
	            {
		            throw new IndexOutOfRangeException();
	            }
                else
	            {
                    this.heigth = value;
	            }
            }
        }
    }

    public static Size GetRotatedSize(Size s, double angleOfTheFigureThatWillBeRotaed)
    {
        Size papaz = new Size
        
      //return new Size(
      //  Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
      //    Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
      //  Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
      //    Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
    }

}
