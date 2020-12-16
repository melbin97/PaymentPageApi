using System;

namespace PaymentPage.Data
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string Cvv { get; set; }

    }
}
