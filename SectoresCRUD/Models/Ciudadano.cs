namespace SectoresCRUD.Models
{
    using System;
    using System.Collections.Generic;
    public class Ciudadano
    {
        public string Id { get; set; }
        public int Secuencia { get; set; }
        public string NoCedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public Nullable<int> OcupacionId { get; set; }
        public Nullable<int> TipoDeSangreId { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> LugarDeNacimientoId { get; set; }
        public Nullable<System.DateTime> FechaDeNacimiento { get; set; }
        public Nullable<System.DateTime> FechaDeExpiracion { get; set; }
        public Nullable<int> NacionalidadId { get; set; }
        public Nullable<int> EstadoCivilId { get; set; }
        public string Firma { get; set; }
        public Nullable<int> ColegioElectoralId { get; set; }
        public string Foto { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string RegistroDeNacimiento { get; set; }
        public Nullable<int> EstadoId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacionId { get; set; }

        public virtual CiudadanoEstado CiudadanoEstado { get; set; }
        public virtual ColegioElectoral ColegioElectoral { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Nacionalidad Nacionalidad { get; set; }
        public virtual Ocupacion Ocupacion { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual TipoDeSangre TipoDeSangre { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
