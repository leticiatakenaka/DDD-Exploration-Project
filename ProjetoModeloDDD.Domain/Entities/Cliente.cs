using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public required string NomeCliente { get; set; }
        public required string SobrenomeCliente { get; set; }
        public required string EmailCliente { get; set; }
        public DateTime DataCadastroCliente { get; set; }
        public bool AtivoCliente { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }
        public bool EspecialCliente(Cliente cliente)
        {
            return cliente.AtivoCliente && DateTime.Now.Year - cliente.DataCadastroCliente.Year >= 5;
        }
    }
}
