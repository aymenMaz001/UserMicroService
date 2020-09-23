using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Simulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "first_name",
                table: "users");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "users");

            migrationBuilder.AddColumn<DateTime>(
                name: "c_user",
                table: "users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "birthdata",
                table: "information",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "information",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "information",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "information",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "martial_status",
                table: "information",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "simulations",
                columns: table => new
                {
                    SimulationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agent_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    client_id = table.Column<int>(nullable: false),
                    User_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_simulations", x => x.SimulationId);
                    table.ForeignKey(
                        name: "FK_simulations_users_User_fk",
                        column: x => x.User_fk,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 1,
                columns: new[] { "adress", "birthdata", "first_name", "gender", "last_name", "martial_status" },
                values: new object[] { "43 St. Tunis, Tunisa", new DateTime(1986, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agent", "Male", "Agent", "Single" });

            migrationBuilder.UpdateData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 2,
                columns: new[] { "adress", "birthdata", "email", "first_name", "gender", "last_name", "martial_status", "phone_number" },
                values: new object[] { "46  St. Tunis, Tunisia", new DateTime(1977, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "Admin", "Male", "Admin", "Married", "22-666-777" });

            migrationBuilder.InsertData(
                table: "simulations",
                columns: new[] { "SimulationId", "agent_id", "client_id", "product_id", "User_fk" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1 },
                    { 2, 1, 1, 1, 1 },
                    { 3, 1, 1, 1, 1 },
                    { 5, 1, 1, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "c_user",
                value: new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "password", "role", "username", "c_user" },
                values: new object[,]
                {
                    { 3, "agent2", 0, "agent2", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "agent3", 0, "agent3", new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "agent4", 0, "agent4", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "information",
                columns: new[] { "information_id", "adress", "birthdata", "email", "first_name", "gender", "last_name", "martial_status", "phone_number", "UserFK" },
                values: new object[,]
                {
                    { 3, "24  St. Tunis, Tunisia", new DateTime(1990, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "Agent2", "Female", "Agent2", "Married", "22-444-222", 3 },
                    { 4, "27 St. Tunis , Tunisia", new DateTime(1977, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "agent4@agent.com", "Agent3", "Male", "Agent3", "Married", "97-222-333", 4 },
                    { 5, "22 St. Tunis , Tunisia", new DateTime(1992, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "agent4@agent.com", "Agent4", "Female", "Agent4", "Single", "22-222-222", 5 }
                });

            migrationBuilder.InsertData(
                table: "simulations",
                columns: new[] { "SimulationId", "agent_id", "client_id", "product_id", "User_fk" },
                values: new object[,]
                {
                    { 4, 1, 1, 1, 3 },
                    { 6, 1, 1, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_simulations_User_fk",
                table: "simulations",
                column: "User_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "simulations");

            migrationBuilder.DeleteData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "c_user",
                table: "users");

            migrationBuilder.DropColumn(
                name: "birthdata",
                table: "information");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "information");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "information");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "information");

            migrationBuilder.DropColumn(
                name: "martial_status",
                table: "information");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 1,
                column: "adress",
                value: "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM");

            migrationBuilder.UpdateData(
                table: "information",
                keyColumn: "information_id",
                keyValue: 2,
                columns: new[] { "adress", "email", "phone_number" },
                values: new object[] { "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM", "agent@agent.com", "22-222-222" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Agent", "Agent" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Admin", "Admin" });
        }
    }
}
