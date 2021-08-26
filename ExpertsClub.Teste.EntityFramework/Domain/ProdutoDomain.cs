using ExpertsClub.Teste.EntityFramework.Model;
using System.Collections.Generic;
using System.Linq;

namespace ExpertsClub.Teste.EntityFramework.Domain
{
    public class ProdutoDomain
    {
        public List<Produto> ConsultarProdutos()
        {
            using var db = new Data.ApplicationDbContext();

            return db.Produtos.ToList();
        }

        public Produto ConsultarProdutoNome(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            return db.Produtos.Where(p => p.Nome == produto.Nome).FirstOrDefault();
        }

        public void AdicionarProduto(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            db.Add(produto);
            db.SaveChanges();
        }

        //public List<Produto> ConsultarProdutosPorCategoria(Produto produto)
        //{
        //    using var db = new Data.ApplicationDbContext();

        //    return db.Produtos.Where(p => p.CategoriaId == produto.CategoriaId).ToList();
        //}
    }
}
