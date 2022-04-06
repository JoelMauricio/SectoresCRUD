namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class ColegioElectoral
    {
        public ColegioElectoral()
        {
            this.Ciudadano = new HashSet<Ciudadano>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string MunicipioId { get; set; }
        public string SectorId { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual ICollection<Ciudadano> Ciudadano { get; set; }
    }
}
