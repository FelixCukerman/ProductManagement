using AutoMapper;
using ProductManagement.BusinessLogic.Services.Interfaces;
using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Models.RequestModels;
using ProductManagement.DataAccess.Repositories.Interfaces;
using ProductManagement.ViewModels.ProductManagementViewModels.Request;
using ProductManagement.ViewModels.ProductManagementViewModels.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.BusinessLogic.Services
{
    public class ProductManagementService : IProductManagementService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductManagementService(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        #region Public Methods
        public async Task<ResponseGetProductsViewModel> GetProducts(RequestGetProductsViewModel requestViewModel)
        {
            RequestGetProductsModel requestModel = _mapper.Map<RequestGetProductsModel>(requestViewModel);

            List<Product> products = await _productRepository.GetByRequest(requestModel);
            IEnumerable<int> categoriesIds = products.Select(product => product.CategoryId).Distinct();

            List<Category> categories = await _categoryRepository.GetByIds(categoriesIds);

            var response = new ResponseGetProductsViewModel();

            response.Data = _mapper.Map<List<ResponseGetProductsViewModelItem>>(products);
            response.TotalCount = await _productRepository.GetCount();

            MapCategoriesNamesToProducts(response, categories);

            return response;
        }

        public async Task<ResponseGetProductsViewModelItem> CreateProduct(RequestCreateProductViewModel requestViewModel)
        {
            Product product = _mapper.Map<Product>(requestViewModel);

            product.Id = await _productRepository.InsertAndReturnId(product);

            ResponseGetProductsViewModelItem result = _mapper.Map<ResponseGetProductsViewModelItem>(product);

            result.CategoryType = await _categoryRepository.GetNameById(result.CategoryId);

            return result;
        }

        public async Task<ResponseGetCategoriesViewModel> GetCategories()
        {
            List<Category> categories = await _categoryRepository.GetAll();

            var response = new ResponseGetCategoriesViewModel();

            response.Categories = _mapper.Map<List<ResponseGetCategoriesViewModelItem>>(categories);

            return response;
        }
        #endregion

        #region Private Methods
        private void MapCategoriesNamesToProducts(ResponseGetProductsViewModel response, List<Category> categories)
        {
            foreach(ResponseGetProductsViewModelItem item in response.Data)
            {
                Category currentCategory = categories.FirstOrDefault(category => category.Id == item.CategoryId);

                if(currentCategory == null)
                {
                    continue;
                }

                item.CategoryType = currentCategory.Name;
            }
        }
        #endregion
    }
}
