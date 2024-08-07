using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; } = String.Empty;
        public string Bairro { get; set; } = String.Empty;
        public string Cidade { get; set; } = String.Empty;
        public string Estado { get; set; } = String.Empty;
        public string CEP { get; set; } = String.Empty;
        public string Numero { get; set; } = String.Empty;
        public Cliente EntCliente { get; set; } = new Cliente();
    }
}
