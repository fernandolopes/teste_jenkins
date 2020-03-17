using ConsoleApp1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Repository.Interfaces
{
    public interface IBaseRepostory<T>
    {
        T Get(int Id);

        IEnumerable<T> GetAll();

        void Save(T obj);
    }
}
