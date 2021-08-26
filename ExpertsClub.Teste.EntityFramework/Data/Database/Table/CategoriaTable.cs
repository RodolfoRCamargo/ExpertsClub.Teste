using ExpertsClub.Teste.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertsClub.Teste.EntityFramework.Data.Database.Table
{
    public class CategoriaTable : IEntityTypeConfiguration<Categoria>
    {
        // Modelagem da Tabela Categoria
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            CriarTabelaCategoria(builder);
            CargaInicialCategoria(builder);
        }

        private void CriarTabelaCategoria(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(20)").IsRequired();
        }

        private void CargaInicialCategoria(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(
                new Categoria { Id = Guid.Parse("FE0F2703-8D1F-4723-B234-E2C7C85F1DD4"), Nome = "Papelaria" },
                new Categoria { Id = Guid.Parse("D20AD953-5441-4675-8DDD-25DDCF3DA593"), Nome = "Informática" }
                );
        }
    }
}