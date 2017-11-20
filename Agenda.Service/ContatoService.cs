using Agenda.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Service
{
    public class ContatoService
    {
        ContatoRepositorio _repositorio = new ContatoRepositorio();

        public List<ContatoRepositorio> ConsultaContatos()
        {
            return _repositorio.ConsultarContatos();
        }

        public int InserirContatoRepositorio(ContatoRepositorio contato)
        {
            return _repositorio.InserirContatoRepositorio(contato);
        }

        public void AlterarContatoRepositorio(ContatoRepositorio contato)
        {
            _repositorio.AlterarContatoRepositorio(contato);
        }

        public void ApagarContatoRepositorio(int codigoContato)
        {
            _repositorio.ApagarContatoRepositorio(codigoContato);
        }

        public object ConsultaContatoService()
        {
            throw new NotImplementedException();
        }
    }
}
