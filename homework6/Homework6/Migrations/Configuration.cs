namespace Homework6.Migrations
{
    using Homework6.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Homework6.Models.PetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Homework6.Models.PetDBContext context)
        {
            context.Pets.AddOrUpdate(i => i.Name,
                new Pet
                {
                      ID = 1,
                      Name = "Woofy",
                      DescriptionShort = "Woofy is cute.",
                      DescriptionLong = "Woofy is reeeeally reallllllyyyyy cute.",
                      DateReceived = DateTime.Parse("1989-1-11"),
                      Quantity = 1,
                      Price = 100m
                },

                new Pet
                {
                      ID = 2,
                      Name = "Doggeh",
                      DescriptionShort = "Doggeh is cute.",
                      DescriptionLong = "Doggeh is reeeeally reallllllyyyyy cute.",
                      DateReceived = DateTime.Parse("1989-2-11"),
                      Quantity = 1,
                      Price = 100m
                },

                new Pet
                {
                      ID = 3,
                      Name = "Urf",
                      DescriptionShort = "Urf is cute.",
                      DescriptionLong = "WoUrfofy is reeeeally reallllllyyyyy cute.",
                      DateReceived = DateTime.Parse("1989-3-11"),
                      Quantity = 1,
                      Price = 100m
                }


                 
           );

        }
    }
}
