using PaymentPage.BusinessServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPage.BusinessServices.Contracts
{
    public interface IPaymentService
    {
        Task<List<PaymentDetailDto>> GetPaymentDetails();
        Task<bool> AddPaymentDetails(PaymentDetailDto detailDto);
    }
}
