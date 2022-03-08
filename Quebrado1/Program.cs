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
            Fracción C = A*B;
            Fracción D = A / B;
            Fracción E= A+B;
            Fracción F = A - B;
            

            C.NombreOperando = "A*B";
            D.NombreOperando = "A/B";
            E.NombreOperando = "A+B";
            F.NombreOperando = "A-B";
            int opción=0;
            int NumA=0;
            int NumB=0;
            int DenB=0;
            int DenA=0;
            while (opción!=5)
            {
            
                Console.WriteLine("+++++++++++++ Calculadora de fracciones +++++++++++++");
            
                Console.WriteLine("1. Suma");
            
                Console.WriteLine("2. Resta");
            
                Console.WriteLine("3. Multiplicación");
            
                Console.WriteLine("4. Divisiones");
            
                Console.WriteLine("5. SALIR");



                opción=int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Introduce El primer numerador");
                NumA=int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce El primer denominador");
                DenA=int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce El segundo numerador");
                NumB=int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce El segundo denominador");
                DenB=int.Parse(Console.ReadLine());
            
                DenA=A.Denominador;
                NumA=A.Numerador;
                DenB=B.Denominador;
                NumB=B.Numerador;
    
                switch(opción)
                {
                case 1:
                   Console.WriteLine("Elegiste Suma");
                   B.NombreOperando="B";

                   //Console.WriteLine($"{A} + {B}");
                   Console.WriteLine(E.ToString());
                   Console.ReadLine();
                   Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Elegiste Resta");
                    Console.WriteLine($"{A.ToString()} - {B.ToString()}");
                    Console.WriteLine(F.ToString());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                    
                case 3 :
                    Console.WriteLine("Elegiste Multiplicar");
                    Console.WriteLine($"{A.ToString()} x {B.ToString()}=");
                    Console.WriteLine(C.ToString());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Elegiste Dividir");
                    Console.WriteLine($"{A.ToString()} / {B.ToString()}");
                    Console.WriteLine(D.ToString());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            
            
                    Console.WriteLine($""); 
                    Console.WriteLine(A.ToString());
                    Console.WriteLine(B.ToString());
            
            }
        }
    }
}           //TO DO: Hacer que se puedan introducir datos por consola