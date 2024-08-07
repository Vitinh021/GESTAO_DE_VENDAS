using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Entidades
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Produto EntProduto { get; set; } = new Produto();
        public Venda EntVenda { get; set; } = new Venda();
    }
}
