using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpertsClub.Teste.EntityFramework.Migrations
{
    public partial class AdicionarProdutosInformatica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("70e42eaa-a65a-4597-9dea-69df16d2af47"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Bic", 1m },
                    { new Guid("df60ef32-7006-4642-97a2-dd243c04c3ef"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Azul", 1.39m },
                    { new Guid("db3cd00d-638b-4170-8835-2ab68d770928"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Vermelha", 1.40m },
                    { new Guid("4f6dbedb-ea4a-49f8-8324-b1edb53b172d"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Caneta Preta", 1.41m },
                    { new Guid("d11b2c36-2826-4b7c-b4da-bd7f78047982"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Lápis", 0.37m },
                    { new Guid("f22a1d61-5148-4dd8-ae83-c52bd500cc86"), new Guid("fe0f2703-8d1f-4723-b234-e2c7c85f1dd4"), "Borracha", 0.74m },
                    { new Guid("0a3242c2-ca91-4f5c-9d36-fae235bf1c18"), new Guid("d20ad953-5441-4675-8ddd-25ddcf3da593"), "Pendrive", 27.90m },
                    { new Guid("c15b3d4d-1de7-4145-8900-69bbce833188"), new Guid("d20ad953-5441-4675-8ddd-25ddcf3da593"), "Mouse", 33.50m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("0a3242c2-ca91-4f5c-9d36-fae235bf1c18"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("4f6dbedb-ea4a-49f8-8324-b1edb53b172d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("70e42eaa-a65a-4597-9dea-69df16d2af47"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c15b3d4d-1de7-4145-8900-69bbce833188"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d11b2c36-2826-4b7c-b4da-bd7f78047982"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("db3cd00d-638b-4170-8835-2ab68d770928"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("df60ef32-7006-4642-97a2-dd243c04c3ef"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f22a1d61-5148-4dd8-ae83-c52bd500cc86"));

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
    }
}
