using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class TipoContatoController : Controller
    {
        // GET: TipoContato
        public ActionResult Index()
        {
            return View();
        }
        public RedirectToRouteResult Excluir(int id)
        {
            _service.ApagarTipoContatoRepositorio(id);

            return RedirectToAction("Index");
        }
        public ActionResult Detalhes(int id)
        {
            Dominio.TipoContato tipocontatoDominio = _service.ConsultaTipoContato(id);

            TipoContatoViewModel tipocontatoViewModel = new TipoContatoViewModel
            {
                
                Codigo = tipocontatoDominio.Codigo,
                Descricao = tipocontatoDominio.Descricao,
                
                
            };

            return View(tipocontatoViewModel);
        }
        public ActionResult Alterar(int id)
        {
            Dominio.TipoContato tipocontatoDominio = _service.ConsultaTipoContato(id);

            TipoContatoViewModel tipocontatoViewModel = new TipoContatoViewModel
            {
                Codigo = tipocontatoDominio.Codigo,
                Descricao = tipocontatoDominio.Descricao,
                
            };

            return View(tipocontatoViewModel);
        }

        public RedirectToRouteResult Salvar(TipoContatoViewModel tipocontato)
        {
            var tipocontatoDominio = new Dominio.TipoContato
            {
               
                Codigo = tipocontato.Codigo,
                Descricao = tipocontato.Descricao,
               
            };

            if (tipocontato.Codigo == 0)
            {
                int codigoGerado = _service.InserirTipoContato(tipocontatoDominio);
            }
            else
            {
                _service.AlterarTipoContato(tipocontatoDominio);
            }


            return RedirectToAction("Index");
        }
    }
}
}