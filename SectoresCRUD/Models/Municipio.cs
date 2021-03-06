namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class Municipio
    {
        public Municipio()
        {
            this.Sector = new HashSet<Sector>();
        }

        public int Id { get; set; }
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Sector> Sector { get; set; }

    }
}
