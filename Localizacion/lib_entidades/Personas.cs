
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    
    namespace lib_entidades
    {
        public class Personas
        {
            [Key] public int Id { get; set; }
            public string? Cedula { get; set; }
            public string? Nombre { get; set; }
            public DateTime Contrasena { get; set; }
        }
    }
}
