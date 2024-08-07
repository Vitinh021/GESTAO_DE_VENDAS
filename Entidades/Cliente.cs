using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Telefone { get; set; } = String.Empty;
        public string CPF { get; set; } = String.Empty;
    }
}
