using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modulearn.Migrations
{
    /// <inheritdoc />
    public partial class asp_rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("AspNetRoleClaims", newName:"RoleClaims");
            migrationBuilder.RenameTable("AspNetRoles", newName: "Roles");
            migrationBuilder.RenameTable("AspNetUserClaims", newName: "UserClaims");
            migrationBuilder.RenameTable("AspNetUserLogins", newName: "UserLogins");
            migrationBuilder.RenameTable("AspNetUserRoles", newName: "UserRoles");
            migrationBuilder.RenameTable("AspNetUsers", newName: "Users");
            migrationBuilder.RenameTable("AspNetUserTokens", newName: "UserTokens");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("RoleClaims", newName: "AspNetRoleClaims");
            migrationBuilder.RenameTable("Roles", newName: "AspNetRoles");
            migrationBuilder.RenameTable("UserClaims", newName: "AspNetUserClaims");
            migrationBuilder.RenameTable("UserLogins", newName: "AspNetUserLogins");
            migrationBuilder.RenameTable("UserRoles", newName: "AspNetUserRoles");
            migrationBuilder.RenameTable("Users", newName: "AspNetUsers");
            migrationBuilder.RenameTable("UserTokens", newName: "AspNetUserTokens");
        }
    }
}
