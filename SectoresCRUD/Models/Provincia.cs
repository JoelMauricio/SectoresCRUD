namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class Provincia
    {
        public Provincia()
        {
            this.Ciudadano = new HashSet<Ciudadano>();
            this.Municipio = new HashSet<Municipio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual ICollection<Ciudadano> Ciudadano { get; set; }
        public virtual ICollection<Municipio> Municipio { get; set; }
    }
}
