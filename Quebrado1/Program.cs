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
            Fracción C = A * B;
            Fracción D = A / B;
            Fracción E = A + B;
            Fracción F = A - B;
            

            C.NombreOperando = "A*B";
            D.NombreOperando = "A/B";
            E.NombreOperando = "A+B";
            F.NombreOperando = "A-B";

            int opción=0;


            while (opción != 5) 
            {
                Console.WriteLine("+++++++++++++ Calculadora de fracciones +++++++++++++");

                Console.WriteLine("1. Suma");

                Console.WriteLine("2. Resta");

                Console.WriteLine("3. Multiplicación");

                Console.WriteLine("4. Divisiones");

                Console.WriteLine("5. SALIR");


                opción = int.Parse(Console.ReadLine());
                if (opción != 5) {
                    Console.Clear();
                    Console.WriteLine("Introduce El primer numerador");
                    A.Numerador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce El primer denominador");
                    A.Denominador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce El segundo numerador");
                    B.Numerador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce El segundo denominador");
                    B.Denominador = int.Parse(Console.ReadLine());


                    switch (opción)
                    {
                        case 1:
                            Console.WriteLine("Elegiste Suma");
                            B.NombreOperando = "B";

                            Console.WriteLine($"{A.ToString()} + {B.ToString()}");

                            Console.WriteLine(A + B);
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 2:
                            Console.WriteLine("Elegiste Resta");
                            Console.WriteLine($"{A.ToString()} - {B.ToString()}");
                            Console.WriteLine(A - B);
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 3:
                            Console.WriteLine("Elegiste Multiplicar");
                            Console.WriteLine($"{A.ToString()} x {B.ToString()}=");
                            Console.WriteLine(A * B);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Elegiste Dividir");
                            Console.WriteLine($"{A.ToString()} / {B.ToString()}");
                            Console.WriteLine(A / B);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                    //Console.WriteLine($""); 
                    //Console.WriteLine(A.ToString());
                    //Console.WriteLine(B.ToString());            
                }
            }
                
        }
    }
}           