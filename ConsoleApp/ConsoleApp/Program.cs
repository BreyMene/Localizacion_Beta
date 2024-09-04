using System;

Console.WriteLine("Hello, World!");

namespace ConsoleApp.localizacion
{
    public class Paises
    {
        private int id = 0;
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }

    public class Departamentos
    {
        private int id = 0;
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }
    public class Ciudades
    {
        private int id = 0;
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }
    public class Barrios
    {
        private int id = 0;
        private string nombre = "";
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }
    public class Coordenadas
    {
        private int id = 0;
        private string latitud = "";
        private string longitud = "";
        public int Id { get => this.id; set => this.id = value; }
        public string Latitud { get => this.latitud; set => this.latitud = value; }
        public string Longitud { get => this.longitud; set => this.longitud = value; }
    }
    public class Personas
    {
        private int id= 0;
        private string cedula = "";
        private string nombre = "";
        private string contraseña  = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Contraseña { get => this.contraseña; set => this.contraseña = value; }
    }
    public class Ubicaciones
    {
        private int id = 0;
        private string descripcion = "";
        private string nombre = "";
        private string imagen  = "";
        private Paises? pais = null;
        private Departamentos? departamento = null;
        private Ciudades? ciudad = null;
        private Barrios? barrio = null;
        private Coordenadas? coordenada = null;
        public int Id { get => this.id; set => this.id = value; }
        public Paises? Pais { get => this.pais; set => this.pais = value; }
        public Departamentos? Departamento { get => this.departamento; set => this.departamento = value; }
        public Ciudades? Ciudad { get => this.ciudad; set => this.ciudad = value; }
        public Barrios? Barrio { get => this.barrio; set => this.barrio = value; }
        public Coordenadas? Coordenada { get => this.coordenada; set => this.coordenada = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Imagen{ get => this.imagen; set => this.imagen = value; }

    }
    public class Detalles
    {
        private int id = 0;
        private DateTime? fecha = null;
        private Ubicaciones? ubicacion = null;
        private Personas? persona = null;
        public int Id { get => this.id; set => this.id = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public Ubicaciones? Ubicacion { get => this.ubicacion; set => this.ubicacion = value; }
        public Personas? Persona { get => this.persona; set => this.persona = value; }
    }
}

