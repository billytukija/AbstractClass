using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(TestClass);
            Console.Write(type.Name);
            Console.Read();
        }

        public class TestClass
        {
            public int Name { get; set; }
        }
    }
}
