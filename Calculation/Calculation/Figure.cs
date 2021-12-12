using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public abstract class Figure
    {
        #region Поля

        private readonly Lazy<double> square;

        #endregion

        #region Свойства
      
        public double Square => square.Value;

        #endregion

        #region Конструктор
        protected Figure()
        {
            square = new Lazy<double>(CalculateSquare);
        }
        #endregion

        #region Метод

        /// <summary>
        /// Поиск площади фигуры
        /// </summary>
        protected abstract double CalculateSquare();

        #endregion

    }
}
