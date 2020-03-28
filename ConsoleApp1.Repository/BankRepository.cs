using ConsoleApp1.Domain.Entities;
using Dapper.FastCrud;
using Dapper.FastCrud.Mappings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleApp2.Repository
{
    public class BankRepository : BaseRepository<Bank>
    {
        
        public BankRepository(IDbConnection connection, EntityMapping<Bank> config) : base(connection, config)
        { }

    }
}
