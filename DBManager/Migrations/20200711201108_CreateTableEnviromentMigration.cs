﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBManager.Migrations
{
    public partial class CreateTableEnviromentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) =>
            migrationBuilder.CreateTable(
                name: "Enviroments",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false, maxLength: 100),
                    Description = table.Column<string>(nullable: false, maxLength: 500),
                },
                constraints: table => table.PrimaryKey("PK_Enviroment", a => a.Id)
            );

        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.DropTable(name: "Enviroments");
    }
}
