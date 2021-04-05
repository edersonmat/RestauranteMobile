using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class LivroCadastroModel
    {
        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(40, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, insira o título do livro.")]
        public string Titulo { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(40, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        public string Editora { get; set; }

        public int Edicao { get; set; }

        [MaxLength(4, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        public string AnoPublicacao { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(40, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, insira o nome do autor.")]
        public string NomeAutor { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, insira a descrição.")]
        public string Descricao { get; set; }

        public Autor Autor { get; set; }
        public Assunto Assunto { get; set; }

    }
}