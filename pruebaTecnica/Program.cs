using System;

namespace pruebaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Reporte de entrevistas
            */

            //aqui estan nuestros valores
            string nomEmpleado;
            string puesto;
            string nomGerente;

            string actividades = "Administrar Recursos";
            string vestimenta = "Formal";
            int sueldo = 20000;

            //Realizamos unas preguntas, gracias por responderlas 
            Console.WriteLine("***   REPORTE DE ENTREVISTAS   ***");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Cual es el nombre del solicitante?");
            nomEmpleado = Console.ReadLine();
            Console.WriteLine("Cual es el puesto solicitante?");
            puesto = Console.ReadLine();
            Console.WriteLine("Quien realiza la entrevista?");
            nomGerente = Console.ReadLine();
            // Console.WriteLine("");



            //objetos
            Entrevista entrevista = new Entrevista();

            entrevista.NomEmpleado = nomEmpleado;
            entrevista.Puesto = puesto;
            entrevista.NomGerente = nomGerente;

            //llamaremos al metodo que se encuentra en la clase entrevista
            Console.WriteLine(entrevista.mostrar());


            Normas normas = new Normas();
            normas.Actividades = actividades;
            normas.Sueldo = sueldo;
            normas.Vestimenta = vestimenta;

           //llamaremos al metodo que se encuentra en la clase normas
            Console.WriteLine(normas.mostrarRules());


           /*
            Hola que tal, espero haber captado la idea del ejercicio, 
            al entender lo que se buscaba ejecutar como respuesta.
           Saludos!
            */
            
                
        }
    }
}
