using System.ComponentModel.DataAnnotations;

namespace Slando_Olx.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [MinLength(3)]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        public string City { get; set; }
        [StringLength(1000, MinimumLength = 10)]
        public string Description { get; set; }
        public string ContactInformation { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Ціна повинна бути більше нуля!")]
        public double Price { get; set; }
        public string? Image { get; set; }
        public bool InStock { get; set; }
        public Product(int id, string title, string cat, string city, string desc, string contactinf, double price, string image, bool ins)
        {
            Id = id;
            Title = title;
            Category = cat;
            City = city;
            Description = desc;
            ContactInformation = contactinf;
            Price = price;
            Image = image;
            InStock = ins;
        }
        public Product()
        {
            Id = int.MaxValue;
            Title = "NoTitle";
            Category = "NoCategory";
            City = "NoCity";
            Description = "NoDescription";
            ContactInformation = "NoContactInformation";
            Price = 1;
            Image = "https://tengrinews.kz/userdata/news/2022/news_477258/resize/photo_406203.jpeg";
            InStock = false;
        }
    }
}
