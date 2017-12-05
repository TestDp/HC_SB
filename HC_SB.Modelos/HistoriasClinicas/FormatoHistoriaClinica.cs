// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Juan Blandon.</author>
// <date>04/12/2017</date>
// <summary>Modelo que contiene la informacion de los diferentes formatos de la Historia Clinica.</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.Modelos.HistoriasClinicas
{
     [Table("Tbl_FormatosHistoriaClinica")]
    public class FormatoHistoriaClinica
    {
        /// <summary>
        /// Obtiene la clave primaria
        /// </summary>
        [Key]
        public int FormatoHistoriaClinicaKey { get; set; }


        /// <summary>
        /// Obtiene y establece el nombre del formato de la HC
        /// </summary>
        public String FormatoHistoriaClinicaName { get; set; }
    }
}
