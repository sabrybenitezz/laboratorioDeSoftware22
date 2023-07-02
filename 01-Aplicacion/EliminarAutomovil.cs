using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class EliminarAutomovil
    {
        private AutomovilRepositorio repositorio;
        public EliminarAutomovil(AutomovilRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(String Patente)
        {
            this.repositorio.EliminarAutomovil(Patente);
        }
    }
}

