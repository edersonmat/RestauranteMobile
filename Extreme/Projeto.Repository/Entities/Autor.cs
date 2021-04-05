using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Entities
{
    public class Autor
    {
        public int CodAutor { get; set; }
        public string Nome { get; set; }

        #region Relacionamentos

        public virtual List<Livro> Livros { get; set; }

        #endregion
    }
}
