using ExpertsClub.Teste.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertsClub.Teste.EntityFramework.Data.Database.Table
{
    public class ProdutoTable : IEntityTypeConfiguration<Produto>
    {
        // Modelagem da Tabela Produto
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            CriarTabelaProduto(builder);
            CargaInicialProduto(builder);
        }

        private void CriarTabelaProduto(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(p => p.Valor).IsRequired();
        }

        private void CargaInicialProduto(EntityTypeBuilder<Produto> builder)
        {
            //builder.HasData(
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Bic", Valor = 1 },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Azul", Valor = 1.39M },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Vermelha", Valor = 1.40M },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Preta", Valor = 1.41M },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Lápis", Valor = 0.37M },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Borracha", Valor = 0.74M }
            //    );

            //builder.HasData(
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Bic", Valor = 1, CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Azul", Valor = 1.39M, CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Vermelha", Valor = 1.40M, CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Caneta Preta", Valor = 1.41M, CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Lápis", Valor = 0.37M, CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Borracha", Valor = 0.74M, CategoriaId = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Pendrive", Valor = 27.90M, CategoriaId = Guid.Parse("D20AD953-5441-4675-8DDD-25DDCF3DA593") },
            //    new Produto { Id = Guid.NewGuid(), Nome = "Mouse", Valor = 33.50M, CategoriaId = Guid.Parse("D20AD953-5441-4675-8DDD-25DDCF3DA593") }
            //    );
        }
    }
}
