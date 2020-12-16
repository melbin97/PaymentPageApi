using Microsoft.Extensions.DependencyInjection;
using PaymentPage.BusinessServices.Contracts;
using PaymentPage.BusinessServices.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPage.BusinessServices
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            return services; ;

        }
    }
}
