﻿// <copyright file="Peligro.cs" company="Ada SA">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Juan Blandon.</author>
// <date>04/12/2017</date>
// <summary>Modelo que contiene la informacion de los Generos.</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.Modelos.HistoriasClinicas
{
    [Table("Tbl_Generos")]
    public class Genero
    {
        /// <summary>
        /// Obtiene la clave primaria
        /// </summary>
        [Key]
        public int GeneroKey { get; set; }

        /// <summary>
        /// Obtiene y establece el nombre del Genero
        /// </summary>
        public String GeneroName { get; set; }
    }
}
