using PaymentPage.BusinessServices.Contracts;
using PaymentPage.BusinessServices.Dtos;
using PaymentPage.Data;
using PaymentPage.DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPage.BusinessServices.Impl
{
    public class PaymentService:IPaymentService
    {
        private readonly IPaymentDataService paymentDataService;
        public PaymentService(IPaymentDataService paymentDataService)
        {
            this.paymentDataService = paymentDataService;
        }
        public async Task<List<PaymentDetailDto>> GetPaymentDetails()
        {
            List<PaymentDetail> paymentDetails = await paymentDataService.GetPaymentDetails();
            List<PaymentDetailDto> paymentDetailDtos = paymentDetails.Select(p => new PaymentDetailDto()
            { Id = p.Id, CardNumber = p.CardNumber, CardOwnerName = p.CardOwnerName, Cvv = p.Cvv, ExpirationDate = p.ExpirationDate }).ToList();
            return paymentDetailDtos;
        }

        public async Task<bool> AddPaymentDetails(PaymentDetailDto detailDto)
        {
            PaymentDetail paymentDetail = new PaymentDetail()
            {
                CardNumber = detailDto.CardNumber,
                CardOwnerName = detailDto.CardOwnerName,
                ExpirationDate = detailDto.ExpirationDate,
                Cvv = detailDto.Cvv
            };
            var status= await paymentDataService.AddPaymentDetails(paymentDetail);
            return (status);
        }
    }
}
