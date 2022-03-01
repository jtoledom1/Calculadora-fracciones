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
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        #endregion
        #region Métodos
        public Fracción()
        {
            this.Numerador = 0;
            this.Denominador = 1;
        }
        public Fracción(int numerador,int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = numerador;
        }
        #endregion

    }
}
