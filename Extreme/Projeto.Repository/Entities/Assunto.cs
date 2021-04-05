using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Entities
{
    public class Assunto
    {
        public int CodAssunto { get; set; }
        public string Descricao { get; set; }

        #region Relacionamentos

        public virtual List<Livro> Livros { get; set; }

        #endregion

    }
}
