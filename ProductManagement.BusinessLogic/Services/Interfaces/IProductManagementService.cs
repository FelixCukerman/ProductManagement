using ProductManagement.ViewModels.ProductManagementViewModels.Request;
using ProductManagement.ViewModels.ProductManagementViewModels.Response;
using System.Threading.Tasks;

namespace ProductManagement.BusinessLogic.Services.Interfaces
{
    public interface IProductManagementService
    {
        Task<ResponseGetProductsViewModel> GetProducts(RequestGetProductsViewModel requestViewModel);
        Task<ResponseGetProductsViewModelItem> CreateProduct(RequestCreateProductViewModel requestViewModel);
        Task<ResponseGetCategoriesViewModel> GetCategories();
    }
}
