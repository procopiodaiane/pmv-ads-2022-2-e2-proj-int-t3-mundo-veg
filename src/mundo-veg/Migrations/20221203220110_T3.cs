﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mundo_veg.Migrations
{
    public partial class T3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "usuarios_pessoa_juridica");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "usuarios_pessoa_juridica",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
