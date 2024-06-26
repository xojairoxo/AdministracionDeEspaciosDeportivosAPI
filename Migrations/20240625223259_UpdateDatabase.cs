using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsFacilityManagementAPI.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_EspacioDeportivo_EspacioDeportivoId",
                table: "Reservaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EspacioDeportivo",
                table: "EspacioDeportivo");

            migrationBuilder.RenameTable(
                name: "EspacioDeportivo",
                newName: "EspaciosDeportivos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EspaciosDeportivos",
                newName: "Capacidad");

            migrationBuilder.AlterColumn<int>(
                name: "Capacidad",
                table: "EspaciosDeportivos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "EspaciosDeportivosId",
                table: "EspaciosDeportivos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EspaciosDeportivos",
                table: "EspaciosDeportivos",
                column: "EspaciosDeportivosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_EspaciosDeportivos_EspacioDeportivoId",
                table: "Reservaciones",
                column: "EspacioDeportivoId",
                principalTable: "EspaciosDeportivos",
                principalColumn: "EspaciosDeportivosId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_EspaciosDeportivos_EspacioDeportivoId",
                table: "Reservaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EspaciosDeportivos",
                table: "EspaciosDeportivos");

            migrationBuilder.DropColumn(
                name: "EspaciosDeportivosId",
                table: "EspaciosDeportivos");

            migrationBuilder.RenameTable(
                name: "EspaciosDeportivos",
                newName: "EspacioDeportivo");

            migrationBuilder.RenameColumn(
                name: "Capacidad",
                table: "EspacioDeportivo",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "EspacioDeportivo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EspacioDeportivo",
                table: "EspacioDeportivo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_EspacioDeportivo_EspacioDeportivoId",
                table: "Reservaciones",
                column: "EspacioDeportivoId",
                principalTable: "EspacioDeportivo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
