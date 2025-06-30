using Riksbyggen.Backend.Models;

namespace Riksbyggen.Backend.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Companies.Any()) { return; }

            var companies = new[]
            {
                new Company { Name = "Riksbyggen" },
                new Company { Name = "Göteborgshem" },
                new Company { Name = "Brf Lägenhetsbacken" },
            };

            context.Companies.AddRange(companies);
            context.SaveChanges();
            
            var apartments = new[]
            {            
                // Riksbyggen apartments
                new Apartment
                {
                    CompanyId = companies[0].Id,
                    Address = "Kungsbron 21, Stockholm"
                },
                new Apartment
                {
                    CompanyId = companies[0].Id,
                    Address = "Hammarbybacken 27, Stockholm"
                },

                //Göteborgshem apartments
                new Apartment
                {
                    CompanyId = companies[1].Id,
                    Address = "Östra hamngatan 12, lgh A1001, Göteborg"
                },
                new Apartment
                {
                    CompanyId = companies[1].Id,
                    Address = "Östra hamngatan 12, lgh A1002, Göteborg"
                },
                new Apartment
                {
                    CompanyId = companies[1].Id,
                    Address = "Östra hamngatan 12, lgh A1003, Göteborg"
                },
                new Apartment
                {
                    CompanyId = companies[1].Id,
                    Address = "Kungsportsavenyen 10, Göteborg"
                },

                // Brf Lägenhetsbacken
                new Apartment {
                    CompanyId = companies[2].Id,
                    Address = "Lägenhet A1001"
                },
                new Apartment {
                    CompanyId = companies[2].Id,
                    Address = "Lägenhet A1002"
                },
                new Apartment {
                    CompanyId = companies[2].Id,
                    Address = "Lägenhet A1101"
                },
                new Apartment {
                    CompanyId = companies[2].Id,
                    Address = "Lägenhet A1102"
                },
                 new Apartment {
                    CompanyId = companies[2].Id,
                    Address = "Lägenhet A1201"
                },
                new Apartment {
                    CompanyId = companies[2].Id,
                    Address = "Lägenhet A1202"
                }, 
            };

            context.Apartments.AddRange(apartments);
            context.SaveChanges();

            var contracts = new[]
            {
                new Contract
                {
                    ApartmentId = apartments[0].Id,
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2025, 12, 31) 
                },
                new Contract
                {
                    ApartmentId = apartments[1].Id,
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2025, 5, 31)
                },
                new Contract
                {
                    ApartmentId = apartments[2].Id,
                    StartDate = new DateTime(2024, 9, 1),
                    EndDate = new DateTime(2025, 8, 31)
                },
                new Contract
                {
                    ApartmentId = apartments[4].Id,
                    StartDate = new DateTime(2024, 3, 1),
                    EndDate = new DateTime(2025, 2, 28) 
                },
                new Contract
                {
                    ApartmentId = apartments[5].Id,
                    StartDate = new DateTime(2024, 7, 1),
                    EndDate = new DateTime(2026, 6, 30) 
                },

                new Contract
                {
                    ApartmentId = apartments[6].Id,
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2024, 12, 31)
                },
                new Contract
                {
                    ApartmentId = apartments[7].Id,
                    StartDate = new DateTime(2022, 8, 1),
                    EndDate = new DateTime(2025, 8, 1) 
                },

                new Contract
                {
                    ApartmentId = apartments[8].Id,
                    StartDate = new DateTime(2025, 3, 1),
                    EndDate = new DateTime(2026, 2, 28) 
                },
                new Contract
                {
                    ApartmentId = apartments[9].Id,
                    StartDate = new DateTime(2025, 6, 1),
                    EndDate = new DateTime(2025, 08, 31) 
                },

                new Contract
                {
                    ApartmentId = apartments[3].Id,
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2023, 12, 31) 
                },
                new Contract
                {
                    ApartmentId = apartments[3].Id,
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2025, 12, 31) 
                }
            };

            context.Contracts.AddRange(contracts);

            context.SaveChanges();
        }
    }
}
