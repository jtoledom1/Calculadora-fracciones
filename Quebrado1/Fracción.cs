﻿using System;
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
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        #endregion

        #region Métodos
        public Fracción()
        {
            this.NombreOperando = "A";
            this.Numerador = 0;
            this.Denominador = 1;
        }
        public Fracción(int numerador,int denominador)
        {
            this.NombreOperando = "A";
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fracción(string nombreOperador,int numerador, int denominador)
        {
            this.NombreOperando = nombreOperador;
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fracción Multiplicacion(Fracción B)
        {
            return new Fracción(Numerador * B.Numerador , this.Denominador * B.Denominador);

        }
        public override string ToString()
        {
            return $"{this.NombreOperando} = {this.Numerador}/{this.Denominador}";
        }
        #endregion

    }
}
