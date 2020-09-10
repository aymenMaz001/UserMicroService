using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "information",
                columns: table => new
                {
                    information_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(nullable: true),
                    adress = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    UserFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_information", x => x.information_id);
                    table.ForeignKey(
                        name: "FK_information_users_UserFK",
                        column: x => x.UserFK,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "first_name", "last_name", "password", "role", "username" },
                values: new object[] { 1, "Agent", "Agent", "agent", 0, "agent" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "first_name", "last_name", "password", "role", "username" },
                values: new object[] { 2, "Admin", "Admin", "admin", 1, "admin" });

            migrationBuilder.InsertData(
                table: "information",
                columns: new[] { "information_id", "adress", "email", "phone_number", "UserFK" },
                values: new object[] { 1, "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM", "agent@agent.com", "22-222-222", 1 });

            migrationBuilder.InsertData(
                table: "information",
                columns: new[] { "information_id", "adress", "email", "phone_number", "UserFK" },
                values: new object[] { 2, "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM", "agent@agent.com", "22-222-222", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_information_UserFK",
                table: "information",
                column: "UserFK",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "information");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
