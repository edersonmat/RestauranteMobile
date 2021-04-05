using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Repository.Entities;

namespace Projeto.Repository.Mappings
{
    public class AssuntoMap : EntityTypeConfiguration<Assunto>
    {
        public AssuntoMap()
        {
            ToTable("Assunto");

            HasKey(a => a.CodAssunto);

            Property(a => a.CodAssunto)
                .HasColumnName("CodAssunto");

            Property(a => a.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(20);
        }
    }
}
