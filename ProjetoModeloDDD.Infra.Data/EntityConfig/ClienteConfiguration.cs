using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.IdCliente);

            Property(c => c.NomeCliente)
                .IsRequired().HasMaxLength(150);

            Property(c => c.SobrenomeCliente)
                .IsRequired().HasMaxLength(150);

            Property(c => c.EmailCliente)
                .IsRequired();
        }
    }
}
