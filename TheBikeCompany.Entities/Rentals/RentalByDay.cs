namespace TheBikeCompany.Entities.Rentals
{
    public class RentalByDay : Rental
    {
        public override decimal GetCharge()
        { 
            return Amount * 20.00M;
        }
    }
}