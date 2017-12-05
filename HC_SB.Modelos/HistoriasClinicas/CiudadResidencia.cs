// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Juan Blandon.</author>
// <date>04/12/2017</date>
// <summary>Modelo que contiene la informacion de la Ciudades de Residencia.</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.Modelos.HistoriasClinicas
{
    [Table("Tbl_CiudadesResidencia")]
    public class CiudadResidencia
    {
        /// <summary>
        /// Obtiene la clave primaria
        /// </summary>
        [Key]
        public int CiudadResidenciaKey { get; set; }

        /// <summary>
        /// Obtiene y establece el nombre del Contacto
        /// </summary>
        public String CiudadName { get; set; }
    }
}
