using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDemo.Migrations
{
    /// <inheritdoc />
    public partial class v4_addcreatedononstudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Students");
        }
    }
}
