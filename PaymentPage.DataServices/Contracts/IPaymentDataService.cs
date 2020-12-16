using PaymentPage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPage.DataServices.Contracts
{
    public interface IPaymentDataService
    {
        Task<List<PaymentDetail>> GetPaymentDetails();
        Task<bool> AddPaymentDetails(PaymentDetail paymentDetail);
    }
}
