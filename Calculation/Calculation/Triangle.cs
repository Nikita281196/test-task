using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Triangle:Figure
    {
        #region Поля

        private readonly Lazy<bool> isRightAngled;

        #endregion

        #region Автосвойства

        /// <summary>
        /// Сторона A
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Проверка треугольника на прямоугольность 
        /// </summary>
        public bool IsRightAngled => isRightAngled.Value;

        #endregion

        #region Конструктор

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            isRightAngled = new Lazy<bool>(RectangleTypeCheck);
        }
        #endregion

        #region Методы

        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>        
        private bool RectangleTypeCheck()
        {
            
            double[] masSides = new double[] { FirstSide, SecondSide, ThirdSide };
            Array.Sort(masSides);
            Array.Reverse(masSides);
            double longestSideSquare = Math.Pow(masSides[0], 2);
            double squareOfOtherSides = Math.Pow(masSides[1], 2) + Math.Pow(masSides[2], 2);
            return longestSideSquare == squareOfOtherSides;
        }

        /// <summary>
        /// Поиск площади треугольника
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }

        #endregion
    }
}
