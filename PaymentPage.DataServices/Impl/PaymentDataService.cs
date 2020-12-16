using PaymentPage.Data;
using PaymentPage.DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPage.DataServices.Impl
{
    public class PaymentDataService : IPaymentDataService
    {
        private readonly AppDbContext db;
        public PaymentDataService(AppDbContext db)
        {
            this.db = db;
        }

        async Task<bool> IPaymentDataService.AddPaymentDetails(PaymentDetail paymentDetail)
        {
            db.Add(paymentDetail);
            var rowsAffected=db.SaveChanges();
            return await Task.FromResult(rowsAffected > 0);
        }

        async Task<List<PaymentDetail>> IPaymentDataService.GetPaymentDetails()
        {
            List<PaymentDetail> details = db.PaymentDetail.Select(p => p).ToList();
            return await Task.FromResult(details);
        }
    }
}