using Microsoft.EntityFrameworkCore.Migrations;

namespace senac_sjrp.Migrations
{
    public partial class AddNewColumnDiscountOnTablePie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "TBL_TORTA",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "TBL_TORTA");
        }
    }
}
