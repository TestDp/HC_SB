// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Juan Blandon.</author>
// <date>04/12/2017</date>
// <summary>Modelo que contiene la informacion del Paciente.</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.Modelos.HistoriasClinicas
{
    [Table("Tbl_Pacientes")]
    public class Paciente
    {

        /// <summary>
        /// Obtiene la clave primaria
        /// </summary>
        [Key]
        public int PacienteKey { get; set; }

        /// <summary>
        /// Obtiene y establece el nombre del paciente
        /// </summary>
        public String PacienteNombre { get; set; }

        /// <summary>
        /// Obtiene y establece el identificacion del paciente
        /// </summary>
        public String PacienteIdentificacion{ get; set; }

        /// <summary>
        /// Obtiene y establece el edad del paciente
        /// </summary>
        public int PacienteEdad { get; set; }

        /// <summary>
        /// Obtiene y establece el RH del paciente
        /// </summary>
        public String PacienteRH { get; set; }

        /// <summary>
        /// Obtiene y establece la fecha de nacimiento del paciente
        /// </summary>
        public DateTime PacienteFechaNacimiento { get; set; }

        /// <summary>
        /// Obtiene y establece el telefono del paciente
        /// </summary>
        public String PacienteTelefono { get; set; }


        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Aseguradora.
        /// </summary>
        [ForeignKey("Aseguradora")]
        public int PacienteAseguradoraKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Aseguradora.
        /// </summary>
        [ForeignKey("AseguradoraKey")]
        public virtual Aseguradora Aseguradora { get; set; }

        /// <summary>
        /// Obtiene y establece el Tipo de vinculacion del paciente
        /// </summary>
        public String PacienteTipoVincualacion { get; set; }

        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Genero.
        /// </summary>
        [ForeignKey("CiudadResidencia")]
        public int PacienteCiudadResidenciaKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto CiudadResidencia.
        /// </summary>
        [ForeignKey("CiudadResidenciaKey")]
        public virtual CiudadResidencia CiudadResidencia { get; set; }

        /// <summary>
        /// Obtiene y establece la direccion del paciente
        /// </summary>
        public String PacienteDireccion { get; set; }


        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Genero.
        /// </summary>
        [ForeignKey("Genero")]
        public int PacienteGeneroKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Genero.
        /// </summary>
        [ForeignKey("GeneroKey")]
        public virtual Genero Genero { get; set; }


        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  EsatdoCivil.
        /// </summary>
        [ForeignKey("EstadoCivil")]
        public int PacienteEstadoCivilKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto EsatdoCivil.
        /// </summary>
        [ForeignKey("EsatdoCivilKey")]
        public virtual EstadoCivil EstadoCivil { get; set; }

        /// <summary>
        /// Obtiene y establece el nivel educativo del paciente
        /// </summary>
        public String PacienteNivelEducativo { get; set; }

        ///// <summary>
        ///// Obtiene y establece la clave foranea a la tabla  Contacto (Responsable).
        ///// </summary>
        //[ForeignKey("Contacto")]
        //public int PacienteContacto1Key { get; set; }

        ///// <summary>
        ///// Obtiene y establece un objeto Contacto.
        ///// </summary>
        //[ForeignKey("ContactoKey")]
        //public virtual Contacto Contacto1 { get; set; }

        ///// <summary>
        ///// Obtiene y establece la clave foranea a la tabla  Contacto (Acompañante).
        ///// </summary>
        //[ForeignKey("Contacto")]
        //public int PacienteContacto2Key { get; set; }

        ///// <summary>
        ///// Obtiene y establece un objeto Contacto.
        ///// </summary>
        //[ForeignKey("ContactoKey")]
        //public virtual Contacto Contacto2 { get; set; }

        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Ocupacion.
        /// </summary>
        [ForeignKey("Ocupacion")]
        public int PacienteOcupacionKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Contacto.
        /// </summary>
        [ForeignKey("OcupacionKey")]
        public virtual Ocupacion Ocupacion { get; set; }

        /// <summary>
        /// Obtiene y establece el motivo de ingreso del paciente
        /// </summary>
        public String PacienteMotivoIngreso { get; set; }

        /// <summary>
        /// Obtiene y establece el motivo de ingreso del paciente
        /// </summary>
        public String PacienteMotivoConsulta { get; set; }
    }
}
