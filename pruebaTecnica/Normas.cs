using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnica
{
    class Normas
    {
        
          
        //normas
        //Atributos
        string vestimenta  ;
        string actividades;
        int sueldo;


        public string Vestimenta { get => vestimenta; set => vestimenta = value; }
        public string Actividades { get => actividades; set => actividades = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

        //metodo
        public string mostrarRules()
        {
            return string.Format("La vestimaneta del colaborador sera " + vestimenta +" para" + actividades + " con un sueldo de " + sueldo);
        }
        
    }
}
