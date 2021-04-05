using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Mappings
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");

            HasKey(a => a.CodAutor);

            Property(a => a.CodAutor)
                .HasColumnName("CodAutor");

            Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(40);

        }
    }
}
