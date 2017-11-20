using Agenda.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Service
{
    public class TipoContatoService
    {
        TipoContatoRepositorio _repositorio = new TipoContatoRepositorio();

        public List<TipoContatoRepositorio> ConsultaTipoContatoRepositorio()
        {
            return _repositorio.ConsultaTipoContatoRepositorio();
        }

        public object ConsultaTipoContatoService()
        {
            throw new NotImplementedException();
        }

        public int InserirTipoContatoRepositorio(TipoContatoRepositorio tipocontato)
        {
            return _repositorio.InserirTipoContatoRepositorio(tipocontato);
        }

        public void AlterarTipoContatoRepositorio(TipoContatoRepositorio tipocontato)
        {
            _repositorio.AlterarTipoContatoRepositorio(tipocontato);
        }

        public void ApagarTipoContatoRepositorio(int codigoTipoContato)
        {
            _repositorio.ApagarTipoContatoRepositorio(codigoTipoContato);
        }
    }
    }
}
