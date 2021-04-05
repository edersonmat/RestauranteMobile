using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Projeto.Repository.Entities;

namespace Projeto.Services.Models
{
    public class EdicaoLivroModel
    {
        [Required(ErrorMessage = "Por favor, insira o id do Livro.")]
        public int CodLivro { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(40, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, insira o título.")]
        public string Titulo { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(40, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        public string Editora { get; set; }

        public int Edicao { get; set; }

        [MaxLength(4, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        public string AnoPublicacao { get; set; }

        [Required(ErrorMessage = "Por favor, insira o id do Autor.")]
        public int CodAutor { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(40, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, insira o nome do autor.")]
        public string NomeAutor { get; set; }

        [Required(ErrorMessage = "Por favor, insira o id do Assunto.")]
        public int CodAssunto { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, insira o uma descrição.")]
        public string Descricao { get; set; }
        public Autor Autor { get; set; }
        public Assunto Assunto { get; set; }

    }
}