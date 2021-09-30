using System;
using System.Runtime.InteropServices;

namespace Datatypes
{
    class Program
    {

        static void Main(string[] args)
        {
            unsafe
            { 
               
                ConvertDataTypes();

            }
        }
        unsafe static public void ConvertDataTypes()
        {
            int[] test = { 2, 3 };
            int testing = test.Length;
            if(testing < 1)
            {
                testing = 1;
            }
            var datatype = 1;
            
            var dataTypeSize = Marshal.SizeOf(datatype) * testing;
            var dataTypeBits = dataTypeSize*8;
            var datatypePossibleValues = Math.Pow(2, dataTypeBits);
            Console.WriteLine($"Datatype: {test.GetType()}");
            Console.WriteLine($"Datatype size: {dataTypeSize}");
            Console.WriteLine($"Datatype bits: {dataTypeBits}");
            Console.WriteLine($"Datatype possible values: {datatypePossibleValues}");
            Console.ReadKey();
        }
        



    }
}
