using System.Collections.Generic;
using System.Linq;
using TheBikeCompany.Entities.Rentals;

namespace TheBikeCompany.Entities.Promotions
{
    public class PromotionFactory
    {
        public IPromotion Create(IEnumerable<Rental> rentals)
        {
            var rentalsCount = rentals.Count();
            if (rentalsCount >= 3 && rentalsCount <= 5)
                return new FamilyPromotion();
            else
                return new NoPromotion();
        }
    }
}