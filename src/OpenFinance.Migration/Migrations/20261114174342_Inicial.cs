using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenFinance.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "application_user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    login = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    password = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    email = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    admin = table.Column<bool>(type: "boolean", nullable: false),
                    profile_image = table.Column<byte[]>(type: "bytea", nullable: true),
                    enabled = table.Column<bool>(type: "boolean", nullable: false),
                    create_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    system_deleted = table.Column<Guid>(type: "uuid", nullable: true),
                    system_deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "application_settings",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    key = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    value = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    create_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    system_deleted = table.Column<Guid>(type: "uuid", nullable: true),
                    system_deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_settings", x => x.id);
                    table.ForeignKey(
                        name: "FK_application_settings_application_user_user_id",
                        column: x => x.user_id,
                        principalTable: "application_user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_application_settings_key",
                table: "application_settings",
                column: "key");

            migrationBuilder.CreateIndex(
                name: "IX_application_settings_user_id",
                table: "application_settings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_application_user_email",
                table: "application_user",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_application_user_enabled",
                table: "application_user",
                column: "enabled");

            migrationBuilder.CreateIndex(
                name: "IX_application_user_login",
                table: "application_user",
                column: "login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_application_user_name",
                table: "application_user",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application_settings");

            migrationBuilder.DropTable(
                name: "application_user");
        }
    }
}
