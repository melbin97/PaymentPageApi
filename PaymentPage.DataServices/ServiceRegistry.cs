using Microsoft.Extensions.DependencyInjection;
using PaymentPage.DataServices.Contracts;
using PaymentPage.DataServices.Impl;

namespace PaymentPage.DataServices
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentDataService, PaymentDataService>();
            return services;
        }
    }
}
