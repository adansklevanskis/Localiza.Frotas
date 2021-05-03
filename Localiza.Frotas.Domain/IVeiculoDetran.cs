using System;
using System.Threading.Tasks;

namespace Localiza.Frotas.Domain
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoriaDetran(Guid veiculoId);
    }
}
