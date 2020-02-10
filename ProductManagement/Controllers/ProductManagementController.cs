using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.BusinessLogic.Services.Interfaces;
using ProductManagement.ViewModels.ProductManagementViewModels.Request;
using ProductManagement.ViewModels.ProductManagementViewModels.Response;

namespace ProductManagement.Controllers
{
    [Route("api/productmanagement")]
    public class ProductManagementController : Controller
    {
        private readonly IProductManagementService _productManagementService;

        public ProductManagementController(IProductManagementService productManagementService)
        {
            _productManagementService = productManagementService;
        }

        [HttpPost]
        [Route("list")]
        public async Task<ResponseGetProductsViewModel> GetProducts([FromBody]RequestGetProductsViewModel request)
        {
            ResponseGetProductsViewModel response = await _productManagementService.GetProducts(request);

            return response;
        }
        
        [HttpPost]
        [Route("create")]
        public async Task<ResponseGetProductsViewModelItem> CreateProduct([FromBody]RequestCreateProductViewModel request)
        {
            ResponseGetProductsViewModelItem response = await _productManagementService.CreateProduct(request);

            return response;
        }

        [HttpGet]
        [Route("categories")]
        public async Task<ResponseGetCategoriesViewModel> GetCategories()
        {
            ResponseGetCategoriesViewModel response = await _productManagementService.GetCategories();

            return response;
        }
    }
}
