using ConsoleApp1.Domain.Entities;
using ConsoleApp2.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service
    {

        private readonly IBaseRepostory<Bank> _baseRepostory;
        public Service(IBaseRepostory<Bank> baseRepostory)
        {
            _baseRepostory = baseRepostory;
        }

        public void Run()
        {

            var items = _baseRepostory.GetAll();

            foreach(var item in items)
            {
                Console.WriteLine($"[Id: {item.Id}, Nome: {item.Name}, Código: {item.Code}]");
                Task.Delay(300);
            }
            //while (true)
            //{
            //    Console.WriteLine("Hello World!");
            //    Task.Delay(300);
            //}
        }
    }
}
