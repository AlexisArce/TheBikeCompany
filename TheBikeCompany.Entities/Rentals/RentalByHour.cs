namespace TheBikeCompany.Entities.Rentals
{
    public class RentalByHour : Rental
    {
        public override decimal GetCharge()
        {
            return Amount * 5.00M;
        }
    }
}