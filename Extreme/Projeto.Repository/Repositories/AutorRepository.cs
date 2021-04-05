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
    public class AutorRepository
    {
        public void Insert(Autor a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(Autor a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(Autor a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public List<Autor> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Autor.ToList();
            }
        }

        public Autor FindById(int CodAutor)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Autor.Find(CodAutor);
            }
        }
    }
}
