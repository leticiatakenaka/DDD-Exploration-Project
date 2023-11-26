using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public required string NomeProduto { get; set; }
        public decimal ValorProduto { get; set; }
        public bool DisponivelProduto { get; set; }
        public int ClienteId { get; set; }
        public virtual required Cliente Cliente { get; set; }
    }
}
