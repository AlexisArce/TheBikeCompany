using System.Collections.Generic;
using System.Linq;
using TheBikeCompany.Entities.Promotions;
using TheBikeCompany.Entities.Rentals;

namespace TheBikeCompany.Entities.Invoices
{
    public class Invoice
    {
        public IEnumerable<Rental> Rentals { get; set; }

        public decimal GetTotal()
        {
            var promotion = new PromotionFactory()
                                .Create(Rentals)
                                .Discount();

            var total = Rentals.Sum(x => x.GetCharge());
            total *= promotion;

            return total;
        }
    }
}