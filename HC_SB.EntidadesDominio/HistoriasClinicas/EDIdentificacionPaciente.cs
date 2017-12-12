// <copyright file="EDIdentificacionPaciente.cs" company="dpsoluciones">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Cristian Arenas.</author>
// <date>11/12/2017</date>
// <summary>Entidad de dominio que contiene la informacion del Paciente.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_SB.EntidadesDominio.HistoriasClinicas
{
    public class EDIdentificacionPaciente
    {
        public string NombrePaciente { get; set; }

        public string Documento { get; set; }

        public int Edad { get; set; }

        public string RH { get; set; }

       public DateTime FechaNacimiento { get; set; }

       public string Telefono { get; set; }

       public int AseguradoraKey { get; set; }

       public string TipoVinculacion { get; set; }

       public int CiudadResidenciaKey { get; set; }

       public string Direccion { get; set; }

    }
}
