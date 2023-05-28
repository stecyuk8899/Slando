using Microsoft.EntityFrameworkCore;
using Slando_Olx.Entities;

namespace WorkData.DB
{
    public class SlandoDbContext : DbContext
    {
        public SlandoDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product(1, "Xiaomi Redmi Note 10 Pro", "Electronics", "Kyiv", "Xiaomi Redmi Note 10 Pro 6/128Gb Onyx Gray", "Contact phone : 0123987509", 300, "https://scdn.comfy.ua/89fc351a-22e7-41ee-8321-f8a9356ca351/https://cdn.comfy.ua/media/catalog/product/x/i/xiaomi_redmi_note_10_pro_onyx_gray_2.png/f_auto", true),
                new Product(2, "NIKE SOLE FOOD TEE BLACK", "Clothes", "Dnipro", "ФУТБОЛКА NIKE SOLE FOOD TEE BLACK DM2279-010", "Contact email : super123@gmail.com", 100.20, "https://werare.com.ua/image/cache/webp/catalog/i/bf/nc/d74da46b40f6d40712aaa3d0eec13019-890x1000.webp", true),
                new Product(3, "Jeans", "Clothes", "Poltava", "Чоловічі джинси Boss Синій (2048)", "Card bank Monobank : 7777-7777-7777-7777", 200.5, "https://kasta.ua/image/1035/s3/c/d9/1fc/7563772/20909940/20909940_retouched.jpeg", true),
                new Product(4, "Pens", "Stationery", "Rivne", "Набір ручок кулькових BIC Round Stick 8 шт. сині", "Epicenter", 1.75, "https://cdn.27.ua/799/13/f5/332789_9.jpeg", true),
                new Product(5, "TV Samsung", "Electronics", "Mykolaiv", "Телевізор Samsung UE65AU7100UXUA", "ROZETKA", 1000, "https://content2.rozetka.com.ua/goods/images/big/303985217.jpg", true)
            });
        }
        public DbSet<Product> Products { get; set; }
    }
}
