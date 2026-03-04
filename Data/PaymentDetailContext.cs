using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Data
{
    public class PaymentDetailContext :DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {
        }

        public DbSet<Models.PaymentDetail> PaymentDetails { get; set; }
    }
}
