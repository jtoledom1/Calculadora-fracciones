using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quebrado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fracción A = new Fracción(1,2);
            Fracción B = new Fracción("B",3, 4);
            Fracción C = new Fracción("C",3,9);
            Console.WriteLine($""); 
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());
            Console.ReadLine();
        }
    }
}
