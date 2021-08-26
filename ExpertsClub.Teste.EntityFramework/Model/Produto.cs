using System;

namespace ExpertsClub.Teste.EntityFramework.Model
{
    public class Produto
    {
        public Guid Id { get; set; }
        //public Guid CategoriaId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
