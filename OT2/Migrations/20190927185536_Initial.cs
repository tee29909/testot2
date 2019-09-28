using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OT2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    EmpID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Addr = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    DepartmentName = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: true),
                    EmployeeTypeID = table.Column<string>(nullable: true),
                    PositionID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.EmpID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emp");
        }
    }
}
