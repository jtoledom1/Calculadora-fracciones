using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quebrado1
{
    internal class Fracción
    {
        #region propiedades
        public string NombreOperando { get; set; }
        public double Numerador { get; set; }
        public double Denominador { get; set;}
        #endregion

        #region Métodos
        public Fracción()
        {
            this.NombreOperando = "A";
            this.Numerador = 0;
            this.Denominador = 1;
            
        }
        public Fracción(double numerador,double denominador)
        {
            this.NombreOperando = "A";
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fracción(string nombreOperador,double numerador, double denominador)
        {
            this.NombreOperando = nombreOperador;
            this.Numerador = numerador;
            this.Denominador = denominador;
            
        }
        
        public static Fracción operator *(Fracción A, Fracción B)
        {
            return new Fracción(A.Numerador * B.Numerador, A.Denominador * B.Denominador);
        }
        public static Fracción operator /(Fracción A, Fracción B)
        {
            return new Fracción(A.Numerador * B.Denominador, A.Denominador * B.Numerador);
        }
      
        public override string ToString()
        {
            return $"{this.NombreOperando} = {this.Numerador}/{this.Denominador}";
        }
       
        public static Fracción operator +(Fracción A, Fracción B)
        {
            return new Fracción(B.Denominador*A.Numerador+A.Denominador*B.Numerador,A.Denominador *B.Denominador);
        }
        public static Fracción operator -(Fracción A, Fracción B)
        {
            return new Fracción(B.Denominador*A.Numerador-A.Denominador*B.Numerador,A.Denominador *B.Denominador);
        }
        
        #endregion
    }
}
