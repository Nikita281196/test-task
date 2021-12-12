using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Circle:Figure
    {
        #region Автосвойства

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            Radius = radius;
        }
        #endregion

        #region Метод

        /// <summary>
        /// Поиск площади круга
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        #endregion
    }
}
