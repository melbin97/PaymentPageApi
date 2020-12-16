using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentPage.Data;

namespace PaymentPage.DataServices.EntityConfigurations
{
    class PaymentDetailsEntityConfiguration:IEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.CardOwnerName).IsRequired().HasMaxLength(100);
            builder.Property(o => o.CardNumber).IsRequired().HasMaxLength(16);
            builder.Property(o => o.ExpirationDate).IsRequired().HasMaxLength(5);
            builder.Property(o => o.Cvv).IsRequired().HasMaxLength(3);
        }
    }
}
