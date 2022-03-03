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
            Fracción B = new Fracción(2, 2);
            Fracción C = new Fracción(3, 2);
            Console.WriteLine($"");
            Console.WriteLine(A.Imprime());
            Console.ReadLine();
        }
    }
}
