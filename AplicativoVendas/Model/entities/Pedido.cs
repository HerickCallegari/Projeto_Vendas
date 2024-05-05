using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoVendas.Model.entities
    {
    internal class Pedido
        {
        public int PedidoId { get; set; }
        public int Quantidade { get; set; } = 0;
        public double ValorTotalPedido { get; set; } = 0.0;
        public DateTime Data { get; set; }

        public Item Item { get; set; }
        public Pedido ( )
            {
            Data = DateTime.Now;
            }
        public Pedido ( Item item, int quantidade ) : this ()
            {
            if (item == null)
                throw new ArgumentNullException ("Pedido é nulo");

            if (quantidade <= 0)
                throw new ArgumentOutOfRangeException ("A quantidade é menor ou igual a 0");

            Quantidade = quantidade;
            ValorTotalPedido = quantidade * item.Valor;
            }


        }
    }
