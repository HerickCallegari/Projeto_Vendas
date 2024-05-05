using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoVendas.Model.entities
    {
    internal class Item 
        {
        public int ItemId { get; }
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        public Item() { }
        public Item (  string descricao, double valor, int quantidadeEmEstoque )
            {
            Descricao = descricao;
            Valor = valor;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            }

        public void ModificaValor ( double valor )
            {
            if (valor < 0)
                throw new ArgumentException ("Valor menor que 0");

            Valor = valor;
            }
        public void ModificaDescricao ( string descricao )
            {
            if (descricao == null)
                throw new ArgumentNullException ("Descricao Nulla");
                

            Descricao = descricao;

            }

        public void AdicionaEmEstoque ( int quantidade )
            {
            if (quantidade <= 0)
                throw new ArgumentException ("Parametro incorreto, valor menor ou igual a 0");


            QuantidadeEmEstoque += quantidade;

            }

        public void RetiraDeEstoque ( int quantidade )
            {
            if (quantidade <= 0)
                throw new ArgumentException ("Parametro incorreto, valor menor ou igual a 0");

            if (quantidade > QuantidadeEmEstoque)
                throw new ArgumentException ("A quantidade que se esta retirando é maior que a em estoque");

            QuantidadeEmEstoque -= quantidade;

            }
        public void ModificaQuantidadeEmEstoque ( int quantidade )
            {
            if (quantidade <= 0)
                throw new ArgumentException ("Parametro incorreto, valor menor ou igual a 0");

            QuantidadeEmEstoque = quantidade;
            }

        }
    }
