using _02_Dominio;
using _02_Dominio.Repositorio;

namespace _03_Infraestructura
{
    public class AutomovilRepositorioEnMemoria : AutomovilRepositorio
    {
        private List<Automovil> automoviles = new List<Automovil>();

        public void grabar(Automovil automovil)
        {
            this.automoviles.Add(automovil);
        }

        public List<Automovil> obtenerTodos()
        {
            return this.automoviles;
        }
        public void EliminarAutomovil(string id)
        {
            //Automovil automovil = automoviles.FirstOrDefault(a => a.Id == id);
            // if (automovil != null)
        //{
                //automoviles.Remove(automovil);
            //}
        }
        public void ActualizarAutomovil(string Patente,string Marca,string Modelo,int Precio)
        {
            //Automovil automovil = automoviles.FirstOrDefault(a => a.patente == Patente);
           // if (automovil != null)
            //{
               
                //automovil.ActualizarAutomovil();

               
                //automovil.Modelo = 2023;
           // }
        }
   // }


    }
}

    
