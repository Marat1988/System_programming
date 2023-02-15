using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Library
{
    public class Formulas
    {
        /// <summary>
        /// Вычисление площади прямоугольного треугольника
        /// </summary>
        /// <param name="catet1">Катет</param>
        /// <param name="catet2">Катет</param>
        /// <returns>Значение площади прямоугольного треугольника</returns>
        public static double GetAreaRightTriangle(double catet1, double catet2) => (catet1 * catet2) / 2;
        /// <summary>
        /// Вычисление площади прямоугольного треугольника по формуле Герона
        /// </summary>
        /// <param name="sideA">Сторона треугольника</param>
        /// <param name="sideB">Сторона треугольника</param>
        /// <param name="sideC">Сторона треугольника</param>
        /// <returns>>Значение площади треугольника</returns>
        public static double GetAreaHeronFormula(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        /// <summary>
        /// Вычисление площади квадрата
        /// </summary>
        /// <param name="side">Сторона квадрата</param>
        /// <returns>Значение площади квадрата</returns>
        public static double GetSquareArea(double side) => side * side;
        /// <summary>
        /// Вычисление площади прямоугольника
        /// </summary>
        /// <param name="sideA">Сторона прямоугольника</param>
        /// <param name="sideB">Сторона прямоугольника</param>
        /// <returns>Значение площади прямоугольника</returns>
        public static double GetSquareAreaRectangle(double sideA, double sideB) => sideA * sideB;
    }
}
