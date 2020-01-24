using UserManagement.Models;

namespace UserManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UserManagement.Models.UserManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserManagement.Models.UserManagementContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Users.AddOrUpdate(p => p.Id,
                new User { firstName = "Allen", lastName = "Sugar", Email = "AlSugar@gmail.com", mobileNumber = "07362251765", dateOfBirth = DateTime.Parse("05-04-1998"), lastModified = DateTime.Parse("21/01/2020") },
                new User { firstName = "Kim", lastName = "Brown", Email = "Kimbi@gmail.com", mobileNumber = "07736454443", dateOfBirth = DateTime.Parse("01-04-1992"), lastModified = DateTime.Parse("21/01/2020") },
                new User { firstName = "Janita", lastName = "Mary", Email = "JanitaM@gmail.com", mobileNumber = "074253647563", dateOfBirth = DateTime.Parse("09-04-1995"), lastModified = DateTime.Parse("21/01/2020") }
                );
        }
    }
}
