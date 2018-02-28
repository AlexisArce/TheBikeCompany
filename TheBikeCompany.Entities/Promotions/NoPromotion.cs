namespace TheBikeCompany.Entities.Promotions
{
    public class NoPromotion : IPromotion
    {        
        decimal IPromotion.Discount()
        {
            return 1;
        }
    }
}
