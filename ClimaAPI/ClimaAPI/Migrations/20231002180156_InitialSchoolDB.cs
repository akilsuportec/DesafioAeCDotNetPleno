using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClimaAPI.Migrations
{
    public partial class InitialSchoolDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Climas",
                columns: table => new
                {
                    codigo_icao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    umidade = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    visibilidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressao_atmosferica = table.Column<int>(type: "int", nullable: false),
                    vento = table.Column<int>(type: "int", nullable: false),
                    direcao_vento = table.Column<int>(type: "int", nullable: false),
                    condicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    condicao_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temp = table.Column<int>(type: "int", nullable: false),
                    atualizado_em = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Climas", x => x.codigo_icao);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Climas");
        }
    }
}
