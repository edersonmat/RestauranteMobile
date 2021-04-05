using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Repository.Entities;
using Projeto.Repository.Repositories;
using Projeto.Services.Models;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/livro")]
    public class LivroController : ApiController
    {
        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Insert(LivroCadastroModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    
                    Livro l = new Livro();
                    l.Autor = new Autor();
                    l.Assunto = new Assunto();
                    l.Titulo = model.Titulo;
                    l.Editora = model.Editora;
                    l.Edicao = model.Edicao;
                    l.AnoPublicacao = model.AnoPublicacao;
                    l.Autor.Nome = model.NomeAutor;
                    l.Assunto.Descricao = model.Descricao;

                    LivroRepository rep = new LivroRepository();
                    rep.Insert(l);

                    return Request.CreateResponse(HttpStatusCode.OK, "Livro Cadastrado com Sucesso");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Update(EdicaoLivroModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Livro l = new Livro();
                    l.Autor = new Autor();
                    l.Assunto = new Assunto();
                    l.CodLivro = model.CodLivro;
                    l.AutorId = model.CodAutor;
                    l.AssuntoId = model.CodAssunto;
                    l.Autor.CodAutor = l.AutorId;
                    l.Assunto.CodAssunto = l.AssuntoId;
                    l.Titulo = model.Titulo;
                    l.Editora = model.Editora;
                    l.Edicao = model.Edicao;
                    l.AnoPublicacao = model.AnoPublicacao;
                    l.Autor.Nome = model.NomeAutor;
                    l.Assunto.Descricao = model.Descricao;

                    LivroRepository rep = new LivroRepository();
                    rep.Update(l);
                    return Request.CreateResponse(HttpStatusCode.OK, "Livro Atualizado com Sucesso");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                LivroRepository rep = new LivroRepository();
                Livro l = rep.FindById(id);
                rep.Delete(l);
                return Request.CreateResponse(HttpStatusCode.OK, "Livro Deletado com Sucesso");
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpGet]
        [Route("listartodos")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                List<LivroConsultaModel> lista = new List<LivroConsultaModel>();
                LivroRepository rep = new LivroRepository();
                foreach(Livro l in rep.FindAll())
                {
                    LivroConsultaModel model = new LivroConsultaModel();
                    model.CodLivro = l.CodLivro;
                    model.Titulo = l.Titulo;
                    model.Editora = l.Editora;
                    model.Edicao = l.Edicao;
                    model.AnoPublicacao = l.AnoPublicacao;
                    model.CodAutor = l.Autor.CodAutor;
                    model.NomeAutor = l.Autor.Nome;
                    model.CodAssunto = l.Assunto.CodAssunto;
                    model.Descricao = l.Assunto.Descricao;

                    lista.Add(model);
                }
                return Request.CreateResponse(HttpStatusCode.OK, lista);

            }catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpGet]
        [Route("obterporid")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                LivroRepository rep = new LivroRepository();
                Livro l = rep.FindById(id);

                LivroConsultaModel model = new LivroConsultaModel();
                model.CodLivro = l.CodLivro;
                model.Titulo = l.Titulo;
                model.Editora = l.Editora;
                model.Edicao = l.Edicao;
                model.AnoPublicacao = l.AnoPublicacao;
                model.CodAutor = l.Autor.CodAutor;
                model.NomeAutor = l.Autor.Nome;
                model.CodAssunto = l.Assunto.CodAssunto;
                model.Descricao = l.Assunto.Descricao;

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
