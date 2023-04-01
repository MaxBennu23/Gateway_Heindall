using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gateway_Heindall.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integradores_ApplicationUsers_ApplicationUserId",
                table: "Integradores");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegradoresdoUser_ApplicationUsers_UserId1",
                table: "IntegradoresdoUser");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegradoresdoUserTemp_ApplicationUsers_UserId1",
                table: "IntegradoresdoUserTemp");

            migrationBuilder.DropIndex(
                name: "IX_IntegradoresdoUserTemp_UserId1",
                table: "IntegradoresdoUserTemp");

            migrationBuilder.DropIndex(
                name: "IX_IntegradoresdoUser_UserId1",
                table: "IntegradoresdoUser");

            migrationBuilder.DropIndex(
                name: "IX_Integradores_ApplicationUserId",
                table: "Integradores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "IntegradoresdoUserTemp");

            migrationBuilder.DropColumn(
                name: "GrupoPassword",
                table: "IntegradoresdoUser");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "IntegradoresdoUser");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Integradores");

            migrationBuilder.DropColumn(
                name: "UserBancoDestino",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserCNPJ",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserHost",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserHostUser",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserNivel",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserNomeEmpresa",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserPort",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserSenha",
                table: "ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "ApplicationUser");

            migrationBuilder.RenameColumn(
                name: "PublicKey",
                table: "IntegradoresdoUser",
                newName: "IntegUserUser");

            migrationBuilder.RenameColumn(
                name: "PrivateKey",
                table: "IntegradoresdoUser",
                newName: "IntegUserPublicKey");

            migrationBuilder.RenameColumn(
                name: "IntegradorNome",
                table: "IntegradoresdoUser",
                newName: "IntegUserPrivateKey");

            migrationBuilder.RenameColumn(
                name: "GrupoUser",
                table: "IntegradoresdoUser",
                newName: "IntegUserPass");

            migrationBuilder.RenameColumn(
                name: "GrupoPort",
                table: "IntegradoresdoUser",
                newName: "IntegUserPort");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "IntegradoresdoUserTemp",
                type: "varchar(95)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "IntegradoresdoUser",
                type: "varchar(95)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ApplicationUser",
                type: "varchar(95)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UsersDadosConex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserCNPJ = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserNivel = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserNomeEmpresa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserHostDestino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserHostUserDestino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserSenhaDestino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserPortDestino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserBancoDestino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDadosConex", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_IntegradoresdoUserTemp_UserId",
                table: "IntegradoresdoUserTemp",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegradoresdoUser_UserId",
                table: "IntegradoresdoUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IntegradoresdoUser_ApplicationUser_UserId",
                table: "IntegradoresdoUser",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IntegradoresdoUserTemp_ApplicationUser_UserId",
                table: "IntegradoresdoUserTemp",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntegradoresdoUser_ApplicationUser_UserId",
                table: "IntegradoresdoUser");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegradoresdoUserTemp_ApplicationUser_UserId",
                table: "IntegradoresdoUserTemp");

            migrationBuilder.DropTable(
                name: "UsersDadosConex");

            migrationBuilder.DropIndex(
                name: "IX_IntegradoresdoUserTemp_UserId",
                table: "IntegradoresdoUserTemp");

            migrationBuilder.DropIndex(
                name: "IX_IntegradoresdoUser_UserId",
                table: "IntegradoresdoUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser");

            migrationBuilder.RenameTable(
                name: "ApplicationUser",
                newName: "ApplicationUsers");

            migrationBuilder.RenameColumn(
                name: "IntegUserUser",
                table: "IntegradoresdoUser",
                newName: "PublicKey");

            migrationBuilder.RenameColumn(
                name: "IntegUserPublicKey",
                table: "IntegradoresdoUser",
                newName: "PrivateKey");

            migrationBuilder.RenameColumn(
                name: "IntegUserPrivateKey",
                table: "IntegradoresdoUser",
                newName: "IntegradorNome");

            migrationBuilder.RenameColumn(
                name: "IntegUserPort",
                table: "IntegradoresdoUser",
                newName: "GrupoPort");

            migrationBuilder.RenameColumn(
                name: "IntegUserPass",
                table: "IntegradoresdoUser",
                newName: "GrupoUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "IntegradoresdoUserTemp",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(95)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "IntegradoresdoUserTemp",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "IntegradoresdoUser",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(95)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "GrupoPassword",
                table: "IntegradoresdoUser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "IntegradoresdoUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Integradores",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(95)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserBancoDestino",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserCNPJ",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserHost",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserHostUser",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserNivel",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserNomeEmpresa",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserPort",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserSenha",
                table: "ApplicationUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IntegradoresdoUserTemp_UserId1",
                table: "IntegradoresdoUserTemp",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_IntegradoresdoUser_UserId1",
                table: "IntegradoresdoUser",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Integradores_ApplicationUserId",
                table: "Integradores",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Integradores_ApplicationUsers_ApplicationUserId",
                table: "Integradores",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IntegradoresdoUser_ApplicationUsers_UserId1",
                table: "IntegradoresdoUser",
                column: "UserId1",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IntegradoresdoUserTemp_ApplicationUsers_UserId1",
                table: "IntegradoresdoUserTemp",
                column: "UserId1",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");
        }
    }
}
