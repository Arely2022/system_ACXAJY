﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_ACXAJY.Entities
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string NomCliente { get; set; }
        public bool EstadoProd { get; set; }
        public double TotalPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string DirEntrega { get; set; }

    }
}
