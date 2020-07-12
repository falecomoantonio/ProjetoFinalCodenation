using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;

namespace DBManager.Migrations
{
    public partial class CreateTableUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) =>
            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false, maxLength: 50),
                    Email = table.Column<string>(nullable: false, maxLength: 120),
                    Nickname = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false, maxLength: 512),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table => table.PrimaryKey("PK_User", a => a.Id)
            );

        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.DropTable(name: "Users");
    }
}
