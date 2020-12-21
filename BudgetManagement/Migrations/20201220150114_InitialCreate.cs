using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicatonDbContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Legder",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransType = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legder", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "UserCategoryBudget",
                columns: table => new
                {
                    UserCategoryBudgetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(maxLength: 250, nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    Budget = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategoryBudget", x => x.UserCategoryBudgetID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LedgerItemID = table.Column<int>(nullable: true),
                    UserCategoryBudgetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Category_Legder_LedgerItemID",
                        column: x => x.LedgerItemID,
                        principalTable: "Legder",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_UserCategoryBudget_UserCategoryBudgetID",
                        column: x => x.UserCategoryBudgetID,
                        principalTable: "UserCategoryBudget",
                        principalColumn: "UserCategoryBudgetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UsersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    UserCategoryBudgetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UsersID);
                    table.ForeignKey(
                        name: "FK_User_UserCategoryBudget_UserCategoryBudgetID",
                        column: x => x.UserCategoryBudgetID,
                        principalTable: "UserCategoryBudget",
                        principalColumn: "UserCategoryBudgetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    InitialBalance = table.Column<decimal>(nullable: false),
                    LedgerItemID = table.Column<int>(nullable: true),
                    UsersID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Account_Legder_LedgerItemID",
                        column: x => x.LedgerItemID,
                        principalTable: "Legder",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_User_UsersID",
                        column: x => x.UsersID,
                        principalTable: "User",
                        principalColumn: "UsersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_LedgerItemID",
                table: "Account",
                column: "LedgerItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_UsersID",
                table: "Account",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_LedgerItemID",
                table: "Category",
                column: "LedgerItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_UserCategoryBudgetID",
                table: "Category",
                column: "UserCategoryBudgetID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserCategoryBudgetID",
                table: "User",
                column: "UserCategoryBudgetID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Legder");

            migrationBuilder.DropTable(
                name: "UserCategoryBudget");
        }
    }
}
