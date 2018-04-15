using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace wordsapi.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "word",
                columns: table => new
                {
                    wordid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    additional = table.Column<string>(type: "text", maxLength: 128, nullable: true),
                    back = table.Column<string>(type: "text", maxLength: 128, nullable: false),
                    front = table.Column<string>(type: "text", maxLength: 128, nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_word", x => x.wordid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "word");
        }
    }
}
