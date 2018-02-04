using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLibrary.UtilityClasses
{
    /// <summary>
    /// Класс предоставляет методы для работы с массивами
    /// </summary>
    public static class ArrayUtility
    {
        /// <summary>
        /// Метод позволяет пользователю заполнит одномерный массив целыми числами
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Одномерный массив целых чисел</returns>
        public static int[] EnterIntengerArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ConsoleInput.EnterIntengerNumber();
            }

            return array;

        }

        /// <summary>
        /// Метод позволяет заполнить одномерный массив случайными целыми числами в интервале (<see cref="leftLimit"/>, <see cref="rightLimit"/> )
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="leftLimit">Левая граница</param>
        /// <param name="rightLimit">Правая граница</param>
        /// <returns>Одномерный массив целых чисел</returns>
        public static int[] FillRandomInt(int size, int leftLimit, int rightLimit)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(leftLimit, rightLimit);
            }

            return array;
        }

    }
}
