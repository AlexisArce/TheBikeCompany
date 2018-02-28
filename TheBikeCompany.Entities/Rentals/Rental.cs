namespace TheBikeCompany.Entities.Rentals
{
    public abstract class Rental
    {
        public short Amount { get; set; }
        public abstract decimal GetCharge();      
    }
}
