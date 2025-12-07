using Mvc.Shopping.Client.Models;

namespace Mvc.Shopping.Client.Datas
{
    public class ProductContext
    {
        public static readonly List<Product> Products = new ()
        {
            new() {
                    Name = "Casque Bluetooth Sony WH-1000XM5",
                    Category = "Audio",
                    Description = "Casque Bluetooth avec réduction de bruit active, autonomie 30h.",
                    ImageFile = "sony_wh1000xm5.jpg",
                    Price = 499.99m
                },
            new ()
                {
                    Name = "iPhone 15 Pro Max",
                    Category = "Smartphone",
                    Description = "Smartphone haut de gamme avec puce A17 Pro et triple caméra.",
                    ImageFile = "iphone15promax.png",
                    Price = 1599.00m
                },
            new ()
                {
                    Name = "Aspirateur Dyson V15",
                    Category = "Maison",
                    Description = "Aspirateur sans fil avec détection automatique de poussière.",
                    ImageFile = "dyson_v15.jpg",
                    Price = 899.00m
                },
            new ()
            {
                Name = "Télévision Samsung OLED 55”",
                Category = "TV",
                Description = "Téléviseur OLED UHD 4K avec HDR10+ et mode gaming.",
                ImageFile = "samsung_oled55.jpg",
                Price = 1699.99m
            }
        };
    }
}
