using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Migrations
{
    /// <inheritdoc />
    public partial class AssignAdminUserToAllRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into[security].[UserRoles](UserId, RoleId) select '2a7be9af-19b1-40eb-b113-189f7710ef7e', Id From[security].[Roles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From [security].[UserRoles] where UserId='2a7be9af-19b1-40eb-b113-189f7710ef7e'");
        }
    }
}
