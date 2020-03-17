using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    [Table("exemplo")]
    public class Exemplo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}