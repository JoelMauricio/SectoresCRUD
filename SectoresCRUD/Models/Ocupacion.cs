namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class Ocupacion
    {
        public Ocupacion()
        {
            this.Ciudadano = new HashSet<Ciudadano>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual ICollection<Ciudadano> Ciudadano { get; set; }
    }
}
