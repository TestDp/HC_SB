// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Juan Blandon.</author>
// <date>04/12/2017</date>
// <summary>Modelo que contiene la informacion de las Aseguradoras.</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.Modelos.HistoriasClinicas
{
    [Table("Tbl_Aseguradoras")]
    public class Aseguradora
    {
        /// <summary>
        /// Obtiene la clave primaria
        /// </summary>
        [Key]
        public int AseguradoraKey { get; set; }

        /// <summary>
        /// Obtiene y establece el nombre de la Aseguradora
        /// </summary>
        public String AseguradoraName { get; set; }
    }
}
