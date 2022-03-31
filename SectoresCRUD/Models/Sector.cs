namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class Sector
    {
        public int Id { get; set; }
        public int MunicipioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual Municipio Municipio { get; set; }
    }
}
