namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class Usuario
    {
        public Usuario()
        {
            this.Ciudadano = new HashSet<Ciudadano>();
        }

        public string Id { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual ICollection<Ciudadano> Ciudadano { get; set; }
    }
}
