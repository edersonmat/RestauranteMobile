using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Repository.Entities;
using Projeto.Repository.Context;

namespace Projeto.Repository.Repositories
{
    public class AssuntoRepository
    {
        public void Insert(Assunto a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(Assunto a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(Assunto a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public List<Assunto> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Assunto.ToList();
            }
        }

        public Assunto FindById(int CodAssunto)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Assunto.Find(CodAssunto);
            }
        }
    }
}
