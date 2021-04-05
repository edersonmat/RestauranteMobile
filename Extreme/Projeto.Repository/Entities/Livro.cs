using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Entities
{
    public class Livro
    {
        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string AnoPublicacao { get; set; }
        public int AutorId { get; set; }
        public int AssuntoId { get; set; }

        #region Relacionamentos
        public virtual Autor Autor { get; set; }
        public virtual Assunto Assunto { get; set; }
        #endregion

    }
}
