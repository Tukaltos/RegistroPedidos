﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidos.Models
{
    public class Ordenes
    {
        [Key]
        public int OrdenId { get; set; }

        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Debe selecionar un suplidor para realizar la ordén.")]
        public int SuplidorId { get; set; }

        public float Monto { get; set; }


        public virtual List<OrdenesDetalle> Detalle { get; set; }
    }
}
