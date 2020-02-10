using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.DataAccept
{
    public class ApplicationDbInitializer
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ApplicationDbInitializer(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task Initialize()
        {
            int categoriesCount = await _categoryRepository.GetCount();
            if (categoriesCount == default(int))
            {
                await InitializeCategories();
            }

            int productCount = await _productRepository.GetCount();
            if (productCount == default(int))
            {
                await InitializeProducts();
            }
        }

        public async Task InitializeCategories()
        {
            var categoriesToCreate = new List<Category>();

            categoriesToCreate.Add(new Category { Name = "Sweets" });
            categoriesToCreate.Add(new Category { Name = "Drinks" });
            categoriesToCreate.Add(new Category { Name = "Equipments" });
            categoriesToCreate.Add(new Category { Name = "Glasses" });

            await _categoryRepository.InsertRange(categoriesToCreate);
        }

        public async Task InitializeProducts()
        {
            var productsToCreate = new List<Product>();

            productsToCreate.Add(new Product { Name = "Milk slice", CategoryId = 1 });
            productsToCreate.Add(new Product { Name = "Coca Cola", CategoryId = 2 });
            productsToCreate.Add(new Product { Name = "MP3-Player Sony Walkman NW-A55", CategoryId = 3 });
            productsToCreate.Add(new Product { Name = "Gucci Eyewear", CategoryId = 4 });

            await _productRepository.InsertRange(productsToCreate);
        }
    }
}
