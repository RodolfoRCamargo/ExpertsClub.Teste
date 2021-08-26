using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpertsClub.Teste.EntityFramework.Migrations
{
    public partial class CargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("ab8c0592-5eee-4162-adda-02d92e4a7bca"), "Caneta Bic", 1m },
                    { new Guid("55b52782-347d-449f-8dc9-6345a2c1b4fe"), "Caneta Azul", 1.39m },
                    { new Guid("699ab757-aee2-43f9-9431-50344dcd5bcc"), "Caneta Vermelha", 1.40m },
                    { new Guid("f968aa94-0512-44c3-87ce-578bcffac834"), "Caneta Preta", 1.41m },
                    { new Guid("e73d4ef8-7205-403b-97de-dc31a5089660"), "Lápis", 0.37m },
                    { new Guid("21edaad0-e4c6-4f55-bf98-6cc6f568b898"), "Borracha", 0.74m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("21edaad0-e4c6-4f55-bf98-6cc6f568b898"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("55b52782-347d-449f-8dc9-6345a2c1b4fe"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("699ab757-aee2-43f9-9431-50344dcd5bcc"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("ab8c0592-5eee-4162-adda-02d92e4a7bca"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("e73d4ef8-7205-403b-97de-dc31a5089660"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f968aa94-0512-44c3-87ce-578bcffac834"));
        }
    }
}
