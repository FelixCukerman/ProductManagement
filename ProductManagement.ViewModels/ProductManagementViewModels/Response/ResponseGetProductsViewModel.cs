using System.Collections.Generic;

namespace ProductManagement.ViewModels.ProductManagementViewModels.Response
{
    public class ResponseGetProductsViewModel
    {
        public List<ResponseGetProductsViewModelItem> Data { get; set; }
        public int TotalCount { get; set; }

        public ResponseGetProductsViewModel()
        {
            Data = new List<ResponseGetProductsViewModelItem>();
        }
    }

    public class ResponseGetProductsViewModelItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryType { get; set; }
    }
}
