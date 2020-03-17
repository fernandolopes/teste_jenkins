using ConsoleApp1.Domain.Entities;
using ConsoleApp2.Repository;
using ConsoleApp2.Repository.Interfaces;
using Dapper.FastCrud;
using Dapper.FastCrud.Mappings;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
            .AddSingleton<IBaseRepostory<Bank>, BankRepository>()
            .AddScoped<IDbConnection>(_=> new MySqlConnection("Server=172.17.0.1;DataBase=testedb;Uid=root;Pwd=example") )
                .AddScoped(_=> OrmConfiguration
                .GetDefaultEntityMapping<Bank>()
                .SetDialect(SqlDialect.MySql)
                .SetTableName("bank")
             )
            .AddSingleton<Service>()
            .BuildServiceProvider();

            serviceProvider.GetService<Service>().Run();

           
        }
    }
}
