using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnica
{
    class Entrevista
    {
        //personas
        //Atributos
        string nomEmpleado;
        string puesto;
        string nomGerente;
        // int paginas;


        public string NomEmpleado { get => nomEmpleado; set => nomEmpleado = value; }

        public string Puesto { get => puesto; set => puesto = value; }
        public string NomGerente { get => nomGerente; set => nomGerente = value; }
        //public int PAginas { get => paginas; set => paginas = value; }

        //metodo
        public string mostrar()
        {
            return string.Format("El Gerente " + nomGerente + " esta entrevistando a " + nomEmpleado + " para el puesto de " + puesto);
        }

    }
}
