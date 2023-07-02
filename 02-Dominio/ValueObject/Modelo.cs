﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Modelo
    {
        private String valor;

        public Modelo(String valor)
        {
            this.DebeContenerMasDe4Caracteres(valor);
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeContenerMasDe4Caracteres(String valor)
        {
            if (valor.Length < 4)
            {
                throw new Exception("El nombre de la marca debe contener, al menos, 4 caractreres");
            }
        }
    }
}
