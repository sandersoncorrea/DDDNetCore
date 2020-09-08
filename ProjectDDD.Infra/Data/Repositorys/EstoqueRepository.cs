using ProjectDDD.Domain.Core.Interfaces.Repositorys;
using ProjectDDD.Domain.Entities;

namespace ProjectDDD.Infra.Data.Repositorys
{
    public class EstoqueRepository : RepositoryBase<Estoque>, IEstoqueRepository
    {
        private readonly SqlContext _sqlContext;
        public EstoqueRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
