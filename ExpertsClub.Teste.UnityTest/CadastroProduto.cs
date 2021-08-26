using ExpertsClub.Teste.EntityFramework.Domain;
using ExpertsClub.Teste.EntityFramework.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace ExpertsClub.Teste.UnityTest
{
    public class CadastroProduto
    {
        [Fact(DisplayName = "Consultar Produtos"), Trait("Cadastro", "Produto")]
        public void ConsultarProdutos()
        {
            // Act
            List<Produto> produtos = new ProdutoDomain().ConsultarProdutos();

            // Assert
            Assert.True(produtos.Count >= 6);
        }

        [Fact(DisplayName = "Consultar Produto"), Trait("Cadastro", "Produto")]
        public void ConsultarProduto()
        {
            // Act
            Produto produto = new ProdutoDomain().ConsultarProdutoNome(new Produto { Nome = "Caneta Azul" });

            // Assert
            Assert.Equal("Caneta Azul", produto.Nome);
        }

        //[Fact(DisplayName = "Adicionar Produto"), Trait("Cadastro", "Produto")]
        //public void AdicionarProduto()
        //{
        //    // Arrange
        //    Produto produto = new Produto();
        //    produto.Id = Guid.Parse("F97221A6-7DC9-4420-9408-82B13A77C6EE");
        //    produto.Nome = "Papel A4";
        //    produto.Valor = 24.90M;
        //    produto.CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4");

        //    // Act
        //    Produto produtoBanco = new ProdutoDomain().ConsultarProdutoNome(produto);
        //    if (produtoBanco == null)
        //        new ProdutoDomain().AdicionarProduto(produto);

        //    // Assert
        //    var produtoAdicionado = new ProdutoDomain().ConsultarProdutoNome(produto);
        //    Assert.True(produto.Id == produtoAdicionado.Id);
        //}

        //[Fact(DisplayName = "Consultar Produto por Categoria"), Trait("Cadastro", "Produto")]
        //public void ConsultarProdutoPorCategoria()
        //{
        //    // Act
        //    List<Produto> produtos = new ProdutoDomain().ConsultarProdutosPorCategoria(new Produto { CategoriaId = Guid.Parse("D20AD953-5441-4675-8DDD-25DDCF3DA593") });

        //    // Assert
        //    Assert.True(produtos.Count >= 2);
        //}
    }
}
