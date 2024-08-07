using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public decimal Preco { get; set; }
        public Categoria EntCategoria { get; set; } = new Categoria();
    }
}
