using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.ViewModels.ProductManagementViewModels.Response
{
    public class ResponseGetCategoriesViewModel
    {
        public List<ResponseGetCategoriesViewModelItem> Categories { get; set; }

        public ResponseGetCategoriesViewModel()
        {
            Categories = new List<ResponseGetCategoriesViewModelItem>();
        }
    }

    public class ResponseGetCategoriesViewModelItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
