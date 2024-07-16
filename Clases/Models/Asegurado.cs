﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Models
{
    public class Asegurado
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(9)]
        public int DNI { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(50)]
        [Required]
        public string Estado { get; set; }

    }
}
