using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.BusinessLogic.Services;
using ProductManagement.BusinessLogic.Services.Interfaces;
using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Models.RequestModels;
using ProductManagement.DataAccess.Repositories;
using ProductManagement.DataAccess.Repositories.Interfaces;
using ProductManagement.ViewModels.ProductManagementViewModels.Request;
using ProductManagement.ViewModels.ProductManagementViewModels.Response;
using System.Collections.Generic;

namespace ProductManagement.BusinessLogic.Configs
{
    public static class DependenciesConfig
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IProductManagementService, ProductManagementService>();

            IMapper mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<RequestGetProductsViewModel, RequestGetProductsModel>();

                config.CreateMap<Product, ResponseGetProductsViewModelItem>();

                config.CreateMap<RequestCreateProductViewModel, Product>();

                config.CreateMap<Category, ResponseGetCategoriesViewModelItem>();
            })
            .CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}