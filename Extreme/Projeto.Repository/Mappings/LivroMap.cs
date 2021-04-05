using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Repository.Entities;

namespace Projeto.Repository.Mappings
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            //Chave Primária
            HasKey(l => l.CodLivro);

            Property(l => l.CodLivro)
                .HasColumnName("CodLivro");

            Property(l => l.Titulo)
                .HasColumnName("Titulo")
                .HasMaxLength(40)
                .IsRequired();

            Property(l => l.Editora)
                .HasColumnName("Editora")
                .HasMaxLength(40);

            Property(l => l.Edicao)
                .HasColumnName("Edicao");

            Property(l => l.AnoPublicacao)
                .HasColumnName("AnoPublicacao")
                .HasMaxLength(4);

            Property(l => l.AutorId)
                .HasColumnName("AutorId")
                .IsRequired();

            HasRequired(l => l.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(l => l.AutorId);

            HasRequired(l => l.Assunto)
                .WithMany(s => s.Livros)
                .HasForeignKey(l => l.AssuntoId);

        }
    }
}
