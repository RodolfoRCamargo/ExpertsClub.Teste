using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpertsClub.Teste.EntityFramework.Migrations
{
    public partial class AdicionarCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Papelaria" },
                    { new Guid("d20ad953-5441-4675-8ddd-25ddcf3da593"), "Informática" }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("dda07aab-a5c7-429d-99c7-7d52943c1e8a"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Bic", 1m },
                    { new Guid("ec8987c0-ce4f-4006-a540-e1d6c40a3b1c"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Azul", 1.39m },
                    { new Guid("aa3d9ff8-d320-4feb-a0a6-12dc42885d1a"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Vermelha", 1.40m },
                    { new Guid("a72859e3-9865-4833-bfc3-29e41bd443f9"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Preta", 1.41m },
                    { new Guid("fb2273a5-42f2-4a12-af7b-aca91121a4b1"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Lápis", 0.37m },
                    { new Guid("e0454b5c-f584-4aad-9570-a5f4760441a3"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Borracha", 0.74m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a72859e3-9865-4833-bfc3-29e41bd443f9"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("aa3d9ff8-d320-4feb-a0a6-12dc42885d1a"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("dda07aab-a5c7-429d-99c7-7d52943c1e8a"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("e0454b5c-f584-4aad-9570-a5f4760441a3"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("ec8987c0-ce4f-4006-a540-e1d6c40a3b1c"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("fb2273a5-42f2-4a12-af7b-aca91121a4b1"));

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produto");

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
    }
}
