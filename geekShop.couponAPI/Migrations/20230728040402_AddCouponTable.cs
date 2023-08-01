using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace geekShop.couponAPI.Migrations
{
    public partial class AddCouponTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coupon",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    coupon_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    discount_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupon", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "coupon_code", "discount_amount" },
                values: new object[] { new Guid("48eed4af-2110-46bd-97f2-b5fc3b8b7501"), "ERUDIO_2022_15", 15m });

            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "coupon_code", "discount_amount" },
                values: new object[] { new Guid("91b6b9cc-9807-4226-a29a-9e8734f0d062"), "ERUDIO_2022_10", 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coupon");
        }
    }
}
