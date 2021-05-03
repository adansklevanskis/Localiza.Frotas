using Localiza.Frotas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Localiza.Frotas.Infra.Repository
{
    public class InMemoryRepository : IVeiculoRepository
    {
        private readonly IList<Veiculo> entities = new List<Veiculo>();
        public void Add(Veiculo veiculo)
        {
            entities.Add(veiculo);
        }

        public void Delete(Veiculo veiculo) => entities.Remove(veiculo);

        public IEnumerable<Veiculo> GetAll() => entities.ToList();

        public Veiculo GetById(Guid Id) => entities.SingleOrDefault(c => c.Id == Id);

        public void Update(Veiculo veiculo)
        {
            entities.Remove(GetById(veiculo.Id));
            entities.Add(veiculo);
        }
    }
}
