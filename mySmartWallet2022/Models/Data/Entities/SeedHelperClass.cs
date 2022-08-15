﻿namespace mySmartWallet2022.Models.Data.Entities
{
    public class SeedHelperClass
    {
        public static async Task seed(ApplicationDbContext context)
        {
            if (!context.Customers.Any())
            {

                context.Customers.Add(new Customer

                {
                    FirstName = "Isreal",
                    LastName = "opeloyeru",
                    MiddleName = "Oladimeji",
                    gender = GenderEnum.male,
                    MaritalStatus= MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "England",
                    State = "London",
                    City ="Manhattan",
                    Active = true,

                });
                context.Customers.Add(new Customer

                {
                    FirstName = "Clara",
                    LastName = "Ade",
                    MiddleName = "lola",
                    gender = GenderEnum.Female,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-10),
                    Country = "England",
                    State = "London",
                    City = "Manhattan",
                    Active = true,

                }
                    );
                // context.SaveChangesAsync();
                await context.SaveChangesAsync();
            }
        
        }
    }
}
