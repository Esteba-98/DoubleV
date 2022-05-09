using Business;
using Data;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            //services.AddTransient<IContextDB, ContextDB>();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IMovimiento, MovimientoBusiness>();
            //services.AddTransient<IProducto, ProductoBusiness>();
            //services.AddTransient<IProveedor, ProveedorBusiness>();
            //services.AddTransient<IStock, StockBusiness>();
            return services;
        }
    }
}
