using System;

namespace CalculatorApp
{
    /// <summary>
    /// Простой класс калькулятора для выполнения базовых арифметических операций.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Складывает два числа.
        /// </summary>
        /// <param name="a">Первое слагаемое.</param>
        /// <param name="b">Второе слагаемое.</param>
        /// <returns>Сумма двух чисел.</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитает второе число из первого.
        /// </summary>
        /// <param name="a">Уменьшаемое.</param>
        /// <param name="b">Вычитаемое.</param>
        /// <returns>Разность двух чисел.</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножает два числа.
        /// </summary>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        /// <returns>Произведение двух чисел.</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Делит первое число на второе.
        /// </summary>
        /// <param name="a">Делимое.</param>
        /// <param name="b">Делитель.</param>
        /// <returns>Частное двух чисел.</returns>
        /// <exception cref="DivideByZeroException">Выбрасывается, когда делитель равен нулю.</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            return a / b;
        }

        /// <summary>
        /// Возводит число в указанную степень.
        /// </summary>
        /// <param name="baseNumber">Основание степени.</param>
        /// <param name="exponent">Показатель степени.</param>
        /// <returns>Результат возведения в степень.</returns>
        public static double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор C#");

            Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
            Console.WriteLine($"10 - 4 = {Calculator.Subtract(10, 4)}");
            Console.WriteLine($"7 * 2 = {Calculator.Multiply(7, 2)}");
            Console.WriteLine($"2 ^ 8 = {Calculator.Power(2, 8)}");

            try
            {
                Console.WriteLine($"10 / 2 = {Calculator.Divide(10, 2)}");
                Console.WriteLine($"10 / 0 = {Calculator.Divide(10, 0)}"); 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}
