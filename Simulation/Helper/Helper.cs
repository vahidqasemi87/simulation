using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulation.Helper
{
    public static class Helper
    {
        //public static int[] _res1;
        public static int[] Rows()
        {
            int[] numbers = new int[20];
            for (int i = 1; i <= 20; i++)
            {
                numbers[i-1] = i;
            }
            return numbers;
        }
        public static int RandomTable4(int number)
        {
            return new Random().Next(100, 999);
        }
        public static int RandomTable5(int number)
        {
            return new Random().Next(10, 99);
        }
        ///Other helper
        public static int GetTime(int number)
        {
            switch (number)
            {
                case int n when (n >= 0 && n <= 125):
                    return 1;
                case int n when (n >= 126 && n <= 250):
                    return 2;
                case int n when (n >= 251 && n <= 375):
                    return 3;
                case int n when (n >= 376 && n <= 500):
                    return 4;
                case int n when (n >= 501 && n <= 625):
                    return 5;
                case int n when (n >= 626 && n <= 750):
                    return 6;
                case int n when (n >= 751 && n <= 875):
                    return 7;
                case int n when (n >= 876 && n <= 1000):
                    return 8;
                default:
                    return 1;
            }

        }
        public static int GetTimeService(int number)
        {
            switch (number)
            {
                case int n when (n >= 0 && n <= 10):
                    return 1;
                case int n when (n >= 11 && n <= 30):
                    return 2;
                case int n when (n >= 31 && n <= 60):
                    return 3;
                case int n when (n >= 61 && n <= 85):
                    return 4;
                case int n when (n >= 86 && n <= 95):
                    return 5;
                case int n when (n >= 96 && n <= 100):
                    return 6;
                default:
                    return 1;
            }

        }

    }
}
