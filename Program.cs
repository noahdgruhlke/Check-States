using System;
using System.Collections.Concurrent;
using System.IO;

[System.AttributeUsage(System.AttributeTargets.All)]
public class DefaultValueAttribute : Attribute;

namespace StateofVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aArrays = new int[4] {1, 8, 4, 7};

            Console.WriteLine(aArrays[2]);

            //byte defaultByte = default;
            //short defaultShort = default;
            //int defaultInt = default;
            //long defaultLong = default;
            //float defaultFloat = default;
            //double defaultDouble = default;
            //decimal defaultDecimal = default;
            //bool defaultBool = default;
            //char defaultChar = default;

            //Console.WriteLine(defaultByte);
            //Console.WriteLine(defaultShort);
            //Console.WriteLine(defaultInt);
            //Console.WriteLine(defaultLong);
            //Console.WriteLine(defaultFloat);
            //Console.WriteLine(defaultDouble);
            //Console.WriteLine(defaultDecimal);
            //Console.WriteLine(defaultChar);
            //Console.WriteLine(defaultBool);

            Environment.Exit(0);
        }
    }
}