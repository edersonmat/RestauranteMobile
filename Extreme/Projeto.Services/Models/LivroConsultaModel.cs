using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class LivroConsultaModel
    {
        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string AnoPublicacao { get; set; }
        public int CodAutor { get; set; }
        public string NomeAutor { get; set; }
        public int CodAssunto { get; set; }
        public string Descricao { get; set; }
        //public Autor Autor { get; set; }
        //public Assunto Assunto { get; set; }

    }
}