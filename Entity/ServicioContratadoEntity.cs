﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioContratadoEntity : ServicioEntity
    {
        public int Cantidad { get; set; }

        public double Subtotal { get; set; }
    }
}
