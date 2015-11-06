using CIS.Application.Entities;
using System.Data.Entity;

namespace CIS.Data.DataAccess
{
    class ClinicInitializer : DropCreateDatabaseAlways<ClinicModel>
    {
        protected override void Seed(ClinicModel context)
        {
            User exampleUser = new User()
            {
                FirstName = "John",
                LastName = "Smith",
                Username = "jsmith",
                Password = "password"
            };

            context.Users.Add(exampleUser);

            base.Seed(context);
        }
    }
}
