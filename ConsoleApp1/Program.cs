using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            [DllImport(@"C:\Users\User\Desktop\rfr\Dll1\x64\Debug\Dll1.dll")]
            static extern void expo(int n, float[] a, float[] y, int[] result);
            Console.WriteLine("Hello World!");
            int n = 2;
            float[] a = new[] { 1.0f, 2.0f };
            float[] y = new[] { 1.0f, 2.0f };
            int[] result = new[] { 1, 2 };
            expo(n, a, y, result);
        }
    }
}
