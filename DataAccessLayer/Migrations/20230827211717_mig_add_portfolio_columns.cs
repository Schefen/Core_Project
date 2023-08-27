using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_portfolio_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PortfolioImage1",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImage2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImage3",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImage4",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPlatform",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPrice",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioRatio",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PortfolioStatus",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortfolioImage1",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImage2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImage3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImage4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioPlatform",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioPrice",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioRatio",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioStatus",
                table: "Portfolios");
        }
    }
}
