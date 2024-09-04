using System;

Console.WriteLine("Hello, World!");

//namespace
namespace ConsoleApp.localizacion
{
    //Clase Paises
    public class Paises
    {
        //Atributos privados de la clase
        private int id = 0;
        private string nombre = "";

        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }//Fin Clase Paises

    //Clase Departamentos
    public class Departamentos
    {
        //Atributos privados de la clase
        private int id = 0;
        private string nombre = "";

        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }//Fin Clase Departamentos

    //Clase Ciudades
    public class Ciudades
    {
        //Atributos privados de la clase
        private int id = 0;
        private string nombre = "";

        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }//Fin Clase Cuidades

    //Clase Barrios
    public class Barrios
    {
        //Atributos privados de la clase
        private int id = 0;
        private string nombre = "";

        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }//Fin Clase Barrios


    public class Coordenadas
    {
        //Atributos privados de la clase
        private int id = 0;
        private string latitud = "";
        private string longitud = "";


        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public string Latitud { get => this.latitud; set => this.latitud = value; }
        public string Longitud { get => this.longitud; set => this.longitud = value; }
    }//Fin Clase Coordenadas

    //Clase Personas
    public class Personas
    {
        //Atributos privados de la clase
        private int id= 0;
        private string cedula = "";
        private string nombre = "";
        private string contraseña  = "";


        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Contraseña { get => this.contraseña; set => this.contraseña = value; }
    }//Fin Clase Personas

    //Clase Ubicaciones
    public class Ubicaciones
    {
        //Atributos privados de la clase
        private int id = 0;
        private string descripcion = "";
        private string nombre = "";
        private string imagen  = "";
        private Paises? pais = null;
        private Departamentos? departamento = null;
        private Ciudades? ciudad = null;
        private Barrios? barrio = null;
        private Coordenadas? coordenada = null;


        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public Paises? Pais { get => this.pais; set => this.pais = value; }
        public Departamentos? Departamento { get => this.departamento; set => this.departamento = value; }
        public Ciudades? Ciudad { get => this.ciudad; set => this.ciudad = value; }
        public Barrios? Barrio { get => this.barrio; set => this.barrio = value; }
        public Coordenadas? Coordenada { get => this.coordenada; set => this.coordenada = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Imagen{ get => this.imagen; set => this.imagen = value; }

    } //Fin Clase Ubicaciones
    
    //Clase Detalles
    public class Detalles
    {
        //Atributos privados de la clase
        private int id = 0;
        private DateTime? fecha = null;
        private Ubicaciones? ubicacion = null;
        private Personas? persona = null;


        //getters & setters de los atributos
        public int Id { get => this.id; set => this.id = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public Ubicaciones? Ubicacion { get => this.ubicacion; set => this.ubicacion = value; }
        public Personas? Persona { get => this.persona; set => this.persona = value; }
    }//Fin Clase Detalles



} //Fin namespace

