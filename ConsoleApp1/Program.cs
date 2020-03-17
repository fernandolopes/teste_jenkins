using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) 
        {
            var connection = "Server=localhost;DataBase=testedb;Uid=root;Pwd=example";
            var optionsBuilder = new DbContextOptionsBuilder<TestedbContext>();
            optionsBuilder.UseMySQL(connection);
            
            var ctx = new TestedbContext(optionsBuilder.Options);

            if(args.Length > 0)
            {
                Exemplo exemplo = new Exemplo { Nome = args[0], Idade = 0 };
                ctx.Exemplos.Add(exemplo);
                ctx.SaveChanges();
            }

            var list = from a in ctx.Exemplos let nomes = a.Nome select nomes;

            foreach(var i in list)
                Console.WriteLine("nome: {0}", i);

            Console.ReadKey();
        }
    }
}
