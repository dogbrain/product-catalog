using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using product_catalog.Models;

namespace product_catalog.Providers
{
    public class ProductProviderFake : IProductProvider
    {       
        private readonly Product[] products = {
            new Product
            {
                Id=1,
                Name="Nokia 3310",
                Description="Lorem ipsum dolor sit amet, doctus mandamus cu ius, alia utroque sit an, id perpetua.",
                DetailedDescription=@"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Curabitur vitae diam non enim vestibulum interdum. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ac dolor sit amet purus malesuada congue. Integer pellentesque quam vel velit. Aliquam ante. Mauris dictum facilisis augue. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer malesuada. Quisque porta. Integer vulputate sem a nibh rutrum consequat. Aliquam id dolor. Maecenas lorem. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Maecenas lorem.

Sed ac dolor sit amet purus malesuada congue. Fusce wisi. Donec quis nibh at felis congue commodo. Nunc auctor. Aliquam erat volutpat. Aliquam erat volutpat. Nunc dapibus tortor vel mi dapibus sollicitudin. Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo. Praesent dapibus. Aliquam ante. Aenean vel massa quis mauris vehicula lacinia.

Sed ac dolor sit amet purus malesuada congue. Fusce suscipit libero eget elit. Fusce tellus. Pellentesque sapien. Praesent dapibus. Phasellus enim erat, vestibulum vel, aliquam a, posuere eu, velit. In enim a arcu imperdiet malesuada. In laoreet, magna id viverra tincidunt, sem odio bibendum justo, vel imperdiet sapien wisi sed libero. Sed convallis magna eu sem. Etiam commodo dui eget wisi. Integer vulputate sem a nibh rutrum consequat. Duis pulvinar. Nunc dapibus tortor vel mi dapibus sollicitudin. In enim a arcu imperdiet malesuada. Integer in sapien. Mauris metus. Etiam ligula pede, sagittis quis, interdum ultricies, scelerisque eu.",
                FullPrice=new decimal(500.50),
                DiscountedPrice=new decimal(450),
                ImageUrl="https://dustinweb.azureedge.net/image/276828/400/320/nokia-3310-dual-sim-morkbla.jpg"

            },
            new Product
            {
                Id=2,
                Name="Nokia 130",
                Description="Lorem ipsum dolor sit amet, doctus mandamus cu ius, alia utroque sit an, id perpetua.",
                DetailedDescription=@"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Curabitur vitae diam non enim vestibulum interdum. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ac dolor sit amet purus malesuada congue. Integer pellentesque quam vel velit. Aliquam ante. Mauris dictum facilisis augue. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer malesuada. Quisque porta. Integer vulputate sem a nibh rutrum consequat. Aliquam id dolor. Maecenas lorem. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Maecenas lorem.

Sed ac dolor sit amet purus malesuada congue. Fusce wisi. Donec quis nibh at felis congue commodo. Nunc auctor. Aliquam erat volutpat. Aliquam erat volutpat. Nunc dapibus tortor vel mi dapibus sollicitudin. Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo. Praesent dapibus. Aliquam ante. Aenean vel massa quis mauris vehicula lacinia.

Sed ac dolor sit amet purus malesuada congue. Fusce suscipit libero eget elit. Fusce tellus. Pellentesque sapien. Praesent dapibus. Phasellus enim erat, vestibulum vel, aliquam a, posuere eu, velit. In enim a arcu imperdiet malesuada. In laoreet, magna id viverra tincidunt, sem odio bibendum justo, vel imperdiet sapien wisi sed libero. Sed convallis magna eu sem. Etiam commodo dui eget wisi. Integer vulputate sem a nibh rutrum consequat. Duis pulvinar. Nunc dapibus tortor vel mi dapibus sollicitudin. In enim a arcu imperdiet malesuada. Integer in sapien. Mauris metus. Etiam ligula pede, sagittis quis, interdum ultricies, scelerisque eu.",
                FullPrice=new decimal(600.56),
                DiscountedPrice=new decimal(550),
                ImageUrl="https://dustinweb.azureedge.net/image/405085/400/320/nokia-130-dual-sim-rod.jpg"
            },
            new Product
            {
                Id=1,
                Name="Nokia 8810",
                Description="Lorem ipsum dolor sit amet, doctus mandamus cu ius, alia utroque sit an, id perpetua.",
                DetailedDescription=@"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Curabitur vitae diam non enim vestibulum interdum. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ac dolor sit amet purus malesuada congue. Integer pellentesque quam vel velit. Aliquam ante. Mauris dictum facilisis augue. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer malesuada. Quisque porta. Integer vulputate sem a nibh rutrum consequat. Aliquam id dolor. Maecenas lorem. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Maecenas lorem.

Sed ac dolor sit amet purus malesuada congue. Fusce wisi. Donec quis nibh at felis congue commodo. Nunc auctor. Aliquam erat volutpat. Aliquam erat volutpat. Nunc dapibus tortor vel mi dapibus sollicitudin. Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo. Praesent dapibus. Aliquam ante. Aenean vel massa quis mauris vehicula lacinia.

Sed ac dolor sit amet purus malesuada congue. Fusce suscipit libero eget elit. Fusce tellus. Pellentesque sapien. Praesent dapibus. Phasellus enim erat, vestibulum vel, aliquam a, posuere eu, velit. In enim a arcu imperdiet malesuada. In laoreet, magna id viverra tincidunt, sem odio bibendum justo, vel imperdiet sapien wisi sed libero. Sed convallis magna eu sem. Etiam commodo dui eget wisi. Integer vulputate sem a nibh rutrum consequat. Duis pulvinar. Nunc dapibus tortor vel mi dapibus sollicitudin. In enim a arcu imperdiet malesuada. Integer in sapien. Mauris metus. Etiam ligula pede, sagittis quis, interdum ultricies, scelerisque eu.",
                FullPrice=new decimal(1000.00),
                DiscountedPrice=new decimal(900),
                ImageUrl="https://dustinweb.azureedge.net/image/369858/400/320/nokia-8110-4g-dual-sim-svart.jpg"

            },
            new Product
            {
                Id=1,
                Name="Nokia 105",
                Description="Lorem ipsum dolor sit amet, doctus mandamus cu ius, alia utroque sit an, id perpetua.",
                DetailedDescription=@"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Curabitur vitae diam non enim vestibulum interdum. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ac dolor sit amet purus malesuada congue. Integer pellentesque quam vel velit. Aliquam ante. Mauris dictum facilisis augue. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer malesuada. Quisque porta. Integer vulputate sem a nibh rutrum consequat. Aliquam id dolor. Maecenas lorem. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Maecenas lorem.

Sed ac dolor sit amet purus malesuada congue. Fusce wisi. Donec quis nibh at felis congue commodo. Nunc auctor. Aliquam erat volutpat. Aliquam erat volutpat. Nunc dapibus tortor vel mi dapibus sollicitudin. Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo. Praesent dapibus. Aliquam ante. Aenean vel massa quis mauris vehicula lacinia.

Sed ac dolor sit amet purus malesuada congue. Fusce suscipit libero eget elit. Fusce tellus. Pellentesque sapien. Praesent dapibus. Phasellus enim erat, vestibulum vel, aliquam a, posuere eu, velit. In enim a arcu imperdiet malesuada. In laoreet, magna id viverra tincidunt, sem odio bibendum justo, vel imperdiet sapien wisi sed libero. Sed convallis magna eu sem. Etiam commodo dui eget wisi. Integer vulputate sem a nibh rutrum consequat. Duis pulvinar. Nunc dapibus tortor vel mi dapibus sollicitudin. In enim a arcu imperdiet malesuada. Integer in sapien. Mauris metus. Etiam ligula pede, sagittis quis, interdum ultricies, scelerisque eu.",
                FullPrice=new decimal(1500.00),
                DiscountedPrice=new decimal(1250),
                ImageUrl="https://dustinweb.azureedge.net/image/307056/400/320/nokia-105-dual-sim-bla.jpg"
            },

        };

        public Task<IEnumerable<Product>> GetProducts()
        {
            return Task.FromResult(this.products.AsEnumerable<Product>());
        }
    }
}
