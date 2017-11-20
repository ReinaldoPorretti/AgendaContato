using Agenda.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class HomeController : Controller
    {
        private ContatoService _service;

        public HomeController()
        {
            _service = new ContatoService();
        }
        public ActionResult Index()
        {
            ViewBag.Contatos = _service.ConsultaContatoService()
                .Select(contatoDominio => new ContatoViewModel
                {
                    
                    Codigo = contatoDominio.Codigo,
                    Nome = contatoDominio.Nome,
                    Endereco = contatoDominio.Endereco,
                    Bairro = contatoDominio.Bairro,
                    Cidade= contatoDominio.Cidade,
                    Estado = contatoDominio.Estado,
                    Telefone = contatoDominio.Telefone

                });
            ViewBag.Contatos = _service.ConsultaContatoService()
                .Select(contatoDominio => new ContatoViewModel
                {

                    Codigo = contatoDominio.Codigo,
                    Nome = contatoDominio.Nome,
                    Endereco = contatoDominio.Endereco,
                    Bairro = contatoDominio.Bairro,
                    Cidade = contatoDominio.Cidade,
                    Estado = contatoDominio.Estado,
                    Telefone = contatoDominio.Telefone

                });

            return View();
        }
    }
 }