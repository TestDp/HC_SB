// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Juan Blandon.</author>
// <date>04/12/2017</date>
// <summary>Modelo que contiene la informacion de la Hitoria Clinica.</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.Modelos.HistoriasClinicas
{

    [Table("Tbl_HistoriasClinicas")]
    public class HistoriaClinica
    {
        /// <summary>
        /// Obtiene la clave primaria
        /// </summary>
        [Key]
        public int HistoriaClinicaKey { get; set; }


        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Paciente.
        /// </summary>
        [ForeignKey("Paciente")]
        public int HistoriaClinicaPacienteKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Paciente.
        /// </summary>
        [ForeignKey("PacienteKey")]
        public virtual Paciente Paciente { get; set; }


        /// <summary>
        /// Obtiene y establece la clave foranea a la tabla  Paciente.
        /// </summary>
        [ForeignKey("FormatoHistoriaClinica")]
        public int HistoriaClinicaFormatoHistoriaClinicaKey { get; set; }

        /// <summary>
        /// Obtiene y establece un objeto Paciente.
        /// </summary>
        [ForeignKey("FormatoHistoriaClinicaKey")]
        public virtual FormatoHistoriaClinica FormatoHistoriaClinica { get; set; }


        /// <summary>
        /// Obtiene y establece el Id (formato unico de Historia Clinica)
        /// </summary>
        public int HistoriaClinicaID { get; set; }
    }
}
