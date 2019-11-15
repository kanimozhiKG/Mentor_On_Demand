using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnApiUsingEF.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Did = table.Column<string>(nullable: false),
                    DeptName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Eid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(maxLength: 20, nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: true),
                    Desig = table.Column<string>(maxLength: 30, nullable: true),
                    Sal = table.Column<double>(nullable: true),
                    Did = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employee_Department_Did",
                        column: x => x.Did,
                        principalTable: "Department",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Did",
                table: "Employee",
                column: "Did");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
