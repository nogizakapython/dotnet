using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace GetType1
{
    class Program
    {
        public void Foo()
        {
            Console.WriteLine("Foo");
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            Console.WriteLine(m.GetType());
        }
    }
}