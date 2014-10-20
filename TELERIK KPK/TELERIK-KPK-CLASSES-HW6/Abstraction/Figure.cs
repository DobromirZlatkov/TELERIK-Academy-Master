namespace Shapes
{
    using System;

    /// <summary>
    /// Represents a geometric shape.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>The area.</returns>
        public abstract double CalcArea();
    }
}
