using System.Numerics;

namespace Route.ADV01.Generics
{
    internal class Utility
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        // INumber  > < =
        public static T FindMaxValue<T>(T[] items) where T : IComparable<T>
        {
            if (items is not null && items.Length > 0)
            {
                T maxValue = items[0];


                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i].CompareTo(maxValue) > 0)
                        maxValue = items[i];
                }


                return maxValue;
            }

            return default;
            // 0
            // false
            // null
        }
    }
}
