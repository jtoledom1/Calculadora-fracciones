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
            Fracción A = new Fracción();
            Fracción B = new Fracción();
            Fracción C = A.Multiplicacion(B);
            Fracción D = A / B;
            Fracción E= A+B;
            Fracción F = A - B;

            C.NombreOperando = "A*B";
            D.NombreOperando = "A/B";
            E.NombreOperando = "A+B";
            F.NombreOperando = "A-B";
            int opción=0;
            while (opción!=5)
            {
                 Console.WriteLine("+++++++++++++ Calculadora de fracciones +++++++++++++");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. Divisiones");
            Console.WriteLine("5. SALIR");
            opción=int.Parse(Console.ReadLine());
            switch(opción)
            {
                case 1:
                    
                   Console.WriteLine(E.ToString());

                    break;

                case 2:

                    Console.WriteLine(F.ToString());

                    break;
                    
                case 3 :
             
                    Console.WriteLine(C.ToString());

                    break;
                case 4:

                    Console.WriteLine(D.ToString());

                    break;
            }
            Console.WriteLine($""); 
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            
            //TO DO: Agregar líneas de código que hagan una mejor estética del proyecto, agregar Clear y agregar readlines dónde sea necesario
            
            
            Console.ReadLine();
            }
        }
    }
}
