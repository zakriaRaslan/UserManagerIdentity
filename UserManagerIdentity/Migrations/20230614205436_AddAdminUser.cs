using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) " +
                "VALUES (N'2a7be9af-19b1-40eb-b113-189f7710ef7e', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAIAAYagAAAAEOOZm5av9+Io4palPyxh4UFqB3t4aAJKtpn9EOXnCtgn56YE9+HnBXsubZ6PSPcv9A==', N'7XQPENDCEDVCZD35U5Z23LAKPMGSVT3B', N'582ebfbe-8d17-4d46-a075-65211b84757d', NULL, 0, 0, NULL, 1, 0, N'Zakaria', N'Raslan', Null)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[users] WHERE Id = '2a7be9af-19b1-40eb-b113-189f7710ef7e'");
        }
    }
}
