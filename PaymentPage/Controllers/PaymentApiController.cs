using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentPage.BusinessServices.Contracts;
using PaymentPage.BusinessServices.Dtos;
using PaymentPage.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentPage.Web.Controllers
{
    [ApiController]
    public class PaymentApiController : ControllerBase
    {
        private readonly IPaymentService paymentService;
        public PaymentApiController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        [Route("api/view/payment")]
        [HttpGet]
        public async Task<IActionResult> GetPaymentDetail()
        {
            var outletDtos = await paymentService.GetPaymentDetails();
            List<PaymentDetailVM> paymentDetailVM = outletDtos.Select(p => new PaymentDetailVM()
            { Id = p.Id, CardNumber = p.CardNumber, CardOwnerName = p.CardOwnerName, Cvv = p.Cvv, ExpirationDate = p.ExpirationDate })
            .ToList();
            return Ok(paymentDetailVM);
        }
        [Route("api/add/payment")]
        [HttpPost]
        public async Task<IActionResult> AddPaymentDetail([FromBody] PaymentDetailCM paymentDetailCM)
        {
            PaymentDetailDto dto = new PaymentDetailDto()
            {
                CardOwnerName = paymentDetailCM.CardOwnerName,
                CardNumber = paymentDetailCM.CardNumber,
                Cvv = paymentDetailCM.Cvv,
                ExpirationDate = paymentDetailCM.ExpirationDate
            };
            var status=await paymentService.AddPaymentDetails(dto);
            Console.WriteLine(status);
            return Ok(dto);
        }
    }
}
