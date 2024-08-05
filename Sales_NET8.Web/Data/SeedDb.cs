using Sales_NET8.Web.Data.Entities;

namespace Sales_NET8.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)

        {
            _context = context;
        }

        public async Task SeedAsync()

        { 
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Countries.Any())

            {
                AddCountry("Argentina");

                AddCountry("Colombia");

                AddCountry("Perú");

                AddCountry("Venezuela");

                await _context.SaveChangesAsync();
            }

            if (!_context.Categories.Any())

            {
                AddCategory("Cat. 1");

                AddCategory("Cat. 2");

                AddCategory("Cat. 3");

                AddCategory("Cat. 4");

                await _context.SaveChangesAsync();
            }
        }

        private void AddCountry(string name)

        {
            _context.Countries.Add(new Country

            {
                Name = name
            });
        }

        private void AddCategory(string name)
        {
            _context.Categories.Add(new Category

            {
                Name = name
            });
        }
    }
}
