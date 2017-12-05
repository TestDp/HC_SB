// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Cristian Mauricio Arenas Gomez.</author>
// <date>06/01/2017</date>
// <summary>Modelo que contiene la informacion de los peligros registrados.</summary>

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
        /// Obtiene y establece el Aseguradora del paciente
        /// </summary>
        public String PacienteAseguradora { get; set; }

        /// <summary>
        /// Obtiene y establece el Tipo de vinculacion del paciente
        /// </summary>
        public String PacienteTipoVincualacion { get; set; }

        /// <summary>
        /// Obtiene y establece el Lugar de Residencia del paciente
        /// </summary>
        public String PacienteLugarResidencia { get; set; }

        /// <summary>
        /// Obtiene y establece la direccion del paciente
        /// </summary>
        public String PacienteDireccion { get; set; }

        /// <summary>
        /// Obtiene y establece el genero del paciente
        /// </summary>
        public String PacienteGenero { get; set; }

        /// <summary>
        /// Obtiene y establece el Estado civil del paciente
        /// </summary>
        public String PacienteEstadoCivil { get; set; }

        /// <summary>
        /// Obtiene y establece el nivel educativo del paciente
        /// </summary>
        public String PacienteNivelEducativo { get; set; }

        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Contacto (Responsable).
        /// </summary>
        [ForeignKey("Contacto")]
        public int PacienteContacto1Key { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Contacto.
        /// </summary>
        [ForeignKey("ContactoKey")]
        public virtual Contacto Contacto1 { get; set; }

        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Contacto (Acompañante).
        /// </summary>
        [ForeignKey("Contacto")]
        public int PacienteContacto2Key { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Contacto.
        /// </summary>
        [ForeignKey("ContactoKey")]
        public virtual Contacto Contacto2 { get; set; }

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
    }
}
