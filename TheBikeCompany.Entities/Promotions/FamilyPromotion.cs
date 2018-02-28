namespace TheBikeCompany.Entities.Promotions
{
    public class FamilyPromotion : IPromotion
    {
        decimal IPromotion.Discount()
        {
            return 0.7M;
        }
    }
}