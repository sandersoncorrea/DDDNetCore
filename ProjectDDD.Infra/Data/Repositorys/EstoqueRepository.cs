using ProjectDDD.Domain.Core.Interfaces.Repositorys;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
