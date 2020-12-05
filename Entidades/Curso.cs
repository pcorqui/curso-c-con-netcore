using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        //El set privado indica que solo puede ser usado en esta clase pero no por fuera
        public string UniqueId{ get; private set;}
        public string Nombre{ get; set;}
        public TiposJornada Jornada{ get; set;}

        public Curso() => UniqueId = Guid.NewGuid().ToString();
    }
}