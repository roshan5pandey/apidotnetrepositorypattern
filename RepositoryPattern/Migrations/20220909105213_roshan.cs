using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryPattern.Migrations
{
    public partial class roshan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Date_Of_Joining", "EmployeeName", "Salary" },
                values: new object[] { 1, "999-888-7777", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), "Uncle", 12000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Date_Of_Joining", "EmployeeName", "Salary" },
                values: new object[] { 2, "999-888-7777", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), "Raja", 12000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);
        }
    }
}
