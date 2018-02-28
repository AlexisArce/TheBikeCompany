namespace TheBikeCompany.Entities.Rentals
{
    public class RentalByWeek : Rental
    {
        public override decimal GetCharge()
        {
            return Amount * 60.00M;
        }
    }
}
