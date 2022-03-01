using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxNumber
{
    internal class TestCases
    {
        public static readonly int[] IntCase1;
        public static readonly int[] IntCase2;
        public static readonly int[] IntCase3;
        public static readonly float[] FloatCase1;
        public static readonly float[] FloatCase2;
        public static readonly float[] FloatCase3;


        static TestCases()
        {
            IntCase1 = new int[] { 8, 10, 2 };
            IntCase2 = new int[] { 2, 40, 50 };
            IntCase3 = new int[] { 50, 30, 20 };
            FloatCase1 = new float[] { 7.5f, 1.5f, 3.9f };
            FloatCase2 = new float[] { 7.6f, 5.1f, 2.0f };
            FloatCase3 = new float[] { 2.6f, 20.5f, 4.6f };
        }

        public static string GetString<T>(T[] testCase)
        {
            return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
        }
    }
}
