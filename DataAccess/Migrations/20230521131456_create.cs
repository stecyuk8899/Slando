using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "City", "ContactInformation", "Description", "Image", "InStock", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Electronics", "Kyiv", "Contact phone : 0123987509", "Xiaomi Redmi Note 10 Pro 6/128Gb Onyx Gray", "https://scdn.comfy.ua/89fc351a-22e7-41ee-8321-f8a9356ca351/https://cdn.comfy.ua/media/catalog/product/x/i/xiaomi_redmi_note_10_pro_onyx_gray_2.png/f_auto", true, 300.0, "Xiaomi Redmi Note 10 Pro" },
                    { 2, "Clothes", "Dnipro", "Contact email : super123@gmail.com", "ФУТБОЛКА NIKE SOLE FOOD TEE BLACK DM2279-010", "https://werare.com.ua/image/cache/webp/catalog/i/bf/nc/d74da46b40f6d40712aaa3d0eec13019-890x1000.webp", true, 100.2, "NIKE SOLE FOOD TEE BLACK" },
                    { 3, "Clothes", "Poltava", "Card bank Monobank : 7777-7777-7777-7777", "Чоловічі джинси Boss Синій (2048)", "https://kasta.ua/image/1035/s3/c/d9/1fc/7563772/20909940/20909940_retouched.jpeg", true, 200.5, "Jeans" },
                    { 4, "Stationery", "Rivne", "Epicenter", "Набір ручок кулькових BIC Round Stick 8 шт. сині", "https://cdn.27.ua/799/13/f5/332789_9.jpeg", true, 1.75, "Pens" },
                    { 5, "Electronics", "Mykolaiv", "ROZETKA", "Телевізор Samsung UE65AU7100UXUA", "https://content2.rozetka.com.ua/goods/images/big/303985217.jpg", true, 1000.0, "TV Samsung" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
