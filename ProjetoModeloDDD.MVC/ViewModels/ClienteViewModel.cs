using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]

        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "´Mínimo de {0} caracteres")]
        [DisplayName("Nome")]
        public required string NomeCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "´Mínimo de {0} caracteres")]
        [DisplayName("Sobrenome")]
        public required string SobrenomeCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("Email")]
        public required string EmailCliente { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastroCliente { get; set; }
        public bool AtivoCliente { get; set; }
        //public virtual required IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
