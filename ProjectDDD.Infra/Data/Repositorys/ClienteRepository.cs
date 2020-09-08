using ProjectDDD.Domain.Core.Interfaces.Repositorys;
using ProjectDDD.Domain.Entities;

namespace ProjectDDD.Infra.Data.Repositorys
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        private readonly SqlContext _sqlContext;
        public ClienteRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
