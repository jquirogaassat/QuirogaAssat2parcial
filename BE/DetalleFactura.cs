﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleFactura
    {

        public int Id { get; set; }
        public int IdArticulo { get; set; }

        public int IdFactura { get; set; }

        public int Cantidad { get; set; }
    }
}
