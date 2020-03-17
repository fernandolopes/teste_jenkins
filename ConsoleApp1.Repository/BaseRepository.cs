using ConsoleApp2.Repository.Interfaces;
using System.Collections.Generic;
using System.Data;
using Dapper.FastCrud;
using Dapper.FastCrud.Mappings;

namespace ConsoleApp2.Repository
{
    public abstract class BaseRepository<T> : IBaseRepostory<T>
    {
        private readonly IDbConnection _connection;
        private readonly EntityMapping<T> _config;
        public BaseRepository(IDbConnection connection, EntityMapping<T> config)
        {
            this._connection = connection;
            this._config = config;
        }

        public T Get(int Id)
        {
            _connection.Open();
            T resp = (T)(object) _connection.Get(new { Id });
            _connection.Close();
            return resp;
        }

        public IEnumerable<T> GetAll()
        {
            _connection.Open();
            var items = _connection.Find<T>(statement => statement.WithEntityMappingOverride(_config));
            _connection.Close();
            return items;
        }

        public void Save(T obj)
        {
            _connection.Open();
            _connection.Insert(obj);
            _connection.Close();
        }
    }
}
