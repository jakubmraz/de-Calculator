using System;

namespace de_Calculator
{
    /// <summary>
    /// Calculator class containing the numerical operation methods.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Takes the base number and adds the second number to it.
        /// </summary>
        /// <param name="baseNumber"></param>
        /// <param name="numberToAdd"></param>
        /// <returns>double</returns>
        public double Add(double baseNumber, double numberToAdd)
        {
            return baseNumber + numberToAdd;
        }

        /// <summary>
        /// Takes the base number and subtracts the second number from it.
        /// </summary>
        /// <param name="baseNumber"></param>
        /// <param name="numberToSubtract"></param>
        /// <returns>double</returns>
        public double Subtract(double baseNumber, double numberToSubtract)
        {
            return baseNumber - numberToSubtract;
        }


        /// <summary>
        /// Takes the base number and multiplies it by the second number.
        /// </summary>
        /// <param name="baseNumber"></param>
        /// <param name="numberToMultiplyWith"></param>
        /// <returns>double</returns>
        public double Multiply(double baseNumber, double numberToMultiplyWith)
        {
            return baseNumber * numberToMultiplyWith;
        }

        /// <summary>
        /// Takes the base number and divides it by the second number. Cannot divide by 0.
        /// </summary>
        /// <param name="baseNumber"></param>
        /// <param name="numberToDivideWith"></param>
        /// <returns>double</returns>
        public double Divide(double baseNumber, double numberToDivideWith)
        {
            if (numberToDivideWith != 0)
            {
                return baseNumber / numberToDivideWith;
            }
            throw new DivideByZeroException();
        }
    }
}
