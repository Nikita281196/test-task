using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class AreaSearch
    {
        /// <summary>
        /// Поиск площади круга
        /// </summary>
        /// <param name="Radius">Радиус круга</param>
        /// <returns></returns>
        public double FindingTheAreaOfaCircle(float Radius)
        {            
            return Math.PI * Math.Pow(Radius, 2);
        }
        /// <summary>
        /// Поиск площади прямоугольника
        /// </summary>
        /// <param name="SideA">Сторона А</param>
        /// <param name="SideB"> Сторона В</param>
        /// <returns></returns>
        public double FindingTheAreaOfaRectangle(float SideA, float SideB)
        {
            return SideA * SideB;
        }
        /// <summary>
        /// Поиск площади треугольника 
        /// </summary>
        /// <param name="SideA">Сторона А</param>
        /// <param name="SideB">Сторона В</param>
        /// <param name="SideC">Сторона С</param>
        /// <returns></returns>
        public double FindingTheAreaOfaTriangle(float SideA, float SideB, float SideC)
        {
            float semiPerimeter = (SideA + SideB + SideC) / 2;           
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
        /// <summary>
        /// Поиск площади ромба
        /// </summary>
        /// <param name="Side">Сторона</param>
        /// <param name="Angle">Угол между ними</param>
        /// <returns></returns>
        public double FindingTheAreaOfaRhombus(float Side, float Angle)
        {           
            return Math.Pow(Side,2)*Math.Sin(Angle);
        }
        /// <summary>
        /// Поиск площади трапеции
        /// </summary>
        /// <param name="TrapezoidalDiagonalA">Диагональ А</param>
        /// <param name="TrapezoidalDiagonalB">Диагональ В</param>
        /// <param name="Angle">Угол между ними</param>
        /// <returns></returns>
        public double FindingTheAreaOfaTrapezoid(float TrapezoidalDiagonalA, float TrapezoidalDiagonalB, float Angle)
        {
            return TrapezoidalDiagonalA* TrapezoidalDiagonalB/2*Math.Sin(Angle);
        }
        /// <summary>
        /// Проверка типа треугольника
        /// </summary>
        /// <param name="SideA">Сторона А</param>
        /// <param name="SideB">Сторона В</param>
        /// <param name="SideC">Сторона С</param>
        /// <returns></returns>
        public string RectangleTypeCheck(float SideA, float SideB, float SideC)
        {
            float[] masSides =new float[] { SideA, SideB, SideC };
            Array.Sort(masSides);
            Array.Reverse(masSides);
            double longestSideSquare = Math.Pow(masSides[0],2);
            double squareOfOtherSides = Math.Pow(masSides[1], 2) + Math.Pow(masSides[2], 2);            
            string rezult = longestSideSquare == squareOfOtherSides ? "Прямоугольный треугольник" :
                longestSideSquare > squareOfOtherSides ? "Тупоугольный треугольник" :
                longestSideSquare < squareOfOtherSides ? "Остроугольный треугольник":"";
            return rezult;
        }

    }
}
