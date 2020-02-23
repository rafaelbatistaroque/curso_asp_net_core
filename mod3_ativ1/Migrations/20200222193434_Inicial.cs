using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mod3_ativ1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_aluno = table.Column<string>(maxLength: 50, nullable: true),
                    sexo_aluno = table.Column<string>(maxLength: 20, nullable: true),
                    email_aluno = table.Column<string>(maxLength: 50, nullable: true),
                    data_nascimento_aluno = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
