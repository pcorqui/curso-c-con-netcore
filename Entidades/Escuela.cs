namespace CoreEscuela.Entidades
{
    //en c# el nombre del archivo no importa que no coincida
    //con el nombre de la clase
    class Escuela
    {
        //atributos
        string nombre;

        public string Nombre{ 
            get{ return "Copia: " + nombre;} 
            set{ nombre = value.ToUpper();}
        }

        public int AñoDeCreacion{ get;set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela{get; set;}


/*     Constructor de forma tradicional
        public Escuela(string nombre, int año){
            this.nombre = nombre;
            AñoDeCreacion = año;
        }*/

        //asignacion por tuplas-- caracteristica muy usada en lenguajes funcionales
        public Escuela(string nombre, int año) => (Nombre,AñoDeCreacion) = (nombre, año);

        /*
         En chichar se puede crear parametros opcionales en los metodos
         de tal manera que se pueden llenar con valores por defecto y en el 
         momento de ser llamados asignarlos o no.
        */
        public Escuela(string nombre, int año, TiposEscuela tipos, string pais = "", string ciudad = "")
        {
            //asignacion de tuplas en el orden en que son colocadas
            // es el orden en que son asignadas despues
            (Nombre, AñoDeCreacion) = (nombre,año);
            Pais = pais;
            Ciudad = ciudad;

        }

   
        public override string ToString(){
            //interpolacion de cadenas te permite utilizar las variables directo sobre el string
            return $"Nombre{Nombre}, Tipo{TipoEscuela}, \n Pais{Pais}, Ciudad{Ciudad}";
        }
    }
}