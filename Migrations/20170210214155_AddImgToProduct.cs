using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummyBearKingdom.Migrations
{
    public partial class AddImgToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OriginCountry",
                table: "Products",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Products",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "OriginCountry",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "Products",
                nullable: false);
        }
    }
}
