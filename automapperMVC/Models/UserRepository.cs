
using AutoMappersMVCExample.Models.Interfaces;

namespace AutoMappersMVCExample.Models.Repositories
{
    public class UserRepository : IUser
    {
        public User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "Ibrahim",
                LastName = "Shuja",
                Email = "ibrahim.shuja@gmail.com",

            };
        }
    }
}
