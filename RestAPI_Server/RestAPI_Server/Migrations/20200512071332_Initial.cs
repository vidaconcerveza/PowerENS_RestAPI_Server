using Microsoft.EntityFrameworkCore.Migrations;

namespace RestAPI_Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogTime = table.Column<string>(nullable: true),
                    AlarmMessage = table.Column<string>(nullable: true),
                    Val01 = table.Column<double>(nullable: false),
                    Val02 = table.Column<double>(nullable: false),
                    Val03 = table.Column<double>(nullable: false),
                    Val04 = table.Column<double>(nullable: false),
                    Val05 = table.Column<double>(nullable: false),
                    Val06 = table.Column<double>(nullable: false),
                    Val07 = table.Column<double>(nullable: false),
                    Val08 = table.Column<double>(nullable: false),
                    Val09 = table.Column<double>(nullable: false),
                    Val10 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Charts");
        }
    }
}
