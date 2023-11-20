using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_RBAC.Migrations
{
    /// <inheritdoc />
    public partial class InitialPCCells : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerformanceCellsUpdated",
                columns: table => new
                {
                    PCKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceCell = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    SubPerformanceCell = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    SubSubPerformanceCell = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Division = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Subdivision = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Department = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Partner = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Class = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Scheme = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Company = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    BusinessUnit = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Years = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Splits = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedUser = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SubDivisionExclude = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DepartmentExclude = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PartnerExclude = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ClassExclude = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SchemeExclude = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceCellsUpdated", x => x.PCKey);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerformanceCellsUpdated");
        }
    }
}
