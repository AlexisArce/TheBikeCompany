using System;
using System.Collections.Generic;
using TheBikeCompany.Entities.Invoices;
using TheBikeCompany.Entities.Rentals;
using Xunit;

namespace TheBikeCompany.Tests
{
    public class InvoiceTest
    {
        [Fact]
        public void RentalByHour_Charge_5()
        {
            var invoice = new Invoice()
            {
                Rentals = new List<Rental>()
                {
                    new RentalByHour()
                    {
                        Amount = 1
                    }
                }
            };

            var result = invoice.GetTotal();

            Assert.Equal(result, 5);
        }
   
        [Fact]
        public void RentalByDay_Charge_20()
        {
            var invoice = new Invoice()
            {
                Rentals = new List<Rental>()
                {
                    new RentalByDay()
                    {
                        Amount = 1
                    }
                }
            };

            var result = invoice.GetTotal();

            Assert.Equal(result, 20);
        }

        [Fact]
        public void RentalByWeek_Charge_60()
        {
            var invoice = new Invoice()
            {
                Rentals = new List<Rental>()
                {
                    new RentalByWeek()
                    {
                        Amount = 1
                    }
                }
            };

            var result = invoice.GetTotal();

            Assert.Equal(result, 60);
        }

        [Fact]
        public void FamilyRental_ApplyPromotion()
        {
            var invoice = new Invoice()
            {
                Rentals = new List<Rental>()
                {
                    new RentalByHour()
                    {
                        Amount = 1
                    },
                    new RentalByDay()
                    {
                        Amount = 1
                    },
                    new RentalByWeek()
                    {
                        Amount = 1
                    }
                }
            };

            var expected = (5 + 20 + 60) * 0.7M;
            var result = invoice.GetTotal();

            Assert.Equal(result, expected);
        }

        [Fact]
        public void Rental_NoApplyPromotion()
        {
            var invoice = new Invoice()
            {
                Rentals = new List<Rental>()
                {
                    new RentalByHour()
                    {
                        Amount = 1
                    },
                    new RentalByDay()
                    {
                        Amount = 1
                    }
                }
            };

            var expected = 5 + 20;
            var result = invoice.GetTotal();

            Assert.Equal(result, expected);
        }
    }
}
