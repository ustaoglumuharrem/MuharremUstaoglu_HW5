using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MuharremUstaoglu_HW5.Migrations
{
    public partial class dsfsdfls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CetUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CetUsers",
                columns: new[] { "Id", "CreatedDate", "Name", "Password", "Role", "Surname", "UserName" },
                values: new object[] { 1, new DateTime(2019, 11, 27, 21, 44, 26, 349, DateTimeKind.Local).AddTicks(3918), "Muharrem", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", "Admin", "Ustaoğlu", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CetUsers");
        }
    }
}
