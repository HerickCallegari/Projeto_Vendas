using AplicativoVendas.DB;
using AplicativoVendas.Model.entities;

namespace AplicativoVendas
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            SaleContext context = new SaleContext();
            clearBanco (context);
            }

        static void clearBanco(SaleContext context)
            {
            foreach( Item x in  context.Items )
                {
                context.Items.Remove(x);
                }
            foreach (Pedido x in context.Pedidos)
                {
                context.Pedidos.Remove (x);
                }
            context.SaveChanges ();
            }
        }
    }
