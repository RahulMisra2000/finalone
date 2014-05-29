namespace WebApplication2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Customers.AddOrUpdate(c => c.FName, 
                    new Customer { FName="rahul", Age=51},
                    new Customer { FName="ar", Age=10});


            // Let's create a role called "allusers"
            // Then we will create a user and assing that user to the role
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!rolemanager.RoleExists("allusers"))
            {
                var result0 = rolemanager.Create(new IdentityRole("allusers"));
                if (!result0.Succeeded)
                {
                    // There was a problem creating the role "allusers"
                }
            }
            
            // Now let's create a user and we will add him to the "allusers" role
            var u = new ApplicationUser();
            u.UserName = "rahulmisra2000@hotmail.com";            
            var result1 = usermanager.Create(u, "123saibaba!Q");
  
            if (result1.Succeeded)
                {
                    usermanager.AddToRole(u.Id, "allusers");
                }

            
        }
    }
}
