using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Seafi.Migrations
{
    public partial class InserAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios(Login, Senha, Nome, DataUltimoLogin) VALUES ('admin','123','Administrador', getdate())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
