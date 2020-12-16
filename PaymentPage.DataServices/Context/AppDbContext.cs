using Microsoft.EntityFrameworkCore;
using PaymentPage.Data;
using System;

namespace PaymentPage.DataServices
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<PaymentDetail> PaymentDetail { get; set; }

    }
}
