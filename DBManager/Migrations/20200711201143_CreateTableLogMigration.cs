using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DBManager.Migrations
{
    public partial class CreateTableLogMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) =>
            migrationBuilder.CreateTable(
                name: "Logs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable:false, maxLength:500),
                    Content = table.Column<string>(nullable:false),
                    Address = table.Column<string>(nullable:false),
                    Level = table.Column<long>(nullable:false),
                    Enviroment = table.Column<long>(nullable:false),
                    User = table.Column<long>(nullable:false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table => {
                    table.PrimaryKey("PK_Log", a => a.Id);
                    table.ForeignKey("FK_Log_Level_REL", a => a.Level, "Levels", "Id", "dbo");
                    table.ForeignKey("FK_Log_Enviroment_REL", a => a.Level, "Enviroments", "Id", "dbo");
                }
            );

        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.DropTable(name: "Logs");
    }
}
