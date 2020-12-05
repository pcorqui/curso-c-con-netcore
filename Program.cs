using System;
using CoreEscuela.Entidades;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cuando se llama el constructor, se puede indicar sus parametros
            //dependiendo de la firma de cada constructor
            var escuela = new Escuela("Platzi academi", 2012,TiposEscuela.Primaria,
                                ciudad:"Bogota");

            var curso1 = new Curso(){
                Nombre = "101",
            };

            var curso2 = new Curso(){
                Nombre = "201",
            };

            var curso3 = new Curso(){
                Nombre = "301",
            };

            //cuando imprimes y tiene sobreescrito el metodo ToString entonces se
            //manda a llamar implicitamente.
            Console.WriteLine(escuela);
            Console.WriteLine("=====================================");

            Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre}  ,  {curso2.UniqueId}");
            Console.WriteLine(curso3);

        }
    }
}
