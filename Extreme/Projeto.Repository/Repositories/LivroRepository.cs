using Projeto.Repository.Context;
using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Repositories
{
    public class LivroRepository
    {
        public void Insert(Livro l)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(l).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(Livro l)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(l).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(Livro l)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(l).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public List<Livro> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Livro
                    .Include(l=>l.Autor).Where(l => l.AutorId == l.Autor.CodAutor)
                    .Include(l=>l.Assunto).Where(l => l.AssuntoId == l.Assunto.CodAssunto)
                    .ToList();
            }
        }

        public Livro FindById(int CodLivro)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Livro
                    .Where(l => l.CodLivro == CodLivro)
                    .Include(a => a.Autor)
                    .Include(l => l.Assunto)
                    .FirstOrDefault();
                    
                    /*
                    .Include(l => l.Autor).Where(l => l.AutorId == l.Autor.CodAutor)
                    .Include(l => l.Assunto).Where(l => l.AssuntoId == l.Assunto.CodAssunto)
                    .FirstOrDefault(l => l.CodLivro == CodLivro);
                    */

            }
        }
    }
}
